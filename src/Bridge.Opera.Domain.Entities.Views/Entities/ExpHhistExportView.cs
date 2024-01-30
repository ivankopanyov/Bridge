namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpHhistExportView
{
    public decimal? Rooms { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? RateCode { get; set; }
    public string? PropertyCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpHhistExportView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_HHIST_EXPORT_VIEW");

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
