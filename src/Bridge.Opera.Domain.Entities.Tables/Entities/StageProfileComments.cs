namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileComments
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public decimal LineNo { get; set; }
    public string CommentType { get; set; }
    public string Comments { get; set; }
    public string CommentTitle { get; set; }
    public string ValidFlg { get; set; }
    public string CommentResort { get; set; }
    public string ConfidentialYn { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileComments>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResortNameId, e.LineNo })
                .HasName("STAGE_PROFILE_COMMENTS_PK");

            entity.ToTable("STAGE_PROFILE_COMMENTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LineNo)
                .HasColumnName("LINE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommentResort)
                .HasColumnName("COMMENT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommentTitle)
                .HasColumnName("COMMENT_TITLE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CommentType)
                .HasColumnName("COMMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.ConfidentialYn)
                .HasColumnName("CONFIDENTIAL_YN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ValidFlg)
                .HasColumnName("VALID_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
