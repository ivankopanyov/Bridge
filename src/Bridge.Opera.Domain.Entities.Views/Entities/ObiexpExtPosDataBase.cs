namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpExtPosDataBase
{
    public string RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public decimal Id { get; set; }
    public string Resort { get; set; }
    public DateTime BusinessDate { get; set; }
    public string CheckNumber { get; set; }
    public decimal RecordNo { get; set; }
    public string RecordUkey { get; set; }
    public string RevCenter { get; set; }
    public DateTime? TransactionDate { get; set; }
    public string CheckNumberId { get; set; }
    public string RecordType { get; set; }
    public string RecordTypeId { get; set; }
    public decimal? RecordAmt { get; set; }
    public decimal? RecordQty { get; set; }
    public string OrderType { get; set; }
    public string PriceLevel { get; set; }
    public DateTime? OpenBusinessDate { get; set; }
    public DateTime? CloseBusinessDate { get; set; }
    public decimal? NumOfGuests { get; set; }
    public decimal? NumOfDetail { get; set; }
    public decimal? TotalAmt { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? TotalTaxExempt { get; set; }
    public decimal? TotalVoid { get; set; }
    public decimal? TotalTip { get; set; }
    public decimal? ReturnTotal { get; set; }
    public decimal? ManagerVoidTotal { get; set; }
    public decimal? ErrCorrectTotal { get; set; }
    public decimal? TotalServiceCharge { get; set; }
    public decimal? TotalDiscount { get; set; }
    public decimal? SubTotal { get; set; }
    public decimal? RepRecordQty { get; set; }
    public decimal? RepRecordAmt { get; set; }
    public string VoidYn { get; set; }
    public string ReturnYn { get; set; }
    public string EmployeeId { get; set; }
    public string Ref1 { get; set; }
    public string Ref2 { get; set; }
    public string ShowOnRepYn { get; set; }
    public string MasterPosRefId { get; set; }
    public string WorkStationId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string MenuId { get; set; }
    public decimal? XRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpExtPosDataBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_EXT_POS_DATA_BASE");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckNumber)
                .IsRequired()
                .HasColumnName("CHECK_NUMBER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CheckNumberId)
                .HasColumnName("CHECK_NUMBER_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CloseBusinessDate)
                .HasColumnName("CLOSE_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EmployeeId)
                .HasColumnName("EMPLOYEE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrCorrectTotal)
                .HasColumnName("ERR_CORRECT_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ManagerVoidTotal)
                .HasColumnName("MANAGER_VOID_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterPosRefId)
                .HasColumnName("MASTER_POS_REF_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
                .IsUnicode(false);

            entity.Property(e => e.NumOfDetail)
                .HasColumnName("NUM_OF_DETAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumOfGuests)
                .HasColumnName("NUM_OF_GUESTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenBusinessDate)
                .HasColumnName("OPEN_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrderType)
                .HasColumnName("ORDER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriceLevel)
                .HasColumnName("PRICE_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordAmt)
                .HasColumnName("RECORD_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordNo)
                .HasColumnName("RECORD_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordQty)
                .HasColumnName("RECORD_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordTypeId)
                .IsRequired()
                .HasColumnName("RECORD_TYPE_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RecordUkey)
                .HasColumnName("RECORD_UKEY")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Ref1)
                .HasColumnName("REF_1")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Ref2)
                .HasColumnName("REF_2")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RepRecordAmt)
                .HasColumnName("REP_RECORD_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepRecordQty)
                .HasColumnName("REP_RECORD_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReturnTotal)
                .HasColumnName("RETURN_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReturnYn)
                .HasColumnName("RETURN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RevCenter)
                .HasColumnName("REV_CENTER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(61)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.ShowOnRepYn)
                .HasColumnName("SHOW_ON_REP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SubTotal)
                .HasColumnName("SUB_TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalAmt)
                .HasColumnName("TOTAL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalDiscount)
                .HasColumnName("TOTAL_DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalServiceCharge)
                .HasColumnName("TOTAL_SERVICE_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTaxExempt)
                .HasColumnName("TOTAL_TAX_EXEMPT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTip)
                .HasColumnName("TOTAL_TIP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalVoid)
                .HasColumnName("TOTAL_VOID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionDate)
                .HasColumnName("TRANSACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VoidYn)
                .HasColumnName("VOID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WorkStationId)
                .HasColumnName("WORK_STATION_ID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.XRate)
                .HasColumnName("X_RATE")
                .HasColumnType("NUMBER");
        });
	}
}
