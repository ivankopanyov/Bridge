namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomKeyOptions
{
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public string? KeyOption { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomKeyOptions>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room, e.KeyOption })
                .HasName("RMKEY_PK");

            entity.ToTable("ROOM_KEY_OPTIONS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.KeyOption)
                .HasColumnName("KEY_OPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
