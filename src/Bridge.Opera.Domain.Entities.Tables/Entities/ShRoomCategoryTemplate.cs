namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ShRoomCategoryTemplate
{
    public string RoomCategory { get; set; }
    public string SLabel { get; set; }
    public string SBedtype { get; set; }
    public string SellThruRuleYn { get; set; }
    public string CrsDescription { get; set; }
    public string ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ShRoomCategoryTemplate>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RoomCategory })
                .HasName("SH_ROOM_CATEGORY_TEMPLATE_PK");

            entity.ToTable("SH_ROOM_CATEGORY_TEMPLATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsDescription)
                .HasColumnName("CRS_DESCRIPTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SBedtype)
                .IsRequired()
                .HasColumnName("S_BEDTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SLabel)
                .IsRequired()
                .HasColumnName("S_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellThruRuleYn)
                .HasColumnName("SELL_THRU_RULE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");
        });
	}
}
