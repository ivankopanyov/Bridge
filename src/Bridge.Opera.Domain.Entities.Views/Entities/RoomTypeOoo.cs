namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomTypeOoo
{
    public string? Resort { get; set; }
    public DateTime? OooDate { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public decimal? Ooo { get; set; }
    public decimal? OwnerOoo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomTypeOoo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_TYPE_OOO");

            entity.Property(e => e.Ooo)
                .HasColumnName("OOO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OooDate)
                .HasColumnName("OOO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OwnerOoo)
                .HasColumnName("OWNER_OOO")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
