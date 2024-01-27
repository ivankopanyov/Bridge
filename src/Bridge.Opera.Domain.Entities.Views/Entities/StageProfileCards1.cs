namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class StageProfileCards1
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public string CreditCardType { get; set; }
    public string CreditCardNumber { get; set; }
    public string CreditCardName { get; set; }
    public DateTime? Creditcardbegindate { get; set; }
    public DateTime? CreditCardExpirationDate { get; set; }
    public string ValidYn { get; set; }
    public string ErrorDesc { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string CreditCardExpirationStr { get; set; }
    public string CreditCardNumberStr { get; set; }
    public string CreditCardNumber4Digits { get; set; }
    public string VaultId { get; set; }
    public string EncCreditCardNumber { get; set; }
    public string Rowidx { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileCards1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("STAGE_PROFILE_CARDS");

            entity.Property(e => e.CreditCardExpirationDate)
                .HasColumnName("CREDIT_CARD_EXPIRATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardExpirationStr)
                .HasColumnName("CREDIT_CARD_EXPIRATION_STR")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardName)
                .HasColumnName("CREDIT_CARD_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardNumber4Digits)
                .HasColumnName("CREDIT_CARD_NUMBER_4_DIGITS")
                .HasMaxLength(4)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardNumberStr)
                .HasColumnName("CREDIT_CARD_NUMBER_STR")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .IsRequired()
                .HasColumnName("CREDIT_CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Creditcardbegindate)
                .HasColumnName("CREDITCARDBEGINDATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EncCreditCardNumber)
                .IsRequired()
                .HasColumnName("ENC_CREDIT_CARD_NUMBER")
                .HasMaxLength(65)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Rowidx)
                .HasColumnName("ROWIDX")
                .HasColumnType("ROWID")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VaultId)
                .HasColumnName("VAULT_ID")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
