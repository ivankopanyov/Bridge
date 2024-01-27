namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameCentralStatsInfo
{
    public decimal NameId { get; set; }
    public string Resort { get; set; }
    public decimal? TotalGuestNights { get; set; }
    public decimal? TotalGuestStays { get; set; }
    public decimal? TotalGuestNightsR { get; set; }
    public decimal? TotalGuestStaysR { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameCentralStatsInfo>(entity =>
        {
            entity.HasKey(e => new { e.NameId, e.Resort })
                .HasName("NSO_PK");

            entity.ToTable("NAME_CENTRAL_STATS_INFO");

            entity.HasIndex(e => e.InsertDate)
                .HasName("NAME_CENT_STAT_INFO_IDX1");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGuestNights)
                .HasColumnName("TOTAL_GUEST_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGuestNightsR)
                .HasColumnName("TOTAL_GUEST_NIGHTS_R")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGuestStays)
                .HasColumnName("TOTAL_GUEST_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalGuestStaysR)
                .HasColumnName("TOTAL_GUEST_STAYS_R")
                .HasColumnType("NUMBER");
        });
	}
}
