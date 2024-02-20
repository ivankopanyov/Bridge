namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConBase
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string? HotelCode { get; set; }
    public string? BrandCode { get; set; }
    public string? ChainCode { get; set; }
    public string? IsoDateTime { get; set; }
    public string? CurrencyCode { get; set; }
    public string? HotelName { get; set; }
    public string? Region { get; set; }
    public string? SubRegion { get; set; }
    public string? PmsType { get; set; }
    public string? MajorVersion { get; set; }
    public string? SubVersion { get; set; }
    public string? PatchLevel { get; set; }
    public string? CrsType { get; set; }
    public decimal? PmsNoOfRecords { get; set; }
    public decimal? GuestsNoOfRecords { get; set; }
    public decimal? ReservationsNoOfRecords { get; set; }
    public decimal? StaysNoOfRecords { get; set; }
    public decimal? BlocksNoOfResords { get; set; }
    public decimal? AgentsNoOfRecords { get; set; }
    public decimal? RateplansNoOfRecords { get; set; }
    public decimal? RegretsNoOfRecords { get; set; }
    public decimal? RoomsNoOfRecords { get; set; }
    public DateTime? ExportDate { get; set; }
    public DateTime? EffectiveStartDate { get; set; }
    public DateTime? EffectiveEndDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_BASE");

            entity.Property(e => e.AgentsNoOfRecords)
                .HasColumnName("AGENTS_NO_OF_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlocksNoOfResords)
                .HasColumnName("BLOCKS_NO_OF_RESORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BrandCode)
                .HasColumnName("BRAND_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CrsType)
                .HasColumnName("CRS_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EffectiveEndDate)
                .HasColumnName("EFFECTIVE_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EffectiveStartDate)
                .HasColumnName("EFFECTIVE_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportDate)
                .HasColumnName("EXPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestsNoOfRecords)
                .HasColumnName("GUESTS_NO_OF_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HotelName)
                .HasColumnName("HOTEL_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IsoDateTime)
                .HasColumnName("ISO_DATE_TIME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MajorVersion)
                .HasColumnName("MAJOR_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PatchLevel)
                .HasColumnName("PATCH_LEVEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsNoOfRecords)
                .HasColumnName("PMS_NO_OF_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsType)
                .HasColumnName("PMS_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RateplansNoOfRecords)
                .HasColumnName("RATEPLANS_NO_OF_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RegretsNoOfRecords)
                .HasColumnName("REGRETS_NO_OF_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationsNoOfRecords)
                .HasColumnName("RESERVATIONS_NO_OF_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomsNoOfRecords)
                .HasColumnName("ROOMS_NO_OF_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StaysNoOfRecords)
                .HasColumnName("STAYS_NO_OF_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SubRegion)
                .HasColumnName("SUB_REGION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SubVersion)
                .HasColumnName("SUB_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
