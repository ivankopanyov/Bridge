namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RateSetRoomCategories
{
    public decimal? RateSetId { get; set; }
    public string? RoomCategory { get; set; }

    public virtual RateSet RateSet { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateSetRoomCategories>(entity =>
        {
            entity.HasKey(e => new { e.RateSetId, e.RoomCategory })
                .HasName("RATE_SET_ROOM_CATEGORIES_PK");

            entity.ToTable("RATE_SET_ROOM_CATEGORIES");

            entity.Property(e => e.RateSetId)
                .HasColumnName("RATE_SET_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(RateSet)))
				entity.Ignore(e => e.RateSet);
			else
	            entity.HasOne(d => d.RateSet)
	                .WithMany(p => p.RateSetRoomCategories)
	                .HasForeignKey(d => d.RateSetId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RATE_SET_JRNL_ID_FK");
        });
	}
}
