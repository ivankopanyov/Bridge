namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GrpFolioFooter
{
    public decimal? ResvNameId { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public string? FolioType { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? Totgrp1Amt { get; set; }
    public decimal? Totgrp2Amt { get; set; }
    public decimal? Totgrp3Amt { get; set; }
    public decimal? Totgrp4Amt { get; set; }
    public decimal? Totgrp5Amt { get; set; }
    public decimal? Totgrp6Amt { get; set; }
    public decimal? Totgrp7Amt { get; set; }
    public decimal? Totgrp8Amt { get; set; }
    public decimal? Totgrp9Amt { get; set; }
    public decimal? Totgrp10Amt { get; set; }
    public decimal? Totgrp11Amt { get; set; }
    public decimal? Totgrp12Amt { get; set; }
    public decimal? Tot1CurrAmt { get; set; }
    public decimal? Tot2CurrAmt { get; set; }
    public decimal? Tot3CurrAmt { get; set; }
    public decimal? Tot4CurrAmt { get; set; }
    public decimal? Tot5CurrAmt { get; set; }
    public decimal? Tot6CurrAmt { get; set; }
    public decimal? Tot7CurrAmt { get; set; }
    public decimal? Tot8CurrAmt { get; set; }
    public decimal? Tot9CurrAmt { get; set; }
    public decimal? Tot10CurrAmt { get; set; }
    public decimal? Tot11CurrAmt { get; set; }
    public decimal? Tot12CurrAmt { get; set; }
    public decimal? Total { get; set; }
    public decimal? DebitCurrAmt { get; set; }
    public decimal? Totpayments { get; set; }
    public decimal? CreditCurrAmt { get; set; }
    public string? SummCurr { get; set; }
    public decimal? SummExchRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GrpFolioFooter>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GRP_FOLIO_FOOTER");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreditCurrAmt)
                .HasColumnName("CREDIT_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DebitCurrAmt)
                .HasColumnName("DEBIT_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SummCurr)
                .HasColumnName("SUMM_CURR")
                .IsUnicode(false);

            entity.Property(e => e.SummExchRate)
                .HasColumnName("SUMM_EXCH_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot10CurrAmt)
                .HasColumnName("TOT10_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot11CurrAmt)
                .HasColumnName("TOT11_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot12CurrAmt)
                .HasColumnName("TOT12_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot1CurrAmt)
                .HasColumnName("TOT1_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot2CurrAmt)
                .HasColumnName("TOT2_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot3CurrAmt)
                .HasColumnName("TOT3_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot4CurrAmt)
                .HasColumnName("TOT4_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot5CurrAmt)
                .HasColumnName("TOT5_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot6CurrAmt)
                .HasColumnName("TOT6_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot7CurrAmt)
                .HasColumnName("TOT7_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot8CurrAmt)
                .HasColumnName("TOT8_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tot9CurrAmt)
                .HasColumnName("TOT9_CURR_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Total)
                .HasColumnName("TOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp10Amt)
                .HasColumnName("TOTGRP10_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp11Amt)
                .HasColumnName("TOTGRP11_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp12Amt)
                .HasColumnName("TOTGRP12_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp1Amt)
                .HasColumnName("TOTGRP1_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp2Amt)
                .HasColumnName("TOTGRP2_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp3Amt)
                .HasColumnName("TOTGRP3_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp4Amt)
                .HasColumnName("TOTGRP4_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp5Amt)
                .HasColumnName("TOTGRP5_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp6Amt)
                .HasColumnName("TOTGRP6_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp7Amt)
                .HasColumnName("TOTGRP7_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp8Amt)
                .HasColumnName("TOTGRP8_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totgrp9Amt)
                .HasColumnName("TOTGRP9_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Totpayments)
                .HasColumnName("TOTPAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");
        });
	}
}
