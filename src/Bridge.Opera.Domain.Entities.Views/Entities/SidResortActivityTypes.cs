namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidResortActivityTypes
{
    public string? Resort { get; set; }
    public string? ActivityType { get; set; }
    public string? Description { get; set; }
    public string? CentralYn { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? SendMethod { get; set; }
    public string? Url { get; set; }
    public string? TypeCode { get; set; }
    public string? AttachTemplateId { get; set; }
    public string? SurveyTemplateId { get; set; }
    public string? RequestId { get; set; }
    public string? ActivityClass { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidResortActivityTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RESORT$ACTIVITY_TYPES");

            entity.Property(e => e.ActivityClass)
                .HasColumnName("ACTIVITY_CLASS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActivityType)
                .IsRequired()
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttachTemplateId)
                .HasColumnName("ATTACH_TEMPLATE_ID")
                .IsUnicode(false);

            entity.Property(e => e.CentralYn)
                .HasColumnName("CENTRAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SendMethod)
                .HasColumnName("SEND_METHOD")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SurveyTemplateId)
                .HasColumnName("SURVEY_TEMPLATE_ID")
                .IsUnicode(false);

            entity.Property(e => e.TypeCode)
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Url)
                .HasColumnName("URL")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
