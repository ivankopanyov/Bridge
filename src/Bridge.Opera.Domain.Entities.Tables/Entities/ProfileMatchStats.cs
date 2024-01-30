namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileMatchStats
{
    public decimal? ProfileMatchId { get; set; }
    public string? Resort { get; set; }
    public string? MatchCriteria { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? Points { get; set; }
    public decimal? Sequence { get; set; }
    public string? NameType { get; set; }
    public decimal? ProcessTime { get; set; }
    public string? ResortNameId { get; set; }
    public decimal? OrsNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileMatchStats>(entity =>
        {
            entity.HasKey(e => e.ProfileMatchId)
                .HasName("PROFILE_MATCH_PK");

            entity.ToTable("PROFILE_MATCH_STATS");

            entity.HasIndex(e => new { e.Resort, e.MatchCriteria })
                .HasName("PROFILE_MATCH_ID2");

            entity.HasIndex(e => new { e.InsertDate, e.Resort, e.MatchCriteria })
                .HasName("PROFILE_MATCH_ID1");

            entity.Property(e => e.ProfileMatchId)
                .HasColumnName("PROFILE_MATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MatchCriteria)
                .IsRequired()
                .HasColumnName("MATCH_CRITERIA")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrsNameId)
                .HasColumnName("ORS_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessTime)
                .HasColumnName("PROCESS_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
