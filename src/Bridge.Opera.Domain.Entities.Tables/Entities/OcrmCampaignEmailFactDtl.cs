namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmCampaignEmailFactDtl
{
    public decimal? FactDtlRecId { get; set; }
    public string? RecordLocator { get; set; }
    public decimal? CampaignId { get; set; }
    public string? OcrmEventtype { get; set; }
    public string? OcrmBouncetype { get; set; }
    public decimal? OcrmProfileId { get; set; }
    public string? InterfaceId { get; set; }
    public string? Resort { get; set; }
    public string? ExternalResortId { get; set; }
    public DateTime? Eventdate { get; set; }
    public DateTime? ImportDate { get; set; }
    public decimal? ImportBatchId { get; set; }
    public decimal? ProcessBatchId { get; set; }
    public string? EspEventtype { get; set; }
    public decimal? EspEventcount { get; set; }
    public string? EspBouncecategory { get; set; }
    public string? Url { get; set; }
    public string? UrlAlias { get; set; }
    public string? EspRefNo { get; set; }
    public string? EspRefRecNo { get; set; }
    public DateTime? EspSchedtime { get; set; }
    public string? EspJobstatus { get; set; }
    public string? Emailaddress { get; set; }
    public string? Emailname { get; set; }
    public string? Fromname { get; set; }
    public string? Fromemail { get; set; }
    public string? EmailSubject { get; set; }
    public string? EmailPreviewurl { get; set; }
    public string? Espbatchid { get; set; }
    public string? Sendurlid { get; set; }
    public string? CampaignCode { get; set; }
    public decimal? SegBatchId { get; set; }
    public string? MailListFlg { get; set; }
    public string? MarketResearchFlg { get; set; }
    public string? ThirdPartyFlg { get; set; }
    public string? AutoenrollMemberFlg { get; set; }
    public string? EmailFlg { get; set; }
    public string? GuestPrivFlg { get; set; }
    public string? PhoneFlg { get; set; }
    public string? SmsFlg { get; set; }
    public string? Urlid { get; set; }
    public string? Udfc01 { get; set; }
    public string? Udfc02 { get; set; }
    public string? Udfc03 { get; set; }
    public string? Udfc04 { get; set; }
    public string? Udfc05 { get; set; }
    public string? Udfc06 { get; set; }
    public string? Udfc07 { get; set; }
    public string? Udfc08 { get; set; }
    public string? Udfc09 { get; set; }
    public string? Udfc10 { get; set; }
    public string? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public decimal? Udfn03 { get; set; }
    public decimal? Udfn04 { get; set; }
    public decimal? Udfn05 { get; set; }
    public string? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public DateTime? Udfd03 { get; set; }
    public DateTime? Udfd04 { get; set; }
    public DateTime? Udfd05 { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCampaignEmailFactDtl>(entity =>
        {
            entity.HasKey(e => e.FactDtlRecId)
                .HasName("OCEFD_PK");

            entity.ToTable("OCRM_CAMPAIGN_EMAIL_FACT_DTL");

            entity.HasIndex(e => e.ImportBatchId)
                .HasName("CAMP_FACT_DTL_IDX1");

            entity.HasIndex(e => e.ProcessBatchId)
                .HasName("CAMP_FACT_DTL_IDX2");

            entity.Property(e => e.FactDtlRecId)
                .HasColumnName("FACT_DTL_REC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoenrollMemberFlg)
                .HasColumnName("AUTOENROLL_MEMBER_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CampaignCode)
                .HasColumnName("CAMPAIGN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailFlg)
                .HasColumnName("EMAIL_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailPreviewurl)
                .HasColumnName("EMAIL_PREVIEWURL")
                .IsUnicode(false);

            entity.Property(e => e.EmailSubject)
                .HasColumnName("EMAIL_SUBJECT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Emailaddress)
                .HasColumnName("EMAILADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.Emailname)
                .HasColumnName("EMAILNAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EspBouncecategory)
                .HasColumnName("ESP_BOUNCECATEGORY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EspEventcount)
                .HasColumnName("ESP_EVENTCOUNT")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"1");

            entity.Property(e => e.EspEventtype)
                .HasColumnName("ESP_EVENTTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EspJobstatus)
                .HasColumnName("ESP_JOBSTATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EspRefNo)
                .HasColumnName("ESP_REF_NO")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EspRefRecNo)
                .HasColumnName("ESP_REF_REC_NO")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EspSchedtime)
                .HasColumnName("ESP_SCHEDTIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Espbatchid)
                .HasColumnName("ESPBATCHID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Eventdate)
                .HasColumnName("EVENTDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExternalResortId)
                .HasColumnName("EXTERNAL_RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Fromemail)
                .HasColumnName("FROMEMAIL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Fromname)
                .HasColumnName("FROMNAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivFlg)
                .HasColumnName("GUEST_PRIV_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ImportBatchId)
                .HasColumnName("IMPORT_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MailListFlg)
                .HasColumnName("MAIL_LIST_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MarketResearchFlg)
                .HasColumnName("MARKET_RESEARCH_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OcrmBouncetype)
                .HasColumnName("OCRM_BOUNCETYPE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OcrmEventtype)
                .HasColumnName("OCRM_EVENTTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OcrmProfileId)
                .HasColumnName("OCRM_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneFlg)
                .HasColumnName("PHONE_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProcessBatchId)
                .HasColumnName("PROCESS_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordLocator)
                .HasColumnName("RECORD_LOCATOR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SegBatchId)
                .HasColumnName("SEG_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sendurlid)
                .HasColumnName("SENDURLID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SmsFlg)
                .HasColumnName("SMS_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ThirdPartyFlg)
                .HasColumnName("THIRD_PARTY_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .IsUnicode(false);

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd03)
                .HasColumnName("UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd04)
                .HasColumnName("UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd05)
                .HasColumnName("UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn03)
                .HasColumnName("UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn04)
                .HasColumnName("UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn05)
                .HasColumnName("UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Url)
                .HasColumnName("URL")
                .IsUnicode(false);

            entity.Property(e => e.UrlAlias)
                .HasColumnName("URL_ALIAS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Urlid)
                .HasColumnName("URLID")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
