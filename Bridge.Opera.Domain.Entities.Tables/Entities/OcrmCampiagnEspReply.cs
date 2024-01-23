namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OcrmCampiagnEspReply
{
    public decimal ReplyRecId { get; set; }
    public decimal? CampaignId { get; set; }
    public decimal? SegBatchId { get; set; }
    public decimal? OcrmProfileId { get; set; }
    public string RecordLocator { get; set; }
    public string MailListFlg { get; set; }
    public string MarketResearchFlg { get; set; }
    public string ThirdPartyFlg { get; set; }
    public string AutoenrollMemberFlg { get; set; }
    public string EmailFlg { get; set; }
    public string GuestPrivFlg { get; set; }
    public string PhoneFlg { get; set; }
    public string SmsFlg { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OcrmCampiagnEspReply>(entity =>
        {
            entity.HasKey(e => e.ReplyRecId)
                .HasName("OCRM_CAMPIAGN_ESP_REPLY_PK");

            entity.ToTable("OCRM_CAMPIAGN_ESP_REPLY");

            entity.Property(e => e.ReplyRecId)
                .HasColumnName("REPLY_REC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoenrollMemberFlg)
                .HasColumnName("AUTOENROLL_MEMBER_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CampaignId)
                .HasColumnName("CAMPAIGN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmailFlg)
                .HasColumnName("EMAIL_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivFlg)
                .HasColumnName("GUEST_PRIV_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MailListFlg)
                .HasColumnName("MAIL_LIST_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MarketResearchFlg)
                .HasColumnName("MARKET_RESEARCH_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OcrmProfileId)
                .HasColumnName("OCRM_PROFILE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneFlg)
                .HasColumnName("PHONE_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RecordLocator)
                .HasColumnName("RECORD_LOCATOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SegBatchId)
                .HasColumnName("SEG_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SmsFlg)
                .HasColumnName("SMS_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ThirdPartyFlg)
                .HasColumnName("THIRD_PARTY_FLG")
                .HasMaxLength(1)
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
