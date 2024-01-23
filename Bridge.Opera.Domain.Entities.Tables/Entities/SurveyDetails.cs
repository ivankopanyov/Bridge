namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SurveyDetails
{
    public SurveyDetails()
    {
        SurveyDetailChoices = new HashSet<SurveyDetailChoices>();
    }

    public string Resort { get; set; }
    public decimal SurveyId { get; set; }
    public decimal SurveyDetailId { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }
    public string AnswerRequiredYn { get; set; }
    public decimal? Score { get; set; }
    public decimal? QuestionId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? OrderBy { get; set; }

    public virtual Survey Survey { get; set; }
    public virtual ICollection<SurveyDetailChoices> SurveyDetailChoices { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SurveyDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.SurveyId, e.SurveyDetailId })
                .HasName("SURD_PK");

            entity.ToTable("SURVEY_DETAILS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SurveyId)
                .HasColumnName("SURVEY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SurveyDetailId)
                .HasColumnName("SURVEY_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Answer)
                .HasColumnName("ANSWER")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AnswerRequiredYn)
                .HasColumnName("ANSWER_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Question)
                .HasColumnName("QUESTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.QuestionId)
                .HasColumnName("QUESTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Score)
                .HasColumnName("SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Survey)))
				entity.Ignore(e => e.Survey);
			else
	            entity.HasOne(d => d.Survey)
	                .WithMany(p => p.SurveyDetails)
	                .HasForeignKey(d => new { d.Resort, d.SurveyId })
	                .HasConstraintName("SURVD_SURV_FK");
        
			if (!types.Contains(typeof(SurveyDetailChoices)))
				entity.Ignore(e => e.SurveyDetailChoices);
		});
	}
}
