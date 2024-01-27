namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidUnitOfTime
{
    public string Resort { get; set; }
    public string UotCode { get; set; }
    public string Description { get; set; }
    public decimal? InDays { get; set; }
    public decimal? InHours { get; set; }
    public decimal? InMinutes { get; set; }
    public decimal DurationInMinutes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidUnitOfTime>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_UNIT_OF_TIME");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DurationInMinutes)
                .HasColumnName("DURATION_IN_MINUTES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InDays)
                .HasColumnName("IN_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InHours)
                .HasColumnName("IN_HOURS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InMinutes)
                .HasColumnName("IN_MINUTES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UotCode)
                .IsRequired()
                .HasColumnName("UOT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
