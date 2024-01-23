namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpdAllotStatDaily
{
    public string RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public string RoomCategory { get; set; }
    public DateTime AllotmentDate { get; set; }
    public decimal? PmsAllotmentHeaderId { get; set; }
    public decimal? PmsAllotmentDetailId { get; set; }
    public string AllotmentCode { get; set; }
    public decimal? ForcastedToSell { get; set; }
    public decimal? ToSell { get; set; }
    public decimal? Sold { get; set; }
    public decimal? Released { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? Adults { get; set; }
    public string ShoulderYn { get; set; }
    public DateTime? DmProcessed { get; set; }
    public string DmProcessedYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpdAllotStatDaily>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPD_ALLOT_STAT_DAILY");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DmProcessed)
                .HasColumnName("DM_PROCESSED")
                .HasColumnType("DATE");

            entity.Property(e => e.DmProcessedYn)
                .HasColumnName("DM_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForcastedToSell)
                .HasColumnName("FORCASTED_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsAllotmentDetailId)
                .HasColumnName("PMS_ALLOTMENT_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsAllotmentHeaderId)
                .HasColumnName("PMS_ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Released)
                .HasColumnName("RELEASED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.ShoulderYn)
                .HasColumnName("SHOULDER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Sold)
                .HasColumnName("SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToSell)
                .HasColumnName("TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");
        });
	}
}
