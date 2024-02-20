namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomCombo
{
    public string? Resort { get; set; }
    public string? ComboRoom { get; set; }
    public string? ComboElement { get; set; }
    public decimal? PercentUtilized { get; set; }
    public decimal? AreaUtilized { get; set; }

    public virtual Room Room { get; set; }
    public virtual Room RoomNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomCombo>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ComboRoom, e.ComboElement })
                .HasName("RC_PK");

            entity.ToTable("ROOM$COMBO");

            entity.HasIndex(e => new { e.Resort, e.ComboElement })
                .HasName("RC_COMBO_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ComboRoom)
                .HasColumnName("COMBO_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ComboElement)
                .HasColumnName("COMBO_ELEMENT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AreaUtilized)
                .HasColumnName("AREA_UTILIZED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentUtilized)
                .HasColumnName("PERCENT_UTILIZED")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.Room);
			else
	            entity.HasOne(d => d.Room)
	                .WithMany(p => p.RoomComboRoom)
	                .HasForeignKey(d => new { d.Resort, d.ComboElement })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RC_ELEM_FK");

			if (!types.Contains(typeof(Room)))
				entity.Ignore(e => e.RoomNavigation);
			else
	            entity.HasOne(d => d.RoomNavigation)
	                .WithMany(p => p.RoomComboRoomNavigation)
	                .HasForeignKey(d => new { d.Resort, d.ComboRoom })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RC_COMBO_FK");
        });
	}
}
