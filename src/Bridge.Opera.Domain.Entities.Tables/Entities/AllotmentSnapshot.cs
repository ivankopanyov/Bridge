namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AllotmentSnapshot
{
    public decimal? AllotmentHeaderId { get; set; }
    public string? Resort { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? SnapshotType { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public string? ScRoomCategory { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Occ1 { get; set; }
    public decimal? Occ2 { get; set; }
    public decimal? Occ3 { get; set; }
    public decimal? Occ4 { get; set; }
    public decimal? Rate1 { get; set; }
    public decimal? Rate2 { get; set; }
    public decimal? Rate3 { get; set; }
    public decimal? Rate4 { get; set; }
    public decimal? Rateap { get; set; }
    public byte? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? ChangeDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentSnapshot>(entity =>
        {
            entity.HasKey(e => new { e.AllotmentHeaderId, e.Resort, e.SnapshotType, e.AllotmentDate, e.RoomCategory })
                .HasName("ALLOTMENT_SNAPSHOT_PK");

            entity.ToTable("ALLOTMENT_SNAPSHOT");

            entity.HasIndex(e => new { e.Resort, e.ChangeDate })
                .HasName("ALLOTMENT_SNAPSHOT_UPD_IDX");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SnapshotType)
                .HasColumnName("SNAPSHOT_TYPE")
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

            entity.Property(e => e.ChangeDate)
                .HasColumnName("CHANGE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Occ1)
                .HasColumnName("OCC1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Occ2)
                .HasColumnName("OCC2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Occ3)
                .HasColumnName("OCC3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Occ4)
                .HasColumnName("OCC4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate1)
                .HasColumnName("RATE1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate2)
                .HasColumnName("RATE2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate3)
                .HasColumnName("RATE3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rate4)
                .HasColumnName("RATE4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rateap)
                .HasColumnName("RATEAP")
                .HasColumnType("NUMBER");

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
        });
	}
}
