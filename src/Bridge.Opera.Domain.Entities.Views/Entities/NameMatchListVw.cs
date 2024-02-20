namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameMatchListVw
{
    public decimal? MergeId { get; set; }
    public decimal? N1NameId { get; set; }
    public string? N1NameType { get; set; }
    public string? N1NameTypeDisp { get; set; }
    public string? N1DisplayName { get; set; }
    public string? N1NameCode { get; set; }
    public string? N1ChainCode { get; set; }
    public string? N1ResortRegistererd { get; set; }
    public string? N1Last { get; set; }
    public string? N1First { get; set; }
    public string? N1Sname { get; set; }
    public string? N1SfirstName { get; set; }
    public string? N1Sxname { get; set; }
    public string? N1SxfirstName { get; set; }
    public decimal? N2NameId { get; set; }
    public string? N2NameType { get; set; }
    public string? N2NameTypeDisp { get; set; }
    public string? N2DisplayName { get; set; }
    public string? N2NameCode { get; set; }
    public string? N2ChainCode { get; set; }
    public string? N2ResortRegistererd { get; set; }
    public string? N2Last { get; set; }
    public string? N2First { get; set; }
    public string? N2Sname { get; set; }
    public string? N2SfirstName { get; set; }
    public string? N2Sxname { get; set; }
    public string? N2SxfirstName { get; set; }
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
		modelBuilder.Entity<NameMatchListVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_MATCH_LIST_VW");

            entity.Property(e => e.DoNotMergeDate)
                .HasColumnName("DO_NOT_MERGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DoNotMergeFlg)
                .IsRequired()
                .HasColumnName("DO_NOT_MERGE_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DoNotMergeUid)
                .HasColumnName("DO_NOT_MERGE_UID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

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
                .IsUnicode(false);

            entity.Property(e => e.MergeId)
                .HasColumnName("MERGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MergeKey)
                .IsRequired()
                .HasColumnName("MERGE_KEY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.N1ChainCode)
                .HasColumnName("N1_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.N1DisplayName)
                .HasColumnName("N1_DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.N1First)
                .HasColumnName("N1_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.N1Last)
                .HasColumnName("N1_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.N1NameCode)
                .HasColumnName("N1_NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.N1NameId)
                .HasColumnName("N1_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.N1NameType)
                .IsRequired()
                .HasColumnName("N1_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.N1NameTypeDisp)
                .HasColumnName("N1_NAME_TYPE_DISP")
                .IsUnicode(false);

            entity.Property(e => e.N1ResortRegistererd)
                .HasColumnName("N1_RESORT_REGISTERERD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.N1SfirstName)
                .HasColumnName("N1_SFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.N1Sname)
                .IsRequired()
                .HasColumnName("N1_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.N1SxfirstName)
                .HasColumnName("N1_SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.N1Sxname)
                .HasColumnName("N1_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.N2ChainCode)
                .HasColumnName("N2_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.N2DisplayName)
                .HasColumnName("N2_DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.N2First)
                .HasColumnName("N2_FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.N2Last)
                .HasColumnName("N2_LAST")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.N2NameCode)
                .HasColumnName("N2_NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.N2NameId)
                .HasColumnName("N2_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.N2NameType)
                .IsRequired()
                .HasColumnName("N2_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.N2NameTypeDisp)
                .HasColumnName("N2_NAME_TYPE_DISP")
                .IsUnicode(false);

            entity.Property(e => e.N2ResortRegistererd)
                .HasColumnName("N2_RESORT_REGISTERERD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.N2SfirstName)
                .HasColumnName("N2_SFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.N2Sname)
                .IsRequired()
                .HasColumnName("N2_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.N2SxfirstName)
                .HasColumnName("N2_SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.N2Sxname)
                .HasColumnName("N2_SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

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
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserMessage)
                .HasColumnName("USER_MESSAGE")
                .IsUnicode(false);
        });
	}
}
