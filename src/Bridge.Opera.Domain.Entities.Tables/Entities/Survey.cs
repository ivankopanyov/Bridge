namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Survey
{
    public Survey()
    {
        SurveyDetails = new HashSet<SurveyDetails>();
    }

    public string? Resort { get; set; }
    public decimal? SurveyId { get; set; }
    public decimal? LinkedToId { get; set; }
    public string? LinkedToType { get; set; }
    public string? SurveyName { get; set; }
    public decimal? SurveyTemplateId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<SurveyDetails> SurveyDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Survey>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.SurveyId })
                .HasName("SURV_PK");

            entity.ToTable("SURVEY");

            entity.HasIndex(e => new { e.LinkedToType, e.LinkedToId })
                .HasName("SURV_UK")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SurveyId)
                .HasColumnName("SURVEY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkedToId)
                .HasColumnName("LINKED_TO_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LinkedToType)
                .HasColumnName("LINKED_TO_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SurveyName)
                .HasColumnName("SURVEY_NAME")
                .HasMaxLength(200)
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
        
			if (!types.Contains(typeof(SurveyDetails)))
				entity.Ignore(e => e.SurveyDetails);
		});
	}
}
