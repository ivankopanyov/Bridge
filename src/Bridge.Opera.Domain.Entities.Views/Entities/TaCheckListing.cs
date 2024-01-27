namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaCheckListing
{
    public string Resort { get; set; }
    public decimal AccountId { get; set; }
    public string ChkCurrency { get; set; }
    public decimal? CheckNo { get; set; }
    public DateTime? CheckDate { get; set; }
    public string ReferenceNo { get; set; }
    public string Payee { get; set; }
    public string ClearedYn { get; set; }
    public string Status { get; set; }
    public decimal? ExchangeRate { get; set; }
    public decimal? Void { get; set; }
    public decimal? Closed { get; set; }
    public decimal? Open { get; set; }
    public decimal? Unrepr { get; set; }
    public decimal? VoidLocal { get; set; }
    public decimal? ClosedLocal { get; set; }
    public decimal? OpenLocal { get; set; }
    public decimal? UnreprLocal { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaCheckListing>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TA_CHECK_LISTING");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckDate)
                .HasColumnName("CHECK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckNo)
                .HasColumnName("CHECK_NO")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.ChkCurrency)
                .HasColumnName("CHK_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClearedYn)
                .HasColumnName("CLEARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Closed)
                .HasColumnName("CLOSED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClosedLocal)
                .HasColumnName("CLOSED_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Open)
                .HasColumnName("OPEN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenLocal)
                .HasColumnName("OPEN_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Payee)
                .HasColumnName("PAYEE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReferenceNo)
                .HasColumnName("REFERENCE_NO")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Unrepr)
                .HasColumnName("UNREPR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UnreprLocal)
                .HasColumnName("UNREPR_LOCAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Void)
                .HasColumnName("VOID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VoidLocal)
                .HasColumnName("VOID_LOCAL")
                .HasColumnType("NUMBER");
        });
	}
}
