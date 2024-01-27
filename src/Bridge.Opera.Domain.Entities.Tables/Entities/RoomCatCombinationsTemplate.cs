namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomCatCombinationsTemplate
{
    public string CombinationRoomCategory { get; set; }
    public string ComponentRoomCategory { get; set; }
    public decimal? Quantity { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomCatCombinationsTemplate>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ROOM_CAT_COMBINATIONS_TEMPLATE");

            entity.Property(e => e.CombinationRoomCategory)
                .HasColumnName("COMBINATION_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

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
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
