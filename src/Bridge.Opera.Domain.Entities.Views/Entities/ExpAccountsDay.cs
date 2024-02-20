namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpAccountsDay
{
    public string? RecordType { get; set; }
    public string? SourceSystem { get; set; }
    public string? PropertyCode { get; set; }
    public string? TransactionType { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Keyword { get; set; }
    public string? ActiveYn { get; set; }
    public string? AccAddress1 { get; set; }
    public string? AccAddress2 { get; set; }
    public string? AccAddress3 { get; set; }
    public string? AccAddress4 { get; set; }
    public string? AccCity { get; set; }
    public string? AccState { get; set; }
    public string? AccZipCode { get; set; }
    public string? AccRegionCode { get; set; }
    public string? AccCountry { get; set; }
    public string? AccPhoneNo { get; set; }
    public string? AccPhoneExt { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? MasterId { get; set; }
    public string? AccPrimaryFax { get; set; }
    public string? IataCompType { get; set; }
    public string? IataCorpNo { get; set; }
    public string? NameType { get; set; }
    public string? Udfc05 { get; set; }
    public string? Udfc01 { get; set; }
    public string? IndustryCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDateTime { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDateTime { get; set; }
    public string? Udfc02Desc { get; set; }
    public string? Udfc02Code { get; set; }
    public string? Udfc06 { get; set; }
    public string? ProfileId { get; set; }
    public string? AccName { get; set; }
    public string? AccName2 { get; set; }
    public string? AccName3 { get; set; }
    public string? AddressType { get; set; }
    public string? AccPrimaryWeb { get; set; }
    public string? BusSegment { get; set; }
    public string? AccountType { get; set; }
    public string? AccountSource { get; set; }
    public string? CompetitionCode { get; set; }
    public string? CompetitionDesc { get; set; }
    public decimal? ParentId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpAccountsDay>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ACCOUNTS_DAY");

            entity.Property(e => e.AccAddress1)
                .HasColumnName("ACC_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress2)
                .HasColumnName("ACC_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress3)
                .HasColumnName("ACC_ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccAddress4)
                .HasColumnName("ACC_ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccCity)
                .HasColumnName("ACC_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccCountry)
                .HasColumnName("ACC_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccName)
                .HasColumnName("ACC_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccName2)
                .HasColumnName("ACC_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccName3)
                .HasColumnName("ACC_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AccPhoneExt)
                .HasColumnName("ACC_PHONE_EXT")
                .IsUnicode(false);

            entity.Property(e => e.AccPhoneNo)
                .HasColumnName("ACC_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccPrimaryFax)
                .HasColumnName("ACC_PRIMARY_FAX")
                .IsUnicode(false);

            entity.Property(e => e.AccPrimaryWeb)
                .HasColumnName("ACC_PRIMARY_WEB")
                .IsUnicode(false);

            entity.Property(e => e.AccRegionCode)
                .HasColumnName("ACC_REGION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AccState)
                .HasColumnName("ACC_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AccZipCode)
                .HasColumnName("ACC_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountSource)
                .HasColumnName("ACCOUNT_SOURCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AddressType)
                .HasColumnName("ADDRESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusSegment)
                .HasColumnName("BUS_SEGMENT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CompetitionCode)
                .HasColumnName("COMPETITION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CompetitionDesc)
                .HasColumnName("COMPETITION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.IataCompType)
                .HasColumnName("IATA_COMP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IndustryCode)
                .HasColumnName("INDUSTRY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDateTime)
                .HasColumnName("INSERT_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Keyword)
                .HasColumnName("KEYWORD")
                .IsUnicode(false);

            entity.Property(e => e.MasterId)
                .HasColumnName("MASTER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParentId)
                .HasColumnName("PARENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileId)
                .HasColumnName("PROFILE_ID")
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.TransactionType)
                .HasColumnName("TRANSACTION_TYPE")
                .HasColumnType("CHAR(3)");

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02Code)
                .HasColumnName("UDFC02_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02Desc)
                .HasColumnName("UDFC02_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDateTime)
                .HasColumnName("UPDATE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
