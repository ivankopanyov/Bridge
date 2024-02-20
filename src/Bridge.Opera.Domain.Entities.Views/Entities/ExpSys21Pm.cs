namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21Pm
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? GuestName { get; set; }
    public string? AllotmentCode { get; set; }
    public string? RateCode { get; set; }
    public string? Udfc26 { get; set; }
    public string? GroupName { get; set; }
    public string? HotelCode { get; set; }
    public DateTime? BeginDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21Pm>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_PM");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfc26)
                .HasColumnName("UDFC26")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
