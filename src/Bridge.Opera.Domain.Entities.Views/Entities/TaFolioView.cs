namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaFolioView
{
    public decimal? ResvNameId { get; set; }
    public decimal? TrxNo { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxDesc { get; set; }
    public DateTime? TrxDate { get; set; }
    public string? RateCode { get; set; }
    public string? Remark { get; set; }
    public string? Reference { get; set; }
    public string? Currency { get; set; }
    public string? TaCommissionableYn { get; set; }
    public decimal? TrxAmount { get; set; }
    public decimal? GuestAccountDebit { get; set; }
    public string? FtSubtype { get; set; }
    public decimal? NetAmount { get; set; }
    public string? TaCommissionNetYn { get; set; }
    public string? SourceCommissionNetYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaFolioView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TA_FOLIO_VIEW");

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FtSubtype)
                .HasColumnName("FT_SUBTYPE")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.GuestAccountDebit)
                .HasColumnName("GUEST_ACCOUNT_DEBIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCommissionNetYn)
                .HasColumnName("SOURCE_COMMISSION_NET_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaCommissionNetYn)
                .HasColumnName("TA_COMMISSION_NET_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaCommissionableYn)
                .HasColumnName("TA_COMMISSIONABLE_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.TrxDesc)
                .HasColumnName("TRX_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
