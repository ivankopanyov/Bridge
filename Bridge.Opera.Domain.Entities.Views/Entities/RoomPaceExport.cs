namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomPaceExport
{
    public decimal? ExportId { get; set; }
    public string SourceSystem { get; set; }
    public string PropertyCode { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string ArrivePeriod { get; set; }
    public string ArriveYear { get; set; }
    public string ProductionPeriod { get; set; }
    public string ProductionYear { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? GroupCateringRevenue { get; set; }
    public decimal? LocalCateringRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomPaceExport>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_PACE_EXPORT");

            entity.Property(e => e.ArrivePeriod)
                .HasColumnName("ARRIVE_PERIOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArriveYear)
                .HasColumnName("ARRIVE_YEAR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupCateringRevenue)
                .HasColumnName("GROUP_CATERING_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalCateringRevenue)
                .HasColumnName("LOCAL_CATERING_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProductionPeriod)
                .HasColumnName("PRODUCTION_PERIOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProductionYear)
                .HasColumnName("PRODUCTION_YEAR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");
        });
	}
}
