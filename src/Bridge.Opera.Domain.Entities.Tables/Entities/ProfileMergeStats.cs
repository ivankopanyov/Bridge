namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProfileMergeStats
{
    public decimal? ProfileMatchId { get; set; }
    public string? Resort { get; set; }
    public string? MergeCriteria { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? Points { get; set; }
    public decimal? Sequence { get; set; }
    public decimal? TotalPoints { get; set; }
    public string? NameType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileMergeStats>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROFILE_MERGE_STATS");

            entity.HasIndex(e => e.InsertDate)
                .HasName("PROFILE_MERGE_STATS_IND2");

            entity.HasIndex(e => e.ProfileMatchId)
                .HasName("PROFILE_MERGE_STATS_IND1");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MergeCriteria)
                .IsRequired()
                .HasColumnName("MERGE_CRITERIA")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileMatchId)
                .HasColumnName("PROFILE_MATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sequence)
                .HasColumnName("SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPoints)
                .HasColumnName("TOTAL_POINTS")
                .HasColumnType("NUMBER");
        });
	}
}
