namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OutlookSyncDates
{
    public string? Resort { get; set; }
    public decimal? SrepId { get; set; }
    public DateTime? OutlookUpdateDate { get; set; }
    public DateTime? OperaUpdateDate { get; set; }
    public string? ClientTerminal { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OutlookSyncDates>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.SrepId })
                .HasName("OLSD_PK");

            entity.ToTable("OUTLOOK_SYNC_DATES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SrepId)
                .HasColumnName("SREP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClientTerminal)
                .HasColumnName("CLIENT_TERMINAL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OperaUpdateDate)
                .HasColumnName("OPERA_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OutlookUpdateDate)
                .HasColumnName("OUTLOOK_UPDATE_DATE")
                .HasColumnType("DATE");
        });
	}
}
