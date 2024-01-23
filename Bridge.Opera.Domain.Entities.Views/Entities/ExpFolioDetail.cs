namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpFolioDetail
{
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public string FolioType { get; set; }
    public DateTime TrxDate { get; set; }
    public decimal? FromResvId { get; set; }
    public string Room { get; set; }
    public string FolioStyle { get; set; }
    public decimal? FromId { get; set; }
    public string Description { get; set; }
    public string FullName { get; set; }
    public string DetailCurrency { get; set; }
    public decimal? CurrExchangeRate { get; set; }
    public decimal? Exp1Amt { get; set; }
    public decimal? Exp2Amt { get; set; }
    public decimal? Exp3Amt { get; set; }
    public decimal? Exp4Amt { get; set; }
    public decimal? Exp5Amt { get; set; }
    public decimal? Exp6Amt { get; set; }
    public decimal? Exp7Amt { get; set; }
    public decimal? Exp8Amt { get; set; }
    public decimal? Exp9Amt { get; set; }
    public decimal? Exp10Amt { get; set; }
    public decimal? Exp11Amt { get; set; }
    public decimal? Exp12Amt { get; set; }
    public decimal? Exp1CurrAmt { get; set; }
    public decimal? Exp2CurrAmt { get; set; }
    public decimal? Exp3CurrAmt { get; set; }
    public decimal? Exp4CurrAmt { get; set; }
    public decimal? Exp5CurrAmt { get; set; }
    public decimal? Exp6CurrAmt { get; set; }
    public decimal? Exp7CurrAmt { get; set; }
    public decimal? Exp8CurrAmt { get; set; }
    public decimal? Exp9CurrAmt { get; set; }
    public decimal? Exp10CurrAmt { get; set; }
    public decimal? Exp11CurrAmt { get; set; }
    public decimal? Exp12CurrAmt { get; set; }
    public decimal? Debit { get; set; }
    public decimal? TotcurrDebitAmt { get; set; }
    public decimal? Credit { get; set; }
    public decimal? TotcurrCreditAmt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpFolioDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_FOLIO_DETAIL");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Credit)
                .HasColumnName("CREDIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrExchangeRate)
                .HasColumnName("CURR_EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Debit)
                .HasColumnName("DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.DetailCurrency)
                .HasColumnName("DETAIL_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.Exp10Amt)
                .HasColumnName("EXP10_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp10CurrAmt)
                .HasColumnName("EXP10_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp11Amt)
                .HasColumnName("EXP11_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp11CurrAmt)
                .HasColumnName("EXP11_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp12Amt)
                .HasColumnName("EXP12_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp12CurrAmt)
                .HasColumnName("EXP12_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp1Amt)
                .HasColumnName("EXP1_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp1CurrAmt)
                .HasColumnName("EXP1_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp2Amt)
                .HasColumnName("EXP2_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp2CurrAmt)
                .HasColumnName("EXP2_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp3Amt)
                .HasColumnName("EXP3_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp3CurrAmt)
                .HasColumnName("EXP3_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp4Amt)
                .HasColumnName("EXP4_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp4CurrAmt)
                .HasColumnName("EXP4_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp5Amt)
                .HasColumnName("EXP5_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp5CurrAmt)
                .HasColumnName("EXP5_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp6Amt)
                .HasColumnName("EXP6_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp6CurrAmt)
                .HasColumnName("EXP6_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp7Amt)
                .HasColumnName("EXP7_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp7CurrAmt)
                .HasColumnName("EXP7_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp8Amt)
                .HasColumnName("EXP8_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp8CurrAmt)
                .HasColumnName("EXP8_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp9Amt)
                .HasColumnName("EXP9_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Exp9CurrAmt)
                .HasColumnName("EXP9_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioStyle)
                .HasColumnName("FOLIO_STYLE")
                .HasColumnType("CHAR(2)");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FromId)
                .HasColumnName("FROM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .IsUnicode(false);

            entity.Property(e => e.TotcurrCreditAmt)
                .HasColumnName("TOTCURR_CREDIT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotcurrDebitAmt)
                .HasColumnName("TOTCURR_DEBIT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
