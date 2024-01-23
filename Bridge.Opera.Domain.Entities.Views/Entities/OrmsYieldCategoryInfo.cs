namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsYieldCategoryInfo
{
    public string Description { get; set; }
    public string Resort { get; set; }
    public string YieldCategory { get; set; }
    public decimal? MaxDemandTransfer { get; set; }
    public decimal? MaxTransfer { get; set; }
    public decimal? MinHurdle { get; set; }
    public decimal? MinOccCost { get; set; }
    public byte? Rank { get; set; }
    public string RefRateCode { get; set; }
    public string RefRoomCategory { get; set; }
    public decimal? NyWalkCost { get; set; }
    public decimal? YWalkCost { get; set; }
    public string Label { get; set; }
    public string Resort1 { get; set; }
    public string RoomCategory { get; set; }
    public string ShortDescription { get; set; }
    public string YieldableYn { get; set; }
    public string DisplayDefault { get; set; }
    public decimal? Sumnumberrooms { get; set; }
    public decimal? Sumnumberroomstotal { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsYieldCategoryInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_YIELD_CATEGORY_INFO");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.DisplayDefault)
                .HasColumnName("DISPLAY_DEFAULT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaxDemandTransfer)
                .HasColumnName("MAX_DEMAND_TRANSFER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxTransfer)
                .HasColumnName("MAX_TRANSFER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinHurdle)
                .HasColumnName("MIN_HURDLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinOccCost)
                .HasColumnName("MIN_OCC_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyWalkCost)
                .HasColumnName("NY_WALK_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rank).HasColumnName("RANK");

            entity.Property(e => e.RefRateCode)
                .HasColumnName("REF_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RefRoomCategory)
                .HasColumnName("REF_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort1)
                .HasColumnName("RESORT1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Sumnumberrooms)
                .HasColumnName("SUMNUMBERROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sumnumberroomstotal)
                .HasColumnName("SUMNUMBERROOMSTOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YWalkCost)
                .HasColumnName("Y_WALK_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .IsRequired()
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
