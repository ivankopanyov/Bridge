namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsResrtyUpdate
{
    public string Resort { get; set; }
    public string RoomTypeCode { get; set; }
    public string Description1 { get; set; }
    public string Description2 { get; set; }
    public string Description3 { get; set; }
    public decimal? MaxRoomOccupancy { get; set; }
    public decimal? PropupId { get; set; }
    public string GdsHost { get; set; }

    public virtual GdsPropupUpdate Propup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsResrtyUpdate>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RoomTypeCode })
                .HasName("GDS_RESRTY_UPDATE_PK");

            entity.ToTable("GDS_RESRTY_UPDATE");

            entity.HasIndex(e => e.PropupId)
                .HasName("GDS_RESRTY_UPDATE_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomTypeCode)
                .HasColumnName("ROOM_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description1)
                .IsRequired()
                .HasColumnName("DESCRIPTION1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description2)
                .HasColumnName("DESCRIPTION2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description3)
                .HasColumnName("DESCRIPTION3")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaxRoomOccupancy)
                .HasColumnName("MAX_ROOM_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropupId)
                .HasColumnName("PROPUP_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsPropupUpdate)))
				entity.Ignore(e => e.Propup);
			else
	            entity.HasOne(d => d.Propup)
	                .WithMany(p => p.GdsResrtyUpdate)
	                .HasForeignKey(d => d.PropupId)
	                .HasConstraintName("GDS_RESRTY_UPDATE_FK1");
        });
	}
}
