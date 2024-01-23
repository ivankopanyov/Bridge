namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsAvhMessage
{
    public decimal GdsAvhId { get; set; }
    public string GdsHost { get; set; }
    public string GdsResort { get; set; }
    public string ChainCode { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Nights { get; set; }
    public string GdsRateCode { get; set; }
    public string GdsRoomCategory { get; set; }
    public string ActionCode { get; set; }
    public decimal? Los { get; set; }
    public string LosDays { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAvhMessage>(entity =>
        {
            entity.HasKey(e => e.GdsAvhId)
                .HasName("GDS_AVH_MESSAGE_PK");

            entity.ToTable("GDS_AVH_MESSAGE");

            entity.Property(e => e.GdsAvhId)
                .HasColumnName("GDS_AVH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionCode)
                .IsRequired()
                .HasColumnName("ACTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCode)
                .IsRequired()
                .HasColumnName("GDS_RATE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GdsResort)
                .IsRequired()
                .HasColumnName("GDS_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRoomCategory)
                .IsRequired()
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LosDays)
                .HasColumnName("LOS_DAYS")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");
        });
	}
}
