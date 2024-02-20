namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExportPotentialForecast
{
    public string? RecordType { get; set; }
    public string? SourceSystem { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? ProfileId { get; set; }
    public string? ProfileName { get; set; }
    public string? Udfc40 { get; set; }
    public decimal? PotentialId { get; set; }
    public string? PotentialName { get; set; }
    public DateTime? PotentialStartDate { get; set; }
    public DateTime? PotentialEndDate { get; set; }
    public string? ForecastType { get; set; }
    public string? Resort { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? RoomAvgrate { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? FbRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExportPotentialForecast>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXPORT_POTENTIAL_FORECAST");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForecastType)
                .IsRequired()
                .HasColumnName("FORECAST_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PotentialEndDate)
                .HasColumnName("POTENTIAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PotentialId)
                .HasColumnName("POTENTIAL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PotentialName)
                .IsRequired()
                .HasColumnName("POTENTIAL_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PotentialStartDate)
                .HasColumnName("POTENTIAL_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileName)
                .HasColumnName("PROFILE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomAvgrate)
                .HasColumnName("ROOM_AVGRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.Udfc40)
                .HasColumnName("UDFC40")
                .IsUnicode(false);
        });
	}
}
