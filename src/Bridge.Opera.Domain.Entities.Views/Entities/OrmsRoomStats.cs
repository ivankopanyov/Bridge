namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsRoomStats
{
    public string? Resort { get; set; }
    public string? YieldCategory { get; set; }
    public string? RoomCategory { get; set; }
    public string? ShortDescription { get; set; }
    public string? YieldableYn { get; set; }
    public string? Label { get; set; }
    public decimal? NumberRooms { get; set; }
    public decimal? OrmsUpsellAmt { get; set; }
    public decimal? OrmsUpsellRank { get; set; }
    public decimal? MaxAmount { get; set; }
    public string? MaxSource { get; set; }
    public decimal? MinAmount { get; set; }
    public string? MinSource { get; set; }
    public string? Active { get; set; }
    public decimal? Phyoccrate { get; set; }
    public decimal? Logoccrate { get; set; }
    public byte? YcRank { get; set; }
    public string? YcRefRoomCategory { get; set; }
    public string? YcRefRoomCategoryYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsRoomStats>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_ROOM_STATS");

            entity.Property(e => e.Active)
                .HasColumnName("ACTIVE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Logoccrate)
                .HasColumnName("LOGOCCRATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxAmount)
                .HasColumnName("MAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxSource)
                .HasColumnName("MAX_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinAmount)
                .HasColumnName("MIN_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinSource)
                .HasColumnName("MIN_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberRooms)
                .HasColumnName("NUMBER_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsUpsellAmt)
                .HasColumnName("ORMS_UPSELL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsUpsellRank)
                .HasColumnName("ORMS_UPSELL_RANK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Phyoccrate)
                .HasColumnName("PHYOCCRATE")
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

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.YcRank).HasColumnName("YC_RANK");

            entity.Property(e => e.YcRefRoomCategory)
                .HasColumnName("YC_REF_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YcRefRoomCategoryYn)
                .HasColumnName("YC_REF_ROOM_CATEGORY_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.YieldCategory)
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
