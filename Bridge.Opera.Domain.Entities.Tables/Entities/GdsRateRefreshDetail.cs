namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateRefreshDetail
{
    public decimal GdsRefreshId { get; set; }
    public string GdsHost { get; set; }
    public string Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateRefreshDetail>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.GdsRefreshId })
                .HasName("GDS_RATE_REFRESH_DETAIL_PK");

            entity.ToTable("GDS_RATE_REFRESH_DETAIL");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.GdsRefreshId)
                .HasColumnName("GDS_REFRESH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
