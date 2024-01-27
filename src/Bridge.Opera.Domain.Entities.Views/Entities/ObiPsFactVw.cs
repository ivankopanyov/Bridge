namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPsFactVw
{
    public string Resort { get; set; }
    public DateTime BusinessDate { get; set; }
    public string RecTypeKeyId { get; set; }
    public string MenuKeyId { get; set; }
    public string RvcKeyId { get; set; }
    public string NameKeyId { get; set; }
    public string MarketKeyId { get; set; }
    public string HourKeyId { get; set; }
    public decimal? RecordAmt { get; set; }
    public decimal? RecordQty { get; set; }
    public decimal? NumOfGuests { get; set; }
    public decimal? TotalAmt { get; set; }
    public decimal? TotalTax { get; set; }
    public decimal? TotalServiceCharge { get; set; }
    public decimal? OperaNetAmount { get; set; }
    public decimal? OperaGrossAmount { get; set; }
    public decimal? CRecordAmt { get; set; }
    public decimal? CTotalAmt { get; set; }
    public decimal? CTotalTax { get; set; }
    public decimal? CTotalServiceCharge { get; set; }
    public decimal? COperaNetAmount { get; set; }
    public decimal? COperaGrossAmount { get; set; }
    public decimal? Rcnt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPsFactVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PS_FACT_VW");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.COperaGrossAmount)
                .HasColumnName("C_OPERA_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.COperaNetAmount)
                .HasColumnName("C_OPERA_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CRecordAmt)
                .HasColumnName("C_RECORD_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalAmt)
                .HasColumnName("C_TOTAL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalServiceCharge)
                .HasColumnName("C_TOTAL_SERVICE_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CTotalTax)
                .HasColumnName("C_TOTAL_TAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HourKeyId)
                .HasColumnName("HOUR_KEY_ID")
                .IsUnicode(false);

            entity.Property(e => e.MarketKeyId)
                .HasColumnName("MARKET_KEY_ID")
                .IsUnicode(false);

            entity.Property(e => e.MenuKeyId)
                .HasColumnName("MENU_KEY_ID")
                .IsUnicode(false);

            entity.Property(e => e.NameKeyId)
                .HasColumnName("NAME_KEY_ID")
                .IsUnicode(false);

            entity.Property(e => e.NumOfGuests)
                .HasColumnName("NUM_OF_GUESTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaGrossAmount)
                .HasColumnName("OPERA_GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaNetAmount)
                .HasColumnName("OPERA_NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rcnt)
                .HasColumnName("RCNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecTypeKeyId)
                .HasColumnName("REC_TYPE_KEY_ID")
                .IsUnicode(false);

            entity.Property(e => e.RecordAmt)
                .HasColumnName("RECORD_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecordQty)
                .HasColumnName("RECORD_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RvcKeyId)
                .HasColumnName("RVC_KEY_ID")
                .IsUnicode(false);

            entity.Property(e => e.TotalAmt)
                .HasColumnName("TOTAL_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalServiceCharge)
                .HasColumnName("TOTAL_SERVICE_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER");
        });
	}
}
