namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SurveyQuestions
{
    public SurveyQuestions()
    {
        SurveyTemplateDetails = new HashSet<SurveyTemplateDetails>();
    }

    public string Resort { get; set; }
    public decimal QuestionId { get; set; }
    public string QuestionType { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<SurveyTemplateDetails> SurveyTemplateDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SurveyQuestions>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.QuestionId })
                .HasName("SURQ_PK");

            entity.ToTable("SURVEY_QUESTIONS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.QuestionId)
                .HasColumnName("QUESTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QuestionType)
                .IsRequired()
                .HasColumnName("QUESTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(SurveyTemplateDetails)))
				entity.Ignore(e => e.SurveyTemplateDetails);
		});
	}
}
