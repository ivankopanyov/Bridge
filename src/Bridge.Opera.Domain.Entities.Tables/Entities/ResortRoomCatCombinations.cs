namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortRoomCatCombinations
{
    public string? Resort { get; set; }
    public string? CombinationRoomCategory { get; set; }
    public string? ComponentRoomCategory { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortRoomCatCombinations>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CombinationRoomCategory, e.ComponentRoomCategory })
                .HasName("RESORT_ROOM_CAT_COMBINAT_PK");

            entity.ToTable("RESORT_ROOM_CAT_COMBINATIONS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CombinationRoomCategory)
                .HasColumnName("COMBINATION_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ComponentRoomCategory)
                .HasColumnName("COMPONENT_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("1 ");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
