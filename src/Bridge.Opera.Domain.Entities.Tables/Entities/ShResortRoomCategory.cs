namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ShResortRoomCategory
{
    public string Resort { get; set; }
    public string RoomCategory { get; set; }
    public string SLabel { get; set; }
    public string SBedtype { get; set; }
    public string SellThruRuleYn { get; set; }
    public string CrsDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ShResortRoomCategory>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RoomCategory })
                .HasName("SH_RESORT_ROOM_CATEGORY_PK");

            entity.ToTable("SH_RESORT_ROOM_CATEGORY");

            entity.HasIndex(e => new { e.Resort, e.SLabel })
                .HasName("SH_RESORT_ROOM_CATEGORY_UK")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

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
                .IsUnicode(false);
        });
	}
}
