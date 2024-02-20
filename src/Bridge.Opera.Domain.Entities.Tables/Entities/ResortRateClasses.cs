namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortRateClasses
{
    public ResortRateClasses()
    {
        ResortRateCategory = new HashSet<ResortRateCategory>();
    }

    public string? Resort { get; set; }
    public string? RateClass { get; set; }
    public string? Descr { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? SellSequence { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? ResortResort { get; set; }

    public virtual Resort ResortNavigation { get; set; }
    public virtual ICollection<ResortRateCategory> ResortRateCategory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortRateClasses>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateClass })
                .HasName("RESORT_RATE_CLASSES_PK");

            entity.ToTable("RESORT_RATE_CLASSES");

            entity.HasIndex(e => e.ResortResort)
                .HasName("RESRATCLS_RESORT_FK_I");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateClass)
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Descr)
                .HasColumnName("DESCR")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResortResort)
                .HasColumnName("RESORT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellSequence)
                .HasColumnName("SELL_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ResortRateClasses)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESORT_FK13");
        
			if (!types.Contains(typeof(ResortRateCategory)))
				entity.Ignore(e => e.ResortRateCategory);
		});
	}
}
