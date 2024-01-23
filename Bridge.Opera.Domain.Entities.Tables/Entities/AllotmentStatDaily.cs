namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentStatDaily
{
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
		modelBuilder.Entity<AllotmentStatDaily>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ALLOTMENT_STAT_DAILY");

            entity.HasIndex(e => new { e.AllotmentDate, e.Resort })
                .HasName("ALLOTMENT_STAT_DAILY_IND1");

            entity.HasIndex(e => new { e.Resort, e.PmsAllotmentHeaderId, e.PmsAllotmentDetailId })
                .HasName("ALLOTMENT_STAT_DAILY_IND2");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort, e.AllotmentDate, e.RoomCategory })
                .HasName("ALLOTMENT_STAT_DAILY_UK")
                .IsUnique();

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
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForcastedToSell)
                .HasColumnName("FORCASTED_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("SYSDATE");

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
                .HasColumnType("DATE")
                .HasDefaultValueSql(@"SYSDATE");
        });
	}
}
