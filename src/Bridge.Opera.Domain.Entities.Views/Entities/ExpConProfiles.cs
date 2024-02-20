namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConProfiles
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? LastRate { get; set; }
    public string? NameType { get; set; }
    public string? Name { get; set; }
    public string? First { get; set; }
    public string? Middle { get; set; }
    public string? Title { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? StateDesc { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? Nationality { get; set; }
    public string? NationalityDesc { get; set; }
    public string? MailList { get; set; }
    public string? MarketResearchYn { get; set; }
    public string? AutoenrollYn { get; set; }
    public string? ThirdPartyYn { get; set; }
    public string? PrivacySet { get; set; }
    public string? VipStatus { get; set; }
    public string? LastRoom { get; set; }
    public string? LastRateCode { get; set; }
    public string? ArNo { get; set; }
    public string? MembershipNumber { get; set; }
    public string? Active01 { get; set; }
    public string? UpdateUserName { get; set; }
    public string? ContactYn { get; set; }
    public string? IataCorpNo { get; set; }
    public string? IncludeInGuestYn { get; set; }
    public string? IncludeInBlockYn { get; set; }
    public string? IncludeInAgentYn { get; set; }
    public string? AccountType { get; set; }
    public string? LastTaDatePopulatedYn { get; set; }
    public string? TaChkDigit { get; set; }
    public string? Tax1No { get; set; }
    public string? CommissionCode { get; set; }
    public string? Commissionable01 { get; set; }
    public string? Xname { get; set; }
    public string? XfirstName { get; set; }
    public string? Xlanguage { get; set; }
    public string? Xtitle { get; set; }
    public string? Xsalutation { get; set; }
    public string? XenvelopeGreeting { get; set; }
    public string? Passport { get; set; }
    public string? SocialMediaId { get; set; }
    public string? InternationalId { get; set; }
    public string? PassportId { get; set; }
    public string? ResvNameIdList { get; set; }
    public string? VipName { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? BirthDate { get; set; }
    public DateTime? LastStay { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? UploadDate { get; set; }
    public DateTime? LastTaDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConProfiles>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_PROFILES");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Active01)
                .HasColumnName("ACTIVE_01")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArNo)
                .HasColumnName("AR_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AutoenrollYn)
                .HasColumnName("AUTOENROLL_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Commissionable01)
                .HasColumnName("COMMISSIONABLE_01")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactYn)
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IncludeInAgentYn)
                .HasColumnName("INCLUDE_IN_AGENT_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IncludeInBlockYn)
                .HasColumnName("INCLUDE_IN_BLOCK_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.IncludeInGuestYn)
                .HasColumnName("INCLUDE_IN_GUEST_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InternationalId)
                .HasColumnName("INTERNATIONAL_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.LastRate)
                .HasColumnName("LAST_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastRateCode)
                .HasColumnName("LAST_RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastRoom)
                .HasColumnName("LAST_ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastStay)
                .HasColumnName("LAST_STAY")
                .HasColumnType("DATE");

            entity.Property(e => e.LastTaDate)
                .HasColumnName("LAST_TA_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastTaDatePopulatedYn)
                .HasColumnName("LAST_TA_DATE_POPULATED_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MailList)
                .HasColumnName("MAIL_LIST")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketResearchYn)
                .HasColumnName("MARKET_RESEARCH_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipNumber)
                .HasColumnName("MEMBERSHIP_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NationalityDesc)
                .HasColumnName("NATIONALITY_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PassportId)
                .HasColumnName("PASSPORT_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PrivacySet)
                .HasColumnName("PRIVACY_SET")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameIdList)
                .HasColumnName("RESV_NAME_ID_LIST")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SocialMediaId)
                .HasColumnName("SOCIAL_MEDIA_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StateDesc)
                .HasColumnName("STATE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaChkDigit)
                .HasColumnName("TA_CHK_DIGIT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Tax1No)
                .HasColumnName("TAX1_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ThirdPartyYn)
                .HasColumnName("THIRD_PARTY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUserName)
                .HasColumnName("UPDATE_USER_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VipName)
                .HasColumnName("VIP_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.XenvelopeGreeting)
                .HasColumnName("XENVELOPE_GREETING")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Xlanguage)
                .HasColumnName("XLANGUAGE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Xname)
                .HasColumnName("XNAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Xsalutation)
                .HasColumnName("XSALUTATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Xtitle)
                .HasColumnName("XTITLE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
