namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeStatisticDates
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string StatGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeStatisticDates>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_STATISTIC_DATES");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatGroup)
                .HasColumnName("STAT_GROUP")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
