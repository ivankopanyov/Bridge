namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SurveyDetailChoices
{
    public decimal AnswerId { get; set; }
    public string Resort { get; set; }
    public decimal SurveyId { get; set; }
    public decimal SurveyDetailId { get; set; }
    public decimal QuestionId { get; set; }
    public string Description { get; set; }
    public decimal? Score { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual SurveyDetails SurveyDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SurveyDetailChoices>(entity =>
        {
            entity.HasKey(e => e.AnswerId)
                .HasName("SURVDC_PK");

            entity.ToTable("SURVEY_DETAIL_CHOICES");

            entity.HasIndex(e => new { e.Resort, e.SurveyId, e.SurveyDetailId })
                .HasName("SURVDC");

            entity.Property(e => e.AnswerId)
                .HasColumnName("ANSWER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
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

            entity.Property(e => e.QuestionId)
                .HasColumnName("QUESTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Score)
                .HasColumnName("SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SurveyDetailId)
                .HasColumnName("SURVEY_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SurveyId)
                .HasColumnName("SURVEY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(SurveyDetails)))
				entity.Ignore(e => e.SurveyDetails);
			else
	            entity.HasOne(d => d.SurveyDetails)
	                .WithMany(p => p.SurveyDetailChoices)
	                .HasForeignKey(d => new { d.Resort, d.SurveyId, d.SurveyDetailId })
	                .HasConstraintName("SURVDC_SURVD_FK");
        });
	}
}
