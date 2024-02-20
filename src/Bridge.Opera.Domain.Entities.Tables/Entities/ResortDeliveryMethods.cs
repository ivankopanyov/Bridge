namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortDeliveryMethods
{
    public string? Resort { get; set; }
    public string? DeliveryType { get; set; }
    public string? ReportName { get; set; }
    public string? EmailFrom { get; set; }
    public string? EmailYn { get; set; }
    public string? EmailFormat { get; set; }
    public string? EmailAttachYn { get; set; }
    public string? EmailBody { get; set; }
    public string? EmailFaxYn { get; set; }
    public string? EmailFaxFormat { get; set; }
    public string? EmailFaxPrefix { get; set; }
    public string? EmailFaxSuffix { get; set; }
    public string? EmailFaxDomain { get; set; }
    public string? EmailFaxAttachYn { get; set; }
    public string? EmailFaxBody { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? EmailServerName { get; set; }
    public string? EmailFaxServerName { get; set; }
    public string? EmailFaxFrom { get; set; }
    public string? EmailUserId { get; set; }
    public string? EmailUserPassword { get; set; }
    public string? EmailFaxUserId { get; set; }
    public string? EmailFaxUserPassword { get; set; }
    public string? EmailFaxBodyYn { get; set; }
    public string? EmailFaxSubjectYn { get; set; }
    public string? EmailSubject { get; set; }
    public string? FaxSubject { get; set; }
    public string? InboundEmailServer { get; set; }
    public string? EmailAttachIcalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortDeliveryMethods>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DeliveryType })
                .HasName("RESORT_DELIVERY_PK");

            entity.ToTable("RESORT_DELIVERY_METHODS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeliveryType)
                .HasColumnName("DELIVERY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailAttachIcalYn)
                .HasColumnName("EMAIL_ATTACH_ICAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailAttachYn)
                .HasColumnName("EMAIL_ATTACH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailBody)
                .HasColumnName("EMAIL_BODY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxAttachYn)
                .HasColumnName("EMAIL_FAX_ATTACH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxBody)
                .HasColumnName("EMAIL_FAX_BODY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxBodyYn)
                .HasColumnName("EMAIL_FAX_BODY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxDomain)
                .HasColumnName("EMAIL_FAX_DOMAIN")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxFormat)
                .HasColumnName("EMAIL_FAX_FORMAT")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxFrom)
                .HasColumnName("EMAIL_FAX_FROM")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxPrefix)
                .HasColumnName("EMAIL_FAX_PREFIX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxServerName)
                .HasColumnName("EMAIL_FAX_SERVER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxSubjectYn)
                .HasColumnName("EMAIL_FAX_SUBJECT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxSuffix)
                .HasColumnName("EMAIL_FAX_SUFFIX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxUserId)
                .HasColumnName("EMAIL_FAX_USER_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EmailFaxUserPassword)
                .HasColumnName("EMAIL_FAX_USER_PASSWORD")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailFaxYn)
                .HasColumnName("EMAIL_FAX_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailFormat)
                .HasColumnName("EMAIL_FORMAT")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EmailFrom)
                .HasColumnName("EMAIL_FROM")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailServerName)
                .HasColumnName("EMAIL_SERVER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EmailSubject)
                .HasColumnName("EMAIL_SUBJECT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EmailUserId)
                .HasColumnName("EMAIL_USER_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EmailUserPassword)
                .HasColumnName("EMAIL_USER_PASSWORD")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FaxSubject)
                .HasColumnName("FAX_SUBJECT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InboundEmailServer)
                .HasColumnName("INBOUND_EMAIL_SERVER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportName)
                .HasColumnName("REPORT_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
