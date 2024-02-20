namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BktempAllotTyp
{
    public decimal? Keynumber { get; set; }
    public string? SummaryType { get; set; }
    public string? Chain { get; set; }
    public string? Resort { get; set; }
    public string? PmsAllotmentCode { get; set; }
    public decimal? PmsNumberAllotted { get; set; }
    public decimal? PmsNumberPickup { get; set; }
    public string? CrsAllotmentCode { get; set; }
    public decimal? CrsToSell { get; set; }
    public decimal? CrsSold { get; set; }
    public decimal? CrsElasticSold { get; set; }
    public decimal? CrsElastic { get; set; }
    public DateTime? CrsInactiveDate { get; set; }
    public decimal? RequestId { get; set; }
    public string? PmsRoomcat { get; set; }
    public string? CrsRoomcat { get; set; }
    public string? RoomcatShortDesc { get; set; }
    public string? CrsBookingStatus { get; set; }
    public string? CrsStatus { get; set; }
    public string? CrsDeductInventory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BktempAllotTyp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BKTEMP_ALLOT_TYP");

            entity.HasIndex(e => e.RequestId)
                .HasName("ALLOT_TAB_REQ_ID");

            entity.Property(e => e.Chain)
                .HasColumnName("CHAIN")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CrsAllotmentCode)
                .HasColumnName("CRS_ALLOTMENT_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CrsBookingStatus)
                .HasColumnName("CRS_BOOKING_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsDeductInventory)
                .HasColumnName("CRS_DEDUCT_INVENTORY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CrsElastic)
                .HasColumnName("CRS_ELASTIC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsElasticSold)
                .HasColumnName("CRS_ELASTIC_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsInactiveDate)
                .HasColumnName("CRS_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CrsRoomcat)
                .HasColumnName("CRS_ROOMCAT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CrsSold)
                .HasColumnName("CRS_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsStatus)
                .HasColumnName("CRS_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsToSell)
                .HasColumnName("CRS_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Keynumber)
                .HasColumnName("KEYNUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsAllotmentCode)
                .HasColumnName("PMS_ALLOTMENT_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PmsNumberAllotted)
                .HasColumnName("PMS_NUMBER_ALLOTTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsNumberPickup)
                .HasColumnName("PMS_NUMBER_PICKUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsRoomcat)
                .HasColumnName("PMS_ROOMCAT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomcatShortDesc)
                .HasColumnName("ROOMCAT_SHORT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SummaryType)
                .HasColumnName("SUMMARY_TYPE")
                .HasMaxLength(8)
                .IsUnicode(false);
        });
	}
}
