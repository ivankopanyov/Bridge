namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpLuxStatecBase
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? TransmissionId { get; set; }
    public DateTime? RunDate { get; set; }
    public string RunType { get; set; }
    public string HotelCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpLuxStatecBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_LUX_STATEC_BASE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RunDate)
                .HasColumnName("RUN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RunType)
                .HasColumnName("RUN_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransmissionId)
                .HasColumnName("TRANSMISSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
