namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PimActionLog
{
    public decimal? ActionId { get; set; }
    public string? ActionDesc { get; set; }
    public string? Resort { get; set; }
    public string? Machine { get; set; }
    public string? Terminal { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PimActionLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PIM$ACTION_LOG");

            entity.HasIndex(e => new { e.InsertUser, e.Resort })
                .HasName("PIM_USER_RESORT_IDX");

            entity.Property(e => e.ActionDesc)
                .IsRequired()
                .HasColumnName("ACTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .IsRequired()
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .IsRequired()
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
