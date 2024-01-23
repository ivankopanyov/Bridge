namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosOwnerRooms
{
    public string Resort { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string RoomCategory { get; set; }
    public string RoomClass { get; set; }
    public string Room { get; set; }
    public decimal ContractId { get; set; }
    public string SuiteYn { get; set; }
    public string OwnerRental { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosOwnerRooms>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OVOS_OWNER_ROOMS");

            entity.HasIndex(e => new { e.Resort, e.ContractId, e.BeginDate, e.EndDate })
                .HasName("OOR_CONTRACT_IDX");

            entity.HasIndex(e => new { e.Resort, e.Room, e.BeginDate, e.EndDate })
                .HasName("OOR_ROOM_IDX");

            entity.HasIndex(e => new { e.Resort, e.BeginDate, e.EndDate, e.RoomCategory, e.SuiteYn, e.OwnerRental, e.Room })
                .HasName("OOR_UK")
                .IsUnique();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OwnerRental)
                .IsRequired()
                .HasColumnName("OWNER_RENTAL")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SuiteYn)
                .IsRequired()
                .HasColumnName("SUITE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
