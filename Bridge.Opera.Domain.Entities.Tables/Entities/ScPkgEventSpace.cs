namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScPkgEventSpace
{
    public string Resort { get; set; }
    public decimal PkgLink { get; set; }
    public decimal PkgEvId { get; set; }
    public string Room { get; set; }
    public string RoomSetup { get; set; }
    public string RoomRate { get; set; }
    public string ShareableYn { get; set; }
    public decimal OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPkgEventSpace>(entity =>
        {
            entity.HasKey(e => new { e.Room, e.PkgLink, e.PkgEvId, e.Resort })
                .HasName("SCPKG_EVSPA");

            entity.ToTable("SC$PKG_EVENT_SPACE");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgLink)
                .HasColumnName("PKG_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgEvId)
                .HasColumnName("PKG_EV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRate)
                .IsRequired()
                .HasColumnName("ROOM_RATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomSetup)
                .IsRequired()
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShareableYn)
                .HasColumnName("SHAREABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
