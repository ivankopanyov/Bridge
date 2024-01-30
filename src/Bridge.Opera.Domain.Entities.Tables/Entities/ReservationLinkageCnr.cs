namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationLinkageCnr
{
    public string? Resort { get; set; }
    public decimal? ConnectToResvNameId { get; set; }
    public decimal? ConnectedResvNameId { get; set; }
    public string? ConnectToRoom { get; set; }
    public string? ConnectedRoom { get; set; }

    public virtual ReservationName ReservationName { get; set; }
    public virtual ReservationName ReservationNameNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationLinkageCnr>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ConnectToResvNameId, e.ConnectedResvNameId })
                .HasName("RESERVATION_LINKAGE_CNR_PK");

            entity.ToTable("RESERVATION_LINKAGE_CNR");

            entity.HasIndex(e => new { e.Resort, e.ConnectedResvNameId })
                .HasName("RESV_LINKAGE_CNR_FK2");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConnectToResvNameId)
                .HasColumnName("CONNECT_TO_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConnectedResvNameId)
                .HasColumnName("CONNECTED_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConnectToRoom)
                .HasColumnName("CONNECT_TO_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConnectedRoom)
                .HasColumnName("CONNECTED_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.ReservationName);
			else
	            entity.HasOne(d => d.ReservationName)
	                .WithMany(p => p.ReservationLinkageCnrReservationName)
	                .HasForeignKey(d => new { d.Resort, d.ConnectToResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_LINKAGE_CNR_FK1");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.ReservationNameNavigation);
			else
	            entity.HasOne(d => d.ReservationNameNavigation)
	                .WithMany(p => p.ReservationLinkageCnrReservationNameNavigation)
	                .HasForeignKey(d => new { d.Resort, d.ConnectedResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESERVATION_LINKAGE_CNR_FK2");
        });
	}
}
