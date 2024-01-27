namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GrpFolioDetail
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
    public decimal? Grp1Amt { get; set; }
    public decimal? Grp2Amt { get; set; }
    public decimal? Grp3Amt { get; set; }
    public decimal? Grp4Amt { get; set; }
    public decimal? Grp5Amt { get; set; }
    public decimal? Grp6Amt { get; set; }
    public decimal? Grp7Amt { get; set; }
    public decimal? Grp8Amt { get; set; }
    public decimal? Grp9Amt { get; set; }
    public decimal? Grp10Amt { get; set; }
    public decimal? Grp11Amt { get; set; }
    public decimal? Grp12Amt { get; set; }
    public decimal? Grp1CurrAmt { get; set; }
    public decimal? Grp2CurrAmt { get; set; }
    public decimal? Grp3CurrAmt { get; set; }
    public decimal? Grp4CurrAmt { get; set; }
    public decimal? Grp5CurrAmt { get; set; }
    public decimal? Grp6CurrAmt { get; set; }
    public decimal? Grp7CurrAmt { get; set; }
    public decimal? Grp8CurrAmt { get; set; }
    public decimal? Grp9CurrAmt { get; set; }
    public decimal? Grp10CurrAmt { get; set; }
    public decimal? Grp11CurrAmt { get; set; }
    public decimal? Grp12CurrAmt { get; set; }
    public decimal? Debit { get; set; }
    public decimal? TotcurrDebitAmt { get; set; }
    public decimal? Credit { get; set; }
    public decimal? TotcurrCreditAmt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GrpFolioDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GRP_FOLIO_DETAIL");

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

            entity.Property(e => e.Grp10Amt)
                .HasColumnName("GRP10_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp10CurrAmt)
                .HasColumnName("GRP10_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp11Amt)
                .HasColumnName("GRP11_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp11CurrAmt)
                .HasColumnName("GRP11_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp12Amt)
                .HasColumnName("GRP12_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp12CurrAmt)
                .HasColumnName("GRP12_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp1Amt)
                .HasColumnName("GRP1_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp1CurrAmt)
                .HasColumnName("GRP1_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp2Amt)
                .HasColumnName("GRP2_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp2CurrAmt)
                .HasColumnName("GRP2_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp3Amt)
                .HasColumnName("GRP3_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp3CurrAmt)
                .HasColumnName("GRP3_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp4Amt)
                .HasColumnName("GRP4_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp4CurrAmt)
                .HasColumnName("GRP4_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp5Amt)
                .HasColumnName("GRP5_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp5CurrAmt)
                .HasColumnName("GRP5_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp6Amt)
                .HasColumnName("GRP6_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp6CurrAmt)
                .HasColumnName("GRP6_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp7Amt)
                .HasColumnName("GRP7_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp7CurrAmt)
                .HasColumnName("GRP7_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp8Amt)
                .HasColumnName("GRP8_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp8CurrAmt)
                .HasColumnName("GRP8_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp9Amt)
                .HasColumnName("GRP9_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Grp9CurrAmt)
                .HasColumnName("GRP9_CURR_AMT")
                .HasColumnType("NUMBER");

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
