namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaCheckPrintView1
{
    public string Resort { get; set; }
    public decimal? BatchId { get; set; }
    public decimal? CheckNo { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string Name { get; set; }
    public string AddresseeAddress1 { get; set; }
    public string AddresseeAddress2 { get; set; }
    public string IataCorpNo { get; set; }
    public string ArrivalDate { get; set; }
    public string DepartureDate { get; set; }
    public decimal? Nights { get; set; }
    public string GuestName { get; set; }
    public decimal? CommissionableRevenue { get; set; }
    public decimal? Commission { get; set; }
    public decimal? PrepaidComm { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? VatAmount { get; set; }
    public decimal? GrossComm { get; set; }
    public decimal? CheckAmount { get; set; }
    public decimal? TotalCheckAmt { get; set; }
    public DateTime? CheckDate { get; set; }
    public decimal? PaymentId { get; set; }
    public string CommissionCode { get; set; }
    public string ReservationStatus { get; set; }
    public string AddresseeCity { get; set; }
    public string AddresseeState { get; set; }
    public string AddresseeZipCode { get; set; }
    public string AddresseeCountry { get; set; }
    public decimal? RoomRate { get; set; }
    public string FolioNo { get; set; }
    public string Currency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string AccountNo { get; set; }
    public string Xname { get; set; }
    public string XguestName { get; set; }
    public string AddresseeStateDescription { get; set; }
    public decimal? FcTotalCheckAmt { get; set; }
    public string FormattedAddress { get; set; }
    public string TaRecordLocator { get; set; }
    public decimal? CheckStubLines { get; set; }
    public string BeginDate { get; set; }
    public string EndDate { get; set; }
    public decimal? CommissionId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaCheckPrintView1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TA_CHECK_PRINT_VIEW1");

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AddresseeAddress1)
                .HasColumnName("ADDRESSEE_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AddresseeAddress2)
                .HasColumnName("ADDRESSEE_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AddresseeCity)
                .HasColumnName("ADDRESSEE_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AddresseeCountry)
                .HasColumnName("ADDRESSEE_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.AddresseeState)
                .HasColumnName("ADDRESSEE_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AddresseeStateDescription)
                .HasColumnName("ADDRESSEE_STATE_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.AddresseeZipCode)
                .HasColumnName("ADDRESSEE_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.CheckAmount)
                .HasColumnName("CHECK_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckDate)
                .HasColumnName("CHECK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckNo)
                .HasColumnName("CHECK_NO")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.CheckStubLines)
                .HasColumnName("CHECK_STUB_LINES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CommissionId)
                .HasColumnName("COMMISSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionableRevenue)
                .HasColumnName("COMMISSIONABLE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FcTotalCheckAmt)
                .HasColumnName("FC_TOTAL_CHECK_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .IsUnicode(false);

            entity.Property(e => e.FormattedAddress)
                .HasColumnName("FORMATTED_ADDRESS")
                .IsUnicode(false);

            entity.Property(e => e.GrossComm)
                .HasColumnName("GROSS_COMM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentId)
                .HasColumnName("PAYMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrepaidComm)
                .HasColumnName("PREPAID_COMM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationStatus)
                .HasColumnName("RESERVATION_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRate)
                .HasColumnName("ROOM_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaRecordLocator)
                .HasColumnName("TA_RECORD_LOCATOR")
                .IsUnicode(false);

            entity.Property(e => e.TotalCheckAmt)
                .HasColumnName("TOTAL_CHECK_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VatAmount)
                .HasColumnName("VAT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.XguestName)
                .HasColumnName("XGUEST_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.Xname)
                .HasColumnName("XNAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
