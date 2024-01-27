namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomSuiteComponents
{
    public string ComponentRoom { get; set; }
    public string MasterEntryYn { get; set; }
    public string Resort { get; set; }
    public string Room { get; set; }
    public decimal? VnPriority { get; set; }
    public string ComponentLabel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomSuiteComponents>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_SUITE_COMPONENTS");

            entity.Property(e => e.ComponentLabel)
                .IsRequired()
                .HasColumnName("COMPONENT_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ComponentRoom)
                .IsRequired()
                .HasColumnName("COMPONENT_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterEntryYn)
                .HasColumnName("MASTER_ENTRY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VnPriority)
                .HasColumnName("VN_PRIORITY")
                .HasColumnType("NUMBER");
        });
	}
}
