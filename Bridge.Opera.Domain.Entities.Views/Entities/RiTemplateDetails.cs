namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RiTemplateDetails
{
    public string Resort { get; set; }
    public decimal RiTemplateId { get; set; }
    public decimal RiQuestionId { get; set; }
    public decimal? RiQuestionSeq { get; set; }
    public string RiPointsAchieved { get; set; }
    public string RiQualityLevel { get; set; }
    public decimal? RiGenerateTask { get; set; }
    public string QuestionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RiTemplateDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RI_TEMPLATE_DETAILS");

            entity.Property(e => e.QuestionType)
                .IsRequired()
                .HasColumnName("QUESTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RiGenerateTask)
                .HasColumnName("RI_GENERATE_TASK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiPointsAchieved)
                .HasColumnName("RI_POINTS_ACHIEVED")
                .IsUnicode(false);

            entity.Property(e => e.RiQualityLevel)
                .HasColumnName("RI_QUALITY_LEVEL")
                .IsUnicode(false);

            entity.Property(e => e.RiQuestionId)
                .HasColumnName("RI_QUESTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiQuestionSeq)
                .HasColumnName("RI_QUESTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RiTemplateId)
                .HasColumnName("RI_TEMPLATE_ID")
                .HasColumnType("NUMBER");
        });
	}
}
