namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SurveyTemplate
{
    public SurveyTemplate()
    {
        RoomInspectionDetails = new HashSet<RoomInspectionDetails>();
        RoomInspections = new HashSet<RoomInspections>();
        SurveyTemplateDetails = new HashSet<SurveyTemplateDetails>();
    }

    public string Resort { get; set; }
    public decimal SurveyTemplateId { get; set; }
    public string SurveyTemplateName { get; set; }
    public string SurveyTemplateType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<RoomInspectionDetails> RoomInspectionDetails { get; set; }
    public virtual ICollection<RoomInspections> RoomInspections { get; set; }
    public virtual ICollection<SurveyTemplateDetails> SurveyTemplateDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SurveyTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.SurveyTemplateId })
                .HasName("SURT_PK");

            entity.ToTable("SURVEY_TEMPLATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SurveyTemplateId)
                .HasColumnName("SURVEY_TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SurveyTemplateName)
                .IsRequired()
                .HasColumnName("SURVEY_TEMPLATE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SurveyTemplateType)
                .IsRequired()
                .HasColumnName("SURVEY_TEMPLATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(RoomInspectionDetails)))
				entity.Ignore(e => e.RoomInspectionDetails);

			if (!types.Contains(typeof(RoomInspections)))
				entity.Ignore(e => e.RoomInspections);

			if (!types.Contains(typeof(SurveyTemplateDetails)))
				entity.Ignore(e => e.SurveyTemplateDetails);
		});
	}
}
