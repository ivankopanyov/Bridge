namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GenericRoomtypeMapping
{
    public decimal? MapId { get; set; }
    public string? Resort { get; set; }
    public string? GenRoomCategory { get; set; }
    public string? PmsRoomCategory { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GenericRoomtypeMapping>(entity =>
        {
            entity.HasKey(e => e.MapId)
                .HasName("GRTM_PK");

            entity.ToTable("GENERIC_ROOMTYPE_MAPPING");

            entity.Property(e => e.MapId)
                .HasColumnName("MAP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GenRoomCategory)
                .IsRequired()
                .HasColumnName("GEN_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsRoomCategory)
                .IsRequired()
                .HasColumnName("PMS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
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
