namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateUpdate
{
    public decimal GdsRateUpdateId { get; set; }
    public decimal GdsRefreshId { get; set; }
    public string GdsHost { get; set; }
    public string GdsResort { get; set; }
    public string GdsRecord { get; set; }
    public DateTime? BeginDate { get; set; }
    public string OrderBy { get; set; }
    public string Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateUpdate>(entity =>
        {
            entity.ToTable("GDS_RATE_UPDATE");

            entity.HasIndex(e => new { e.GdsHost, e.BeginDate })
                .HasName("GDS_RATE_UPDATE_IND1");

            entity.Property(e => e.GdsRateUpdateId)
                .HasColumnName("GDS_RATE_UPDATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.GdsRecord)
                .IsRequired()
                .HasColumnName("GDS_RECORD")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GdsRefreshId)
                .HasColumnName("GDS_REFRESH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GdsResort)
                .IsRequired()
                .HasColumnName("GDS_RESORT")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
