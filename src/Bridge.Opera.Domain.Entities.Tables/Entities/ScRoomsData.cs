namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScRoomsData
{
    public decimal? MasterOrder { get; set; }
    public decimal? DetailUse { get; set; }
    public decimal? SummaryUse { get; set; }
    public decimal? Status1Use { get; set; }
    public decimal? Status2Use { get; set; }
    public decimal? TypePointer { get; set; }
    public string? Period { get; set; }
    public DateTime? PeriodStart { get; set; }
    public DateTime? PeriodEnd { get; set; }
    public DateTime? CurDate { get; set; }
    public string? Status { get; set; }
    public decimal? Rooms { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? DeductedRooms { get; set; }
    public decimal? CurrentRooms { get; set; }
    public decimal? CurrentRevenue { get; set; }
    public decimal? ContractRooms { get; set; }
    public decimal? ContractRevenue { get; set; }
    public decimal? TargetRooms { get; set; }
    public decimal? TargetRevenue { get; set; }
    public decimal? TargetAvgrate { get; set; }
    public decimal? TotalRooms { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalAvgrate { get; set; }
    public string? EventCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScRoomsData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SC_ROOMS_DATA");

            entity.HasIndex(e => new { e.MasterOrder, e.PeriodStart, e.PeriodEnd })
                .HasName("SRD_IDX");

            entity.Property(e => e.ContractRevenue)
                .HasColumnName("CONTRACT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractRooms)
                .HasColumnName("CONTRACT_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurDate)
                .HasColumnName("CUR_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrentRevenue)
                .HasColumnName("CURRENT_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentRooms)
                .HasColumnName("CURRENT_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeductedRooms)
                .HasColumnName("DEDUCTED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetailUse)
                .HasColumnName("DETAIL_USE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventCode)
                .HasColumnName("EVENT_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterOrder)
                .HasColumnName("MASTER_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Period)
                .HasColumnName("PERIOD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PeriodEnd)
                .HasColumnName("PERIOD_END")
                .HasColumnType("DATE");

            entity.Property(e => e.PeriodStart)
                .HasColumnName("PERIOD_START")
                .HasColumnType("DATE");

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .IsUnicode(false);

            entity.Property(e => e.Status1Use)
                .HasColumnName("STATUS1_USE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status2Use)
                .HasColumnName("STATUS2_USE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummaryUse)
                .HasColumnName("SUMMARY_USE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TargetAvgrate)
                .HasColumnName("TARGET_AVGRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TargetRevenue)
                .HasColumnName("TARGET_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TargetRooms)
                .HasColumnName("TARGET_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalAvgrate)
                .HasColumnName("TOTAL_AVGRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRooms)
                .HasColumnName("TOTAL_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TypePointer)
                .HasColumnName("TYPE_POINTER")
                .HasColumnType("NUMBER");
        });
	}
}
