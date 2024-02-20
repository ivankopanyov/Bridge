namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinTranPkgPostings
{
    public string? Srs { get; set; }
    public decimal? TrxNo { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? TrxCode { get; set; }
    public string? TrxDesc { get; set; }
    public string? RateCode { get; set; }
    public string? Product { get; set; }
    public string? ProductDesc { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? PricePerUnit { get; set; }
    public decimal? Allowance { get; set; }
    public decimal? AmtPosted { get; set; }
    public decimal? Overage { get; set; }
    public decimal? TrxNoAgainstPackage { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? TrxNoAddedBy { get; set; }
    public decimal? ToResvNameId { get; set; }
    public string? FromRoom { get; set; }
    public string? TakenFromRoom { get; set; }
    public string? ConsumeOthers { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? FtResvNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranPkgPostings>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_TRAN_PKG_POSTINGS");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Allowance)
                .HasColumnName("ALLOWANCE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.AmtPosted)
                .HasColumnName("AMT_POSTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsumeOthers)
                .HasColumnName("CONSUME_OTHERS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FromRoom)
                .HasColumnName("FROM_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.FtResvNameId)
                .HasColumnName("FT_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Overage)
                .HasColumnName("OVERAGE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PricePerUnit)
                .HasColumnName("PRICE_PER_UNIT")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductDesc)
                .HasColumnName("PRODUCT_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER(12,3)");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Srs)
                .HasColumnName("SRS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.TakenFromRoom)
                .HasColumnName("TAKEN_FROM_ROOM")
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToResvNameId)
                .HasColumnName("TO_RESV_NAME_ID")
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
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAddedBy)
                .HasColumnName("TRX_NO_ADDED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAgainstPackage)
                .HasColumnName("TRX_NO_AGAINST_PACKAGE")
                .HasColumnType("NUMBER");
        });
	}
}
