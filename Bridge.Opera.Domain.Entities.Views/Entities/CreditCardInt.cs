namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CreditCardInt
{
    public string Resort { get; set; }
    public decimal? ExtraPerc { get; set; }
    public decimal? CreditLimit { get; set; }
    public string CardType { get; set; }
    public string CcTypeIfc { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string MerchantNumber { get; set; }
    public string ExpirationRule { get; set; }
    public string FormatMask { get; set; }
    public string Description { get; set; }
    public string TrxCode { get; set; }
    public decimal? NumberDigits { get; set; }
    public decimal? IssueNumber { get; set; }
    public decimal? StartDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CreditCardInt>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CREDIT_CARD_INT");

            entity.Property(e => e.CardType)
                .IsRequired()
                .HasColumnName("CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CcTypeIfc)
                .HasColumnName("CC_TYPE_IFC")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationRule)
                .HasColumnName("EXPIRATION_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtraPerc)
                .HasColumnName("EXTRA_PERC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FormatMask)
                .HasColumnName("FORMAT_MASK")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssueNumber)
                .HasColumnName("ISSUE_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MerchantNumber)
                .HasColumnName("MERCHANT_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberDigits)
                .HasColumnName("NUMBER_DIGITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
