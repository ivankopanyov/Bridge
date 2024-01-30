namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SurveyTemplateDetails
{
    public string? Resort { get; set; }
    public decimal? SurveyTemplateDetailId { get; set; }
    public decimal? SurveyTemplateId { get; set; }
    public decimal? QuestionId { get; set; }
    public string? QuestionType { get; set; }
    public decimal? GenerateTask { get; set; }
    public string? AnswerRequiredYn { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual SurveyQuestions SurveyQuestions { get; set; }
    public virtual SurveyTemplate SurveyTemplate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SurveyTemplateDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.SurveyTemplateDetailId })
                .HasName("SURTD_PK");

            entity.ToTable("SURVEY_TEMPLATE_DETAILS");

            entity.HasIndex(e => new { e.Resort, e.QuestionId })
                .HasName("SURTD_SURQ_FK_IDX");

            entity.HasIndex(e => new { e.Resort, e.SurveyTemplateId })
                .HasName("SURTD_SURT_FK_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SurveyTemplateDetailId)
                .HasColumnName("SURVEY_TEMPLATE_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AnswerRequiredYn)
                .HasColumnName("ANSWER_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.GenerateTask)
                .HasColumnName("GENERATE_TASK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QuestionId)
                .HasColumnName("QUESTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QuestionType)
                .IsRequired()
                .HasColumnName("QUESTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SurveyTemplateId)
                .HasColumnName("SURVEY_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(SurveyQuestions)))
				entity.Ignore(e => e.SurveyQuestions);
			else
	            entity.HasOne(d => d.SurveyQuestions)
	                .WithMany(p => p.SurveyTemplateDetails)
	                .HasForeignKey(d => new { d.Resort, d.QuestionId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("SURTD_SURQ_FK");

			if (!types.Contains(typeof(SurveyTemplate)))
				entity.Ignore(e => e.SurveyTemplate);
			else
	            entity.HasOne(d => d.SurveyTemplate)
	                .WithMany(p => p.SurveyTemplateDetails)
	                .HasForeignKey(d => new { d.Resort, d.SurveyTemplateId })
	                .HasConstraintName("SURTD_SURT_FK");
        });
	}
}
