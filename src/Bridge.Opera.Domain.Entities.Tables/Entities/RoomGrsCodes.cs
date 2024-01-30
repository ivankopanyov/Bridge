namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomGrsCodes
{
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public string? GrsCode { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomGrsCodes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room, e.GrsCode })
                .HasName("RGC_PK");

            entity.ToTable("ROOM_GRS_CODES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GrsCode)
                .HasColumnName("GRS_CODE")
                .HasMaxLength(10)
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
