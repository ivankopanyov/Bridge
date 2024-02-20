namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Locators
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? LocatorId { get; set; }
    public string? LocatorText { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? FromTime { get; set; }
    public DateTime? ToTime { get; set; }
    public string? EnteredBy { get; set; }
    public DateTime? EnteredOn { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Locators>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.LocatorId })
                .HasName("LOCATORS_PK");

            entity.ToTable("LOCATORS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LocatorId)
                .HasColumnName("LOCATOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EnteredBy)
                .HasColumnName("ENTERED_BY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EnteredOn)
                .HasColumnName("ENTERED_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.FromTime)
                .HasColumnName("FROM_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LocatorText)
                .HasColumnName("LOCATOR_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ToTime)
                .HasColumnName("TO_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.Locators)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("LOCATORS_FK_REF_RSV_NAME");
        });
	}
}
