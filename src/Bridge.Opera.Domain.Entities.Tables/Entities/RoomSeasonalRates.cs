namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomSeasonalRates
{
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public decimal? RatecodeId { get; set; }
    public string? RateCode { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? RateAmount { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? RsrId { get; set; }
    public decimal? MinAdvance { get; set; }
    public decimal? MaxAdvance { get; set; }
    public string? MinimumRevenueYn { get; set; }
    public decimal? MinimumRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomSeasonalRates>(entity =>
        {
            entity.HasKey(e => e.RsrId)
                .HasName("SYS_C0035160");

            entity.ToTable("ROOM$SEASONAL_RATES");

            entity.HasIndex(e => new { e.Resort, e.Room, e.RateCode, e.StartDate, e.EndDate })
                .HasName("RSR_RES_ROOM_RATECODE_DATE_IDX")
                .IsUnique();

            entity.Property(e => e.RsrId)
                .HasColumnName("RSR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxAdvance)
                .HasColumnName("MAX_ADVANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinAdvance)
                .HasColumnName("MIN_ADVANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumRevenue)
                .HasColumnName("MINIMUM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinimumRevenueYn)
                .HasColumnName("MINIMUM_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RatecodeId)
                .HasColumnName("RATECODE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
