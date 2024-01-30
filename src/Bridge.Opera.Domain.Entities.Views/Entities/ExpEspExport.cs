namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEspExport
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? RecordType { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? Last { get; set; }
    public string? First { get; set; }
    public string? Title { get; set; }
    public string? Haddress1 { get; set; }
    public string? Haddress2 { get; set; }
    public string? Haddress3 { get; set; }
    public string? Hcity { get; set; }
    public string? Hcountry { get; set; }
    public string? Hstate { get; set; }
    public string? Hzip { get; set; }
    public string? Baddress1 { get; set; }
    public string? Baddress2 { get; set; }
    public string? Baddress3 { get; set; }
    public string? Bcity { get; set; }
    public string? Bcountry { get; set; }
    public string? Bstate { get; set; }
    public string? Bzip { get; set; }
    public string? Middle { get; set; }
    public string? Suffix { get; set; }
    public string? Gender { get; set; }
    public string? ThirdPartyYn { get; set; }
    public string? Company { get; set; }
    public string? BusinessTitle { get; set; }
    public string? FfNo { get; set; }
    public string? FfCode { get; set; }
    public string? AddressType { get; set; }
    public string? HomeNo { get; set; }
    public string? BusinessNo { get; set; }
    public string? BusinessExt { get; set; }
    public string? Email { get; set; }
    public string? EmailFormat { get; set; }
    public string? AltEmail { get; set; }
    public string? AltEmailFormat { get; set; }
    public string? CcTypePrimary { get; set; }
    public string? CcNumberPrimary { get; set; }
    public DateTime? CcExpDatePrimary { get; set; }
    public string? CcPrefPrimary { get; set; }
    public string? Language { get; set; }
    public string? SponsorId { get; set; }
    public string? BedType { get; set; }
    public string? PrefPriority { get; set; }
    public string? SmkPref { get; set; }
    public string? AccPref { get; set; }
    public string? FloorPref { get; set; }
    public string? PillowPref { get; set; }
    public string? TowelPref { get; set; }
    public decimal? Bnights { get; set; }
    public decimal? Lnights { get; set; }
    public string? EmailReceive { get; set; }
    public string? AltEmailReceive { get; set; }
    public string? EarningPref { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public decimal? TotRev { get; set; }
    public decimal? TotalNights { get; set; }
    public string? PropCurrCode { get; set; }
    public decimal? PropDec { get; set; }
    public string? RateCode { get; set; }
    public string? BonusCodes { get; set; }
    public string? CertificateNumbers { get; set; }
    public string? PaymentCcType { get; set; }
    public string? PaymentCcNumber { get; set; }
    public DateTime? PaymentCcExpyDate { get; set; }
    public string? ResvEarningPref { get; set; }
    public DateTime? ResvInsertDate { get; set; }
    public decimal? RevenueBkt1 { get; set; }
    public decimal? RevenueBkt2 { get; set; }
    public decimal? RevenueBkt3 { get; set; }
    public decimal? RevenueBkt4 { get; set; }
    public decimal? RevenueBkt5 { get; set; }
    public decimal? RevenueBkt6 { get; set; }
    public decimal? RevenueBkt7 { get; set; }
    public decimal? RevenueBkt8 { get; set; }
    public decimal? RevenueBkt9 { get; set; }
    public decimal? RevenueBkt10 { get; set; }
    public string? PrefAddress { get; set; }
    public string? HostMultFlag { get; set; }
    public string? MembershipCardNo { get; set; }
    public string? FoamPillowPref { get; set; }
    public string? MembershipType { get; set; }
    public decimal? NameId { get; set; }
    public string? Phones { get; set; }
    public decimal? EnrollmentSequence { get; set; }
    public decimal? UpdateSequence { get; set; }
    public decimal? StaySequence { get; set; }
    public string? BprimaryYn { get; set; }
    public string? HprimaryYn { get; set; }
    public string? H { get; set; }
    public string? B { get; set; }
    public string? CcTypeSec { get; set; }
    public string? CcNumberSec { get; set; }
    public DateTime? CcExpDateSec { get; set; }
    public string? CcPrefSec { get; set; }
    public string? PrefExist { get; set; }
    public string? MemCurrCode { get; set; }
    public string? MemExchType { get; set; }
    public string? EmailDeletedYn { get; set; }
    public string? AltEmailDeletedYn { get; set; }
    public string? BusinessPhoneDeletedYn { get; set; }
    public string? FaxDeletedYn { get; set; }
    public string? HomePhoneDeletedYn { get; set; }
    public string? MobilePhoneDeletedYn { get; set; }
    public string? OperaConfNo { get; set; }
    public string? RevenueReqdYn { get; set; }
    public string? Cardinality { get; set; }
    public string? Instance { get; set; }
    public string? OverflowCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEspExport>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ESP_EXPORT");

            entity.Property(e => e.AccPref)
                .HasColumnName("ACC_PREF")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AddressType)
                .HasColumnName("ADDRESS_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AltEmail)
                .HasColumnName("ALT_EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AltEmailDeletedYn)
                .HasColumnName("ALT_EMAIL_DELETED_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AltEmailFormat)
                .HasColumnName("ALT_EMAIL_FORMAT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AltEmailReceive)
                .HasColumnName("ALT_EMAIL_RECEIVE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.B)
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Baddress1)
                .HasColumnName("BADDRESS_1")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Baddress2)
                .HasColumnName("BADDRESS_2")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Baddress3)
                .HasColumnName("BADDRESS_3")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bcity)
                .HasColumnName("BCITY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bcountry)
                .HasColumnName("BCOUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BedType)
                .HasColumnName("BED_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bnights)
                .HasColumnName("BNIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BonusCodes)
                .HasColumnName("BONUS_CODES")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BprimaryYn)
                .HasColumnName("BPRIMARY_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bstate)
                .HasColumnName("BSTATE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessExt)
                .HasColumnName("BUSINESS_EXT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessNo)
                .HasColumnName("BUSINESS_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessPhoneDeletedYn)
                .HasColumnName("BUSINESS_PHONE_DELETED_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Bzip)
                .HasColumnName("BZIP")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cardinality)
                .HasColumnName("CARDINALITY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcExpDatePrimary)
                .HasColumnName("CC_EXP_DATE_PRIMARY")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcExpDateSec)
                .HasColumnName("CC_EXP_DATE_SEC")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcNumberPrimary)
                .HasColumnName("CC_NUMBER_PRIMARY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcNumberSec)
                .HasColumnName("CC_NUMBER_SEC")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcPrefPrimary)
                .HasColumnName("CC_PREF_PRIMARY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcPrefSec)
                .HasColumnName("CC_PREF_SEC")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcTypePrimary)
                .HasColumnName("CC_TYPE_PRIMARY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CcTypeSec)
                .HasColumnName("CC_TYPE_SEC")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CertificateNumbers)
                .HasColumnName("CERTIFICATE_NUMBERS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EarningPref)
                .HasColumnName("EARNING_PREF")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailDeletedYn)
                .HasColumnName("EMAIL_DELETED_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailFormat)
                .HasColumnName("EMAIL_FORMAT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmailReceive)
                .HasColumnName("EMAIL_RECEIVE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EnrollmentSequence)
                .HasColumnName("ENROLLMENT_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FaxDeletedYn)
                .HasColumnName("FAX_DELETED_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FfCode)
                .HasColumnName("FF_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FfNo)
                .HasColumnName("FF_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FloorPref)
                .HasColumnName("FLOOR_PREF")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FoamPillowPref)
                .HasColumnName("FOAM_PILLOW_PREF")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Gender)
                .HasColumnName("GENDER")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.H)
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Haddress1)
                .HasColumnName("HADDRESS_1")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Haddress2)
                .HasColumnName("HADDRESS_2")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Haddress3)
                .HasColumnName("HADDRESS_3")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Hcity)
                .HasColumnName("HCITY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Hcountry)
                .HasColumnName("HCOUNTRY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HomeNo)
                .HasColumnName("HOME_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HomePhoneDeletedYn)
                .HasColumnName("HOME_PHONE_DELETED_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HostMultFlag)
                .HasColumnName("HOST_MULT_FLAG")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.HprimaryYn)
                .HasColumnName("HPRIMARY_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Hstate)
                .HasColumnName("HSTATE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Hzip)
                .HasColumnName("HZIP")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Instance)
                .HasColumnName("INSTANCE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Lnights)
                .HasColumnName("LNIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemCurrCode)
                .HasColumnName("MEM_CURR_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MemExchType)
                .HasColumnName("MEM_EXCH_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MobilePhoneDeletedYn)
                .HasColumnName("MOBILE_PHONE_DELETED_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OperaConfNo)
                .HasColumnName("OPERA_CONF_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverflowCode)
                .HasColumnName("OVERFLOW_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentCcExpyDate)
                .HasColumnName("PAYMENT_CC_EXPY_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentCcNumber)
                .HasColumnName("PAYMENT_CC_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentCcType)
                .HasColumnName("PAYMENT_CC_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Phones)
                .HasColumnName("PHONES")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PillowPref)
                .HasColumnName("PILLOW_PREF")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrefAddress)
                .HasColumnName("PREF_ADDRESS")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrefExist)
                .HasColumnName("PREF_EXIST")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrefPriority)
                .HasColumnName("PREF_PRIORITY")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PropCurrCode)
                .HasColumnName("PROP_CURR_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PropDec)
                .HasColumnName("PROP_DEC")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvEarningPref)
                .HasColumnName("RESV_EARNING_PREF")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvInsertDate)
                .HasColumnName("RESV_INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt1)
                .HasColumnName("REVENUE_BKT_1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt10)
                .HasColumnName("REVENUE_BKT_10")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt2)
                .HasColumnName("REVENUE_BKT_2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt3)
                .HasColumnName("REVENUE_BKT_3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt4)
                .HasColumnName("REVENUE_BKT_4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt5)
                .HasColumnName("REVENUE_BKT_5")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt6)
                .HasColumnName("REVENUE_BKT_6")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt7)
                .HasColumnName("REVENUE_BKT_7")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt8)
                .HasColumnName("REVENUE_BKT_8")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueBkt9)
                .HasColumnName("REVENUE_BKT_9")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueReqdYn)
                .HasColumnName("REVENUE_REQD_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SmkPref)
                .HasColumnName("SMK_PREF")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SponsorId)
                .HasColumnName("SPONSOR_ID")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StaySequence)
                .HasColumnName("STAY_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Suffix)
                .HasColumnName("SUFFIX")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ThirdPartyYn)
                .HasColumnName("THIRD_PARTY_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotRev)
                .HasColumnName("TOT_REV")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TotalNights)
                .HasColumnName("TOTAL_NIGHTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TowelPref)
                .HasColumnName("TOWEL_PREF")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateSequence)
                .HasColumnName("UPDATE_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
