namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpGrDoorbook
{
    public string ExportType { get; set; }
    public decimal? ExportId { get; set; }
    public DateTime? ArrivalDate { get; set; }
    public DateTime? DepartureDate { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string OldValue { get; set; }
    public string NewValue { get; set; }
    public decimal? LastSeqNo { get; set; }
    public decimal? NewSeqNo { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string UpdType { get; set; }
    public string GuestType { get; set; }
    public string CompanyName { get; set; }
    public string AgentName { get; set; }
    public string RoomNum { get; set; }
    public decimal? ResvNameId { get; set; }
    public string Arrangement { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public string Resort { get; set; }
    public DateTime? ActualDepartureDate { get; set; }
    public string CompValue { get; set; }
    public string CurrencyFormat { get; set; }
    public string FolioStatus1 { get; set; }
    public string FolioStatus2 { get; set; }
    public string FolioStatus3 { get; set; }
    public string FolioStatus4 { get; set; }
    public string FolioStatus5 { get; set; }
    public string FolioStatus6 { get; set; }
    public string FolioStatus7 { get; set; }
    public string FolioStatus8 { get; set; }
    public string FolioStatus9 { get; set; }
    public string FolioStatus10 { get; set; }
    public string FolioType1 { get; set; }
    public string FolioType2 { get; set; }
    public string FolioType3 { get; set; }
    public string FolioType4 { get; set; }
    public string FolioType5 { get; set; }
    public string FolioType6 { get; set; }
    public string FolioType7 { get; set; }
    public string FolioType8 { get; set; }
    public string FolioType9 { get; set; }
    public string FolioType10 { get; set; }
    public string UpdTypeDesc { get; set; }
    public string Payee1 { get; set; }
    public string Payee2 { get; set; }
    public string Payee3 { get; set; }
    public string Payee4 { get; set; }
    public string Payee5 { get; set; }
    public string Payee6 { get; set; }
    public string Payee7 { get; set; }
    public string Payee8 { get; set; }
    public string Payee9 { get; set; }
    public string Payee10 { get; set; }
    public string AssociatedBill1 { get; set; }
    public string AssociatedBill2 { get; set; }
    public string AssociatedBill3 { get; set; }
    public string AssociatedBill4 { get; set; }
    public string AssociatedBill5 { get; set; }
    public string AssociatedBill6 { get; set; }
    public string AssociatedBill7 { get; set; }
    public string AssociatedBill8 { get; set; }
    public string AssociatedBill9 { get; set; }
    public string AssociatedBill10 { get; set; }
    public decimal? Bill1 { get; set; }
    public decimal? Bill2 { get; set; }
    public decimal? Bill3 { get; set; }
    public decimal? Bill4 { get; set; }
    public decimal? Bill5 { get; set; }
    public decimal? Bill6 { get; set; }
    public decimal? Bill7 { get; set; }
    public decimal? Bill8 { get; set; }
    public decimal? Bill9 { get; set; }
    public decimal? Bill10 { get; set; }
    public decimal? BillAmount1 { get; set; }
    public decimal? BillAmount2 { get; set; }
    public decimal? BillAmount3 { get; set; }
    public decimal? BillAmount4 { get; set; }
    public decimal? BillAmount5 { get; set; }
    public decimal? BillAmount6 { get; set; }
    public decimal? BillAmount7 { get; set; }
    public decimal? BillAmount8 { get; set; }
    public decimal? BillAmount9 { get; set; }
    public decimal? BillAmount10 { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string GreekContractNumber { get; set; }
    public string PmsDateFormat { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpGrDoorbook>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_GR_DOORBOOK");

            entity.Property(e => e.ActualDepartureDate)
                .HasColumnName("ACTUAL_DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentName)
                .HasColumnName("AGENT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Arrangement)
                .HasColumnName("ARRANGEMENT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AssociatedBill1)
                .HasColumnName("ASSOCIATED_BILL_1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AssociatedBill10)
                .HasColumnName("ASSOCIATED_BILL_10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AssociatedBill2)
                .HasColumnName("ASSOCIATED_BILL_2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AssociatedBill3)
                .HasColumnName("ASSOCIATED_BILL_3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AssociatedBill4)
                .HasColumnName("ASSOCIATED_BILL_4")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AssociatedBill5)
                .HasColumnName("ASSOCIATED_BILL_5")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AssociatedBill6)
                .HasColumnName("ASSOCIATED_BILL_6")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AssociatedBill7)
                .HasColumnName("ASSOCIATED_BILL_7")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AssociatedBill8)
                .HasColumnName("ASSOCIATED_BILL_8")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AssociatedBill9)
                .HasColumnName("ASSOCIATED_BILL_9")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Bill1)
                .HasColumnName("BILL_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bill10)
                .HasColumnName("BILL_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bill2)
                .HasColumnName("BILL_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bill3)
                .HasColumnName("BILL_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bill4)
                .HasColumnName("BILL_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bill5)
                .HasColumnName("BILL_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bill6)
                .HasColumnName("BILL_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bill7)
                .HasColumnName("BILL_7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bill8)
                .HasColumnName("BILL_8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bill9)
                .HasColumnName("BILL_9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount1)
                .HasColumnName("BILL_AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount10)
                .HasColumnName("BILL_AMOUNT_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount2)
                .HasColumnName("BILL_AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount3)
                .HasColumnName("BILL_AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount4)
                .HasColumnName("BILL_AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount5)
                .HasColumnName("BILL_AMOUNT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount6)
                .HasColumnName("BILL_AMOUNT_6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount7)
                .HasColumnName("BILL_AMOUNT_7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount8)
                .HasColumnName("BILL_AMOUNT_8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillAmount9)
                .HasColumnName("BILL_AMOUNT_9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompValue)
                .HasColumnName("COMP_VALUE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyFormat)
                .HasColumnName("CURRENCY_FORMAT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus1)
                .HasColumnName("FOLIO_STATUS_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus10)
                .HasColumnName("FOLIO_STATUS_10")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus2)
                .HasColumnName("FOLIO_STATUS_2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus3)
                .HasColumnName("FOLIO_STATUS_3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus4)
                .HasColumnName("FOLIO_STATUS_4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus5)
                .HasColumnName("FOLIO_STATUS_5")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus6)
                .HasColumnName("FOLIO_STATUS_6")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus7)
                .HasColumnName("FOLIO_STATUS_7")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus8)
                .HasColumnName("FOLIO_STATUS_8")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioStatus9)
                .HasColumnName("FOLIO_STATUS_9")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType1)
                .HasColumnName("FOLIO_TYPE_1")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType10)
                .HasColumnName("FOLIO_TYPE_10")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType2)
                .HasColumnName("FOLIO_TYPE_2")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType3)
                .HasColumnName("FOLIO_TYPE_3")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType4)
                .HasColumnName("FOLIO_TYPE_4")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType5)
                .HasColumnName("FOLIO_TYPE_5")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType6)
                .HasColumnName("FOLIO_TYPE_6")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType7)
                .HasColumnName("FOLIO_TYPE_7")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType8)
                .HasColumnName("FOLIO_TYPE_8")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FolioType9)
                .HasColumnName("FOLIO_TYPE_9")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GreekContractNumber)
                .HasColumnName("GREEK_CONTRACT_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.GuestType)
                .HasColumnName("GUEST_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastSeqNo)
                .HasColumnName("LAST_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewSeqNo)
                .HasColumnName("NEW_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewValue)
                .HasColumnName("NEW_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OldValue)
                .HasColumnName("OLD_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Payee1)
                .HasColumnName("PAYEE_1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Payee10)
                .HasColumnName("PAYEE_10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Payee2)
                .HasColumnName("PAYEE_2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Payee3)
                .HasColumnName("PAYEE_3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Payee4)
                .HasColumnName("PAYEE_4")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Payee5)
                .HasColumnName("PAYEE_5")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Payee6)
                .HasColumnName("PAYEE_6")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Payee7)
                .HasColumnName("PAYEE_7")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Payee8)
                .HasColumnName("PAYEE_8")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Payee9)
                .HasColumnName("PAYEE_9")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PmsDateFormat)
                .HasColumnName("PMS_DATE_FORMAT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNum)
                .HasColumnName("ROOM_NUM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdType)
                .HasColumnName("UPD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdTypeDesc)
                .HasColumnName("UPD_TYPE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
