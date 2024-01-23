namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosOverridesRooms
{
    public decimal OverrideId { get; set; }
    public string Room { get; set; }
    public decimal Points { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosOverridesRooms>(entity =>
        {
            entity.HasKey(e => new { e.OverrideId, e.Room })
                .HasName("OOM_PK");

            entity.ToTable("OVOS_OVERRIDES_ROOMS");

            entity.Property(e => e.OverrideId)
                .HasColumnName("OVERRIDE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");
        });
	}
}
