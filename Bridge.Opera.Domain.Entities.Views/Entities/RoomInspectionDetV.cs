namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RoomInspectionDetV
{
    public string Template { get; set; }
    public string Question { get; set; }
    public string Quality { get; set; }
    public string Resort { get; set; }
    public decimal? WoGenerated { get; set; }
    public decimal? TaskCode { get; set; }
    public string TaskDesc { get; set; }
    public decimal RiTemplateId { get; set; }
    public decimal RiId { get; set; }
    public decimal RiQuestionId { get; set; }
    public decimal? RiQuestionSeq { get; set; }
    public decimal? RiAnswerValue { get; set; }
    public string Answer { get; set; }
    public string RiAnswerNote { get; set; }
    public decimal? RiPointsAchieved { get; set; }
    public decimal? MaxPoints { get; set; }
    public decimal? Score { get; set; }
    public decimal? RiQualityLevel { get; set; }
    public string TaskStatus { get; set; }
    public string StatusDesc { get; set; }
    public string QuestionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomInspectionDetV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ROOM_INSPECTION_DET_V");

            entity.Property(e => e.Answer)
                .HasColumnName("ANSWER")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.MaxPoints)
                .HasColumnName("MAX_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quality)
                .HasColumnName("QUALITY")
                .IsUnicode(false);

            entity.Property(e => e.Question)
                .HasColumnName("QUESTION")
                .IsUnicode(false);

            entity.Property(e => e.QuestionType)
                .HasColumnName("QUESTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiAnswerNote)
                .HasColumnName("RI_ANSWER_NOTE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RiAnswerValue)
                .HasColumnName("RI_ANSWER_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiId)
                .HasColumnName("RI_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiPointsAchieved)
                .HasColumnName("RI_POINTS_ACHIEVED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiQualityLevel)
                .HasColumnName("RI_QUALITY_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiQuestionId)
                .HasColumnName("RI_QUESTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiQuestionSeq)
                .HasColumnName("RI_QUESTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiTemplateId)
                .HasColumnName("RI_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Score)
                .HasColumnName("SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusDesc)
                .HasColumnName("STATUS_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskDesc)
                .HasColumnName("TASK_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TaskStatus)
                .HasColumnName("TASK_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.Template)
                .HasColumnName("TEMPLATE")
                .IsUnicode(false);

            entity.Property(e => e.WoGenerated)
                .HasColumnName("WO_GENERATED")
                .HasColumnType("NUMBER");
        });
	}
}
