namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentOffsetGrid
{
    public decimal? AllotmentHeaderId { get; set; }
    public string? Resort { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? OffsetType { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? ScRoomCategory { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Occ1 { get; set; }
    public decimal? Occ2 { get; set; }
    public decimal? Occ3 { get; set; }
    public decimal? Occ4 { get; set; }
    public decimal? PickupQuantity { get; set; }
    public decimal? PickupOcc1 { get; set; }
    public decimal? PickupOcc2 { get; set; }
    public decimal? PickupOcc3 { get; set; }
    public decimal? PickupOcc4 { get; set; }
    public decimal? Rate1 { get; set; }
    public decimal? Rate2 { get; set; }
    public decimal? Rate3 { get; set; }
    public decimal? Rate4 { get; set; }
    public decimal? Rateap { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual AllotmentOffsetType AllotmentOffsetType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentOffsetGrid>(entity =>
        {
            entity.HasKey(e => new { e.AllotmentHeaderId, e.Resort, e.AllotmentDate, e.RoomCategory, e.OffsetType })
                .HasName("ALLOTMENT_OFFSET_GRID");

            entity.ToTable("ALLOTMENT_OFFSET_GRID");

            entity.HasIndex(e => new { e.AllotmentHeaderId, e.Resort, e.OffsetType })
                .HasName("ALLOTMENT_OFFSET_GRID_FKI");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OffsetType)
                .HasColumnName("OFFSET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Occ1)
                .HasColumnName("OCC1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Occ2)
                .HasColumnName("OCC2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Occ3)
                .HasColumnName("OCC3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Occ4)
                .HasColumnName("OCC4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PickupOcc1)
                .HasColumnName("PICKUP_OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupOcc2)
                .HasColumnName("PICKUP_OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupOcc3)
                .HasColumnName("PICKUP_OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupOcc4)
                .HasColumnName("PICKUP_OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PickupQuantity)
                .HasColumnName("PICKUP_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rate1)
                .HasColumnName("RATE1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rate2)
                .HasColumnName("RATE2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rate3)
                .HasColumnName("RATE3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rate4)
                .HasColumnName("RATE4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rateap)
                .HasColumnName("RATEAP")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScRoomCategory)
                .HasColumnName("SC_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AllotmentOffsetType)))
				entity.Ignore(e => e.AllotmentOffsetType);
			else
	            entity.HasOne(d => d.AllotmentOffsetType)
	                .WithMany(p => p.AllotmentOffsetGrid)
	                .HasForeignKey(d => new { d.AllotmentHeaderId, d.Resort, d.OffsetType })
	                .HasConstraintName("ALLOTMENT_OFFSET_GRID_FK");
        });
	}
}
