namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsYcSeasonStats
{
    public string Resort { get; set; }
    public string RoomCategory { get; set; }
    public string SeasonCode { get; set; }
    public DateTime? OneWeekBeginDate { get; set; }
    public decimal? MaxRate { get; set; }
    public string MaxRateCode { get; set; }
    public decimal? MinRate { get; set; }
    public string MinRateCode { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsYcSeasonStats>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RoomCategory, e.SeasonCode })
                .HasName("ORMS_YC_SEASON_STATS_PK");

            entity.ToTable("ORMS_YC_SEASON_STATS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaxRate)
                .HasColumnName("MAX_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxRateCode)
                .HasColumnName("MAX_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinRate)
                .HasColumnName("MIN_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinRateCode)
                .HasColumnName("MIN_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OneWeekBeginDate)
                .HasColumnName("ONE_WEEK_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
