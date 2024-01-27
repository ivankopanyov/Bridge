namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FlowThruRoomCategory
{
    public string Resort { get; set; }
    public string RoomCategory { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FlowThruRoomCategory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FLOW_THRU_ROOM_CATEGORY");

            entity.HasIndex(e => new { e.Resort, e.RoomCategory, e.BeginDate })
                .HasName("FLOW_THRU_UK")
                .IsUnique();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

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
        });
	}
}
