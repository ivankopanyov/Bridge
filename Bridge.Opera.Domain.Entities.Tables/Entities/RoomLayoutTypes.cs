namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomLayoutTypes
{
    public string Name { get; set; }
    public decimal Height { get; set; }
    public decimal Width { get; set; }
    public string VisualAttribute { get; set; }
    public string ShowToUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomLayoutTypes>(entity =>
        {
            entity.HasKey(e => e.Name)
                .HasName("ROOM_LAYOUT_TYPES_PK");

            entity.ToTable("ROOM_LAYOUT_TYPES");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Height)
                .HasColumnName("HEIGHT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShowToUser)
                .IsRequired()
                .HasColumnName("SHOW_TO_USER")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.VisualAttribute)
                .HasColumnName("VISUAL_ATTRIBUTE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Width)
                .HasColumnName("WIDTH")
                .HasColumnType("NUMBER");
        });
	}
}
