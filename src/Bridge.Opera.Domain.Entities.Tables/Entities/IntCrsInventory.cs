namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntCrsInventory
{
    public decimal? CrsInventorySeq { get; set; }
    public string? Crsid { get; set; }
    public string? RoomType { get; set; }
    public string? RateCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? Inventory { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Resort { get; set; }
    public string? RateCategory { get; set; }
    public decimal? InventoryLowerThreshold { get; set; }
    public decimal? InventoryUpperThreshold { get; set; }
    public string? IncludeSellLimitYn { get; set; }
    public string? IncludeOooYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntCrsInventory>(entity =>
        {
            entity.HasKey(e => e.CrsInventorySeq)
                .HasName("INT_CRS_INVENTORY_PK");

            entity.ToTable("INT_CRS_INVENTORY");

            entity.HasIndex(e => new { e.Crsid, e.RoomType, e.RateCode, e.BeginDate, e.EndDate })
                .HasName("INT_CRS_INVENTORY_IDX1");

            entity.Property(e => e.CrsInventorySeq)
                .HasColumnName("CRS_INVENTORY_SEQ")
                .HasColumnType("NUMBER(32)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Crsid)
                .IsRequired()
                .HasColumnName("CRSID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IncludeOooYn)
                .HasColumnName("INCLUDE_OOO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IncludeSellLimitYn)
                .HasColumnName("INCLUDE_SELL_LIMIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER(32)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Inventory)
                .HasColumnName("INVENTORY")
                .HasColumnType("NUMBER(32)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InventoryLowerThreshold)
                .HasColumnName("INVENTORY_LOWER_THRESHOLD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InventoryUpperThreshold)
                .HasColumnName("INVENTORY_UPPER_THRESHOLD")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER(32)")
                .ValueGeneratedOnAdd();
        });
	}
}
