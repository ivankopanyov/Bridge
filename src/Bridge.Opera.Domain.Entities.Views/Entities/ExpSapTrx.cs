namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSapTrx
{
    public string? Resort { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? FromResvId { get; set; }
    public string? Room { get; set; }
    public string? FromRoom { get; set; }
    public decimal? ArNumber { get; set; }
    public decimal? NameId { get; set; }
    public string? TrxCode { get; set; }
    public string? TcSubgroup { get; set; }
    public string? TcGroup { get; set; }
    public decimal? Amount { get; set; }
    public decimal? RevenueAmount { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? NonRevenueAmount { get; set; }
    public decimal? GuestDebit { get; set; }
    public decimal? GuestCredit { get; set; }
    public decimal? PackageCredit { get; set; }
    public decimal? PackageDebit { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? InsertUser { get; set; }
    public string? InsertUserEmpnumber { get; set; }
    public string? InsertUserName { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? CheckNo { get; set; }
    public string? Covers { get; set; }
    public string? TrxCodeType { get; set; }
    public string? RateCode { get; set; }
    public string? MarketCode { get; set; }
    public string? Duration { get; set; }
    public string? NumberDialed { get; set; }
    public decimal? ArCredit { get; set; }
    public decimal? ArDebit { get; set; }
    public decimal? DepositCredit { get; set; }
    public decimal? DepositDebit { get; set; }
    public string? Reference { get; set; }
    public string? Remark { get; set; }
    public string? Ledger { get; set; }
    public string? LedgerDebit { get; set; }
    public string? IsInternalYn { get; set; }
    public decimal? InternalDbPayments { get; set; }
    public string? PmsVersion { get; set; }
    public decimal? AccountNo { get; set; }
    public decimal? TotalTrx { get; set; }
    public string? GuestName { get; set; }
    public string? CurrencyCode { get; set; }
    public string? CompFlag { get; set; }
    public string? OoDescription { get; set; }
    public string? HotelCode { get; set; }
    public string? ArAccountNumber { get; set; }
    public decimal? Arrivals { get; set; }
    public decimal? Departures { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public decimal? BillNo { get; set; }
    public string? RoomClass { get; set; }
    public string? SourceCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSapTrx>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SAP_TRX");

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArAccountNumber)
                .HasColumnName("AR_ACCOUNT_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArCredit)
                .HasColumnName("AR_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArDebit)
                .HasColumnName("AR_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.Arrivals)
                .HasColumnName("ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckNo)
                .HasColumnName("CHECK_NO")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompFlag)
                .HasColumnName("COMP_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Covers)
                .HasColumnName("COVERS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.Departures)
                .HasColumnName("DEPARTURES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositCredit)
                .HasColumnName("DEPOSIT_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositDebit)
                .HasColumnName("DEPOSIT_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
                .IsUnicode(false);

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromRoom)
                .HasColumnName("FROM_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestCredit)
                .HasColumnName("GUEST_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestDebit)
                .HasColumnName("GUEST_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertUserEmpnumber)
                .HasColumnName("INSERT_USER_EMPNUMBER")
                .IsUnicode(false);

            entity.Property(e => e.InsertUserName)
                .HasColumnName("INSERT_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InternalDbPayments)
                .HasColumnName("INTERNAL_DB_PAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsInternalYn)
                .HasColumnName("IS_INTERNAL_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Ledger)
                .HasColumnName("LEDGER")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.LedgerDebit)
                .HasColumnName("LEDGER_DEBIT")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenueAmount)
                .HasColumnName("NON_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberDialed)
                .HasColumnName("NUMBER_DIALED")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OoDescription)
                .HasColumnName("OO_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PackageCredit)
                .HasColumnName("PACKAGE_CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageDebit)
                .HasColumnName("PACKAGE_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsVersion)
                .HasColumnName("PMS_VERSION")
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Reference)
                .HasColumnName("REFERENCE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remark)
                .HasColumnName("REMARK")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueAmount)
                .HasColumnName("REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalTrx)
                .HasColumnName("TOTAL_TRX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxAmount)
                .HasColumnName("TRX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeType)
                .HasColumnName("TRX_CODE_TYPE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAddedBy)
                .HasColumnName("TRX_NO_ADDED_BY")
                .HasColumnType("NUMBER");
        });
	}
}
