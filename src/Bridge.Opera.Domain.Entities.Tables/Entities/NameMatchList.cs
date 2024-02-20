namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameMatchList
{
    public decimal? MergeId { get; set; }
    public decimal? NameId1 { get; set; }
    public decimal? NameId2 { get; set; }
    public string? MergeKey { get; set; }
    public string? DoNotMergeFlg { get; set; }
    public decimal? DoNotMergeUid { get; set; }
    public DateTime? DoNotMergeDate { get; set; }
    public string? Status { get; set; }
    public string? ProcessingMessage { get; set; }
    public string? UserMessage { get; set; }
    public string? MergeCriteriaRuleCode { get; set; }
    public string? MatchDesc { get; set; }
    public decimal? MatchPoints { get; set; }
    public DateTime? PointsComputedDate { get; set; }
    public string? RuleCode { get; set; }
    public string? MergeDirectionFlg { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameMatchList>(entity =>
        {
            entity.HasKey(e => e.MergeId)
                .HasName("NAME_MATCH_LST_PK");

            entity.ToTable("NAME_MATCH_LIST");

            entity.HasIndex(e => e.MatchPoints)
                .HasName("NAME_MATCH_LST_IDX6");

            entity.HasIndex(e => e.MergeKey)
                .HasName("NAME_MATCH_LST_UKI1")
                .IsUnique();

            entity.HasIndex(e => e.NameId1)
                .HasName("NAME_MATCH_LST_IDX1");

            entity.HasIndex(e => e.NameId2)
                .HasName("NAME_MATCH_LST_IDX2");

            entity.HasIndex(e => e.RuleCode)
                .HasName("NAME_MATCH_LST_IDX5");

            entity.HasIndex(e => new { e.DoNotMergeFlg, e.RuleCode })
                .HasName("NAME_MATCH_LST_IDX4");

            entity.HasIndex(e => new { e.Status, e.DoNotMergeFlg, e.PointsComputedDate })
                .HasName("NAME_MATCH_LST_IDX3");

            entity.Property(e => e.MergeId)
                .HasColumnName("MERGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DoNotMergeDate)
                .HasColumnName("DO_NOT_MERGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DoNotMergeFlg)
                .IsRequired()
                .HasColumnName("DO_NOT_MERGE_FLG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.DoNotMergeUid)
                .HasColumnName("DO_NOT_MERGE_UID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MatchDesc)
                .HasColumnName("MATCH_DESC")
                .IsUnicode(false);

            entity.Property(e => e.MatchPoints)
                .HasColumnName("MATCH_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MergeCriteriaRuleCode)
                .HasColumnName("MERGE_CRITERIA_RULE_CODE")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.MergeDirectionFlg)
                .IsRequired()
                .HasColumnName("MERGE_DIRECTION_FLG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'1'");

            entity.Property(e => e.MergeKey)
                .IsRequired()
                .HasColumnName("MERGE_KEY")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId1)
                .HasColumnName("NAME_ID1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId2)
                .HasColumnName("NAME_ID2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsComputedDate)
                .HasColumnName("POINTS_COMPUTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProcessingMessage)
                .HasColumnName("PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'NEW'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserMessage)
                .HasColumnName("USER_MESSAGE")
                .IsUnicode(false);
        });
	}
}
