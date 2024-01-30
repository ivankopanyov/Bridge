namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateRefresh
{
    public decimal? GdsRefreshId { get; set; }
    public string? Resort { get; set; }
    public string? Rate { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateRefresh>(entity =>
        {
            entity.HasKey(e => e.GdsRefreshId)
                .HasName("GDS_RATE_REFRESH_PK");

            entity.ToTable("GDS_RATE_REFRESH");

            entity.Property(e => e.GdsRefreshId)
                .HasColumnName("GDS_REFRESH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Rate)
                .IsRequired()
                .HasColumnName("RATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
