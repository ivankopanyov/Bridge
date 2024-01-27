namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HilifethMapping
{
    public string Resort { get; set; }
    public string RateCode { get; set; }
    public string RoomtypeGroup { get; set; }
    public decimal RoomCategory { get; set; }
    public decimal RateroomSeq { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HilifethMapping>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RateCode, e.RoomtypeGroup })
                .HasName("HILIFETH_MAPPING_PK");

            entity.ToTable("HILIFETH_MAPPING");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomtypeGroup)
                .HasColumnName("ROOMTYPE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateroomSeq)
                .HasColumnName("RATEROOM_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasColumnType("NUMBER");
        });
	}
}
