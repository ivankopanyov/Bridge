namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofCityledRecords
{
    public string AccountingPeriod { get; set; }
    public decimal? UserId { get; set; }
    public string UserName { get; set; }
    public decimal? ArNumber { get; set; }
    public string AccountNo { get; set; }
    public string AccountName { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string CountryName { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public DateTime? TrxDate { get; set; }
    public string TrxTime { get; set; }
    public decimal? TrxNo { get; set; }
    public string TrxCode { get; set; }
    public decimal? TrxAmount { get; set; }
    public string GuestName { get; set; }
    public string GuestFullName { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public string RefFolioNo { get; set; }
    public string RefFolioNoFormatted { get; set; }
    public decimal? InvoiceNo { get; set; }
    public string AdjustYn { get; set; }
    public string FoStatus { get; set; }
    public string ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string FullName { get; set; }
    public string TravelAgentVoucher { get; set; }
    public string ResvUdfc13 { get; set; }
    public string Room { get; set; }
    public decimal? InvoiceAge { get; set; }
    public decimal? ResvNameId { get; set; }
    public string ConfirmationNo { get; set; }
    public decimal? TotalAmount { get; set; }
    public decimal? CurrencyDifferenceLocal { get; set; }
    public decimal? OrgParallelAmount { get; set; }
    public decimal? OrgContractAmount { get; set; }
    public string ParallelCurrencyCode { get; set; }
    public string ContractCurrencyCode { get; set; }
    public decimal? CurrencyDifferenceParallel { get; set; }
    public decimal? CurrencyDifferenceContract { get; set; }
    public decimal? TotalParallelAmount { get; set; }
    public decimal? TotalContractAmount { get; set; }
    public decimal? AccountNameId { get; set; }
    public string NameUdfc23 { get; set; }
    public string ResvUdfc24 { get; set; }
    public string ExternalReference { get; set; }
    public string ExpOriginalInvoice { get; set; }
    public string ExpInvoiceType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofCityledRecords>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_CITYLED_RECORDS");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.AccountNameId)
                .HasColumnName("ACCOUNT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .IsUnicode(false);

            entity.Property(e => e.AccountingPeriod)
                .HasColumnName("ACCOUNTING_PERIOD")
                .IsUnicode(false);

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AdjustYn)
                .HasColumnName("ADJUST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContractCurrencyCode)
                .HasColumnName("CONTRACT_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryName)
                .HasColumnName("COUNTRY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyDifferenceContract)
                .HasColumnName("CURRENCY_DIFFERENCE_CONTRACT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyDifferenceLocal)
                .HasColumnName("CURRENCY_DIFFERENCE_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyDifferenceParallel)
                .HasColumnName("CURRENCY_DIFFERENCE_PARALLEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpInvoiceType)
                .HasColumnName("EXP_INVOICE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ExpOriginalInvoice)
                .HasColumnName("EXP_ORIGINAL_INVOICE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasColumnName("FAX")
                .IsUnicode(false);

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestFullName)
                .HasColumnName("GUEST_FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceAge)
                .HasColumnName("INVOICE_AGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameUdfc23)
                .HasColumnName("NAME_UDFC23")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OrgContractAmount)
                .HasColumnName("ORG_CONTRACT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrgParallelAmount)
                .HasColumnName("ORG_PARALLEL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParallelCurrencyCode)
                .HasColumnName("PARALLEL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasColumnName("PHONE")
                .IsUnicode(false);

            entity.Property(e => e.RefFolioNo)
                .HasColumnName("REF_FOLIO_NO")
                .IsUnicode(false);

            entity.Property(e => e.RefFolioNoFormatted)
                .HasColumnName("REF_FOLIO_NO_FORMATTED")
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvUdfc13)
                .HasColumnName("RESV_UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResvUdfc24)
                .HasColumnName("RESV_UDFC24")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TotalAmount)
                .HasColumnName("TOTAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalContractAmount)
                .HasColumnName("TOTAL_CONTRACT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalParallelAmount)
                .HasColumnName("TOTAL_PARALLEL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentVoucher)
                .HasColumnName("TRAVEL_AGENT_VOUCHER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxTime)
                .HasColumnName("TRX_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Zip)
                .HasColumnName("ZIP")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
