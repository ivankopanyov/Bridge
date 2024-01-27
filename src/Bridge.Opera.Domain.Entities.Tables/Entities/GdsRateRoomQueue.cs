namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateRoomQueue
{
    public string Resort { get; set; }
    public string GdsHost { get; set; }
    public string GdsRateCode { get; set; }
    public string GdsRoomCategory { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string RateCreateYn { get; set; }
    public decimal RateTier { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateRoomQueue>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.GdsHost, e.GdsRateCode, e.GdsRoomCategory, e.RateTier })
                .HasName("GDS_RATE_ROOM_QUE_PK");

            entity.ToTable("GDS_RATE_ROOM_QUEUE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCode)
                .HasColumnName("GDS_RATE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GdsRoomCategory)
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RateTier)
                .HasColumnName("RATE_TIER")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("-99 ");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCreateYn)
                .IsRequired()
                .HasColumnName("RATE_CREATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
