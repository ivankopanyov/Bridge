namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class StageProfileVw
{
    public string? Resort { get; set; }
    public string? ResortNameId { get; set; }
    public string? NameType { get; set; }
    public string? NameId { get; set; }
    public string? NameCode { get; set; }
    public string? Prefix { get; set; }
    public string? Last { get; set; }
    public string? First { get; set; }
    public string? Title { get; set; }
    public string? Nameordered { get; set; }
    public string? Company { get; set; }
    public string? LastUl { get; set; }
    public string? FirstUl { get; set; }
    public string? CompanyUl { get; set; }
    public string? GenderMf { get; set; }
    public string? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Commissionplancode { get; set; }
    public string? PassportNo { get; set; }
    public string? Nationality { get; set; }
    public DateTime? Birthday { get; set; }
    public string? PrimaryLanguage { get; set; }
    public string? Alternatelanguageids { get; set; }
    public string? VipStatus { get; set; }
    public string? Blacklist { get; set; }
    public string? BlkListMessage { get; set; }
    public string? Occupation { get; set; }
    public string? ContactLast { get; set; }
    public string? ContactFirst { get; set; }
    public string? StageStatus { get; set; }
    public string? StageErrorDesc { get; set; }
    public string? StageSuspenseReason { get; set; }
    public DateTime? ImportDate { get; set; }
    public string? GuestPrivYn { get; set; }
    public string? EmailYn { get; set; }
    public string? MailYn { get; set; }
    public string? CommissionCurrencyCode { get; set; }
    public string? Firma { get; set; }
    public string? FirmaUl { get; set; }
    public string? Region { get; set; }
    public string? ResortCountry { get; set; }
    public string? ResortComment { get; set; }
    public string? Xlast { get; set; }
    public string? Xfirst { get; set; }
    public string? Xcompany { get; set; }
    public string? PhoneYn { get; set; }
    public decimal? TitleSuffix { get; set; }
    public string? Actioncode { get; set; }
    public string? Priority { get; set; }
    public string? RoomsPotential { get; set; }
    public string? Scope { get; set; }
    public string? ScopeCity { get; set; }
    public string? Accountsource { get; set; }
    public string? IndustryCode { get; set; }
    public string? CompetitionCode { get; set; }
    public string? Influence { get; set; }
    public string? AccountType { get; set; }
    public string? Markets { get; set; }
    public string? Territory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("STAGE_PROFILE_VW");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Accountsource)
                .HasColumnName("ACCOUNTSOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Actioncode)
                .HasColumnName("ACTIONCODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Alternatelanguageids)
                .HasColumnName("ALTERNATELANGUAGEIDS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Birthday)
                .HasColumnName("BIRTHDAY")
                .HasColumnType("DATE");

            entity.Property(e => e.Blacklist)
                .HasColumnName("BLACKLIST")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BlkListMessage)
                .HasColumnName("BLK_LIST_MESSAGE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CommissionCurrencyCode)
                .HasColumnName("COMMISSION_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Commissionplancode)
                .HasColumnName("COMMISSIONPLANCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CompanyUl)
                .HasColumnName("COMPANY_UL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CompetitionCode)
                .HasColumnName("COMPETITION_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ContactFirst)
                .HasColumnName("CONTACT_FIRST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ContactLast)
                .HasColumnName("CONTACT_LAST")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EmailYn)
                .HasColumnName("EMAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Firma)
                .HasColumnName("FIRMA")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FirmaUl)
                .HasColumnName("FIRMA_UL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FirstUl)
                .HasColumnName("FIRST_UL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GenderMf)
                .HasColumnName("GENDER_MF")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestPrivYn)
                .HasColumnName("GUEST_PRIV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IndustryCode)
                .HasColumnName("INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Influence)
                .HasColumnName("INFLUENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LastUl)
                .HasColumnName("LAST_UL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MailYn)
                .HasColumnName("MAIL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Markets)
                .HasColumnName("MARKETS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.NameCode)
                .HasColumnName("NAME_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nameordered)
                .HasColumnName("NAMEORDERED")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Occupation)
                .HasColumnName("OCCUPATION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PassportNo)
                .HasColumnName("PASSPORT_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PhoneYn)
                .HasColumnName("PHONE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Prefix)
                .HasColumnName("PREFIX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryLanguage)
                .HasColumnName("PRIMARY_LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortComment)
                .HasColumnName("RESORT_COMMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResortCountry)
                .HasColumnName("RESORT_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsPotential)
                .HasColumnName("ROOMS_POTENTIAL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Scope)
                .HasColumnName("SCOPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ScopeCity)
                .HasColumnName("SCOPE_CITY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StageErrorDesc)
                .HasColumnName("STAGE_ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StageStatus)
                .HasColumnName("STAGE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StageSuspenseReason)
                .HasColumnName("STAGE_SUSPENSE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Territory)
                .HasColumnName("TERRITORY")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TitleSuffix)
                .HasColumnName("TITLE_SUFFIX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Xcompany)
                .HasColumnName("XCOMPANY")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Xfirst)
                .HasColumnName("XFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Xlast)
                .HasColumnName("XLAST")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
