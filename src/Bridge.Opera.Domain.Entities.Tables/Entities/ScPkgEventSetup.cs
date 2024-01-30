namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScPkgEventSetup
{
    public string? Resort { get; set; }
    public decimal? PkgLink { get; set; }
    public decimal? PkgEvId { get; set; }
    public string? Room { get; set; }
    public string? RoomSetup { get; set; }
    public decimal? OrderBy { get; set; }
    public string? DefaultYn { get; set; }

    public virtual RoomSetup R { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPkgEventSetup>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.PkgLink, e.PkgEvId, e.Room, e.RoomSetup })
                .HasName("PKGEVSETUP_PK");

            entity.ToTable("SC$PKG_EVENT_SETUP");

            entity.HasIndex(e => new { e.Resort, e.Room, e.RoomSetup })
                .HasName("PKGEVSETUP_RMSETUP_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgLink)
                .HasColumnName("PKG_LINK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgEvId)
                .HasColumnName("PKG_EV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RoomSetup)))
				entity.Ignore(e => e.R);
			else
	            entity.HasOne(d => d.R)
	                .WithMany(p => p.ScPkgEventSetup)
	                .HasForeignKey(d => new { d.Resort, d.Room, d.RoomSetup })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PKGEVSETUP_RMSETUP_FK");
        });
	}
}
