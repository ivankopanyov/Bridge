namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsResortRefresh
{
    public decimal? GdsRefreshId { get; set; }
    public string? Resort { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? Status { get; set; }
    public string? RefreshType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsResortRefresh>(entity =>
        {
            entity.HasKey(e => e.GdsRefreshId)
                .HasName("GDS_RESORT_REFRESH_PK");

            entity.ToTable("GDS_RESORT_REFRESH");

            entity.HasIndex(e => new { e.Resort, e.RefreshType })
                .HasName("GDS_RESORT_REFRESH_IND1");

            entity.Property(e => e.GdsRefreshId)
                .HasColumnName("GDS_REFRESH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RefreshType)
                .HasColumnName("REFRESH_TYPE")
                .HasMaxLength(20)
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
