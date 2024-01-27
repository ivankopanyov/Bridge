namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScPeriod
{
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPeriod>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SC$PERIOD");

            entity.HasIndex(e => new { e.PeriodStart, e.PeriodEnd })
                .HasName("SP_UK")
                .IsUnique();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PeriodEnd)
                .HasColumnName("PERIOD_END")
                .HasColumnType("DATE");

            entity.Property(e => e.PeriodStart)
                .HasColumnName("PERIOD_START")
                .HasColumnType("DATE");
        });
	}
}
