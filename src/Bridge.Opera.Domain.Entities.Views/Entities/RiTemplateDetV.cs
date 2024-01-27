namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RiTemplateDetV
{
    public decimal RiTemplateId { get; set; }
    public string RiTemplateName { get; set; }
    public string Resort { get; set; }
    public string RiTemplateType { get; set; }
    public decimal RiQuestionId { get; set; }
    public string QuestionDesc { get; set; }
    public decimal? RiQuestionSeq { get; set; }
    public string RiQualityLevel { get; set; }
    public decimal? RiGenerateTask { get; set; }
    public string QuestionType { get; set; }
    public string TypeDescription { get; set; }
    public string TaskDescription { get; set; }
    public decimal RiTemplateDetailId { get; set; }
    public string AnswerRequiredYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RiTemplateDetV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RI_TEMPLATE_DET_V");

            entity.Property(e => e.AnswerRequiredYn)
                .HasColumnName("ANSWER_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QuestionDesc)
                .IsRequired()
                .HasColumnName("QUESTION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.QuestionType)
                .IsRequired()
                .HasColumnName("QUESTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiGenerateTask)
                .HasColumnName("RI_GENERATE_TASK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiQualityLevel)
                .HasColumnName("RI_QUALITY_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.RiQuestionId)
                .HasColumnName("RI_QUESTION_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiQuestionSeq)
                .HasColumnName("RI_QUESTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiTemplateDetailId)
                .HasColumnName("RI_TEMPLATE_DETAIL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiTemplateId)
                .HasColumnName("RI_TEMPLATE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RiTemplateName)
                .IsRequired()
                .HasColumnName("RI_TEMPLATE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RiTemplateType)
                .IsRequired()
                .HasColumnName("RI_TEMPLATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskDescription)
                .HasColumnName("TASK_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.TypeDescription)
                .HasColumnName("TYPE_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
