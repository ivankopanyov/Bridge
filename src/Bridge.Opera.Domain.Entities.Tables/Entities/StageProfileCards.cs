namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileCards
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
    public string TmpCcn { get; set; }
    public string TmpEds { get; set; }
    public string CreditCardNumber4Digits { get; set; }
    public string VaultId { get; set; }

    public virtual StageProfiles ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileCards>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE$_PROFILE_CARDS");

            entity.HasIndex(e => e.CreditCardNumber)
                .HasName("STAGE_PROF_CARDS_IND2");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId })
                .HasName("STAGE_PROF_CARDS_IND1");

            entity.Property(e => e.CreditCardExpirationDate)
                .HasColumnName("CREDIT_CARD_EXPIRATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardExpirationStr)
                .HasColumnName("CREDIT_CARD_EXPIRATION_STR")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardName)
                .HasColumnName("CREDIT_CARD_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumber)
                .IsRequired()
                .HasColumnName("CREDIT_CARD_NUMBER")
                .HasMaxLength(65)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardNumber4Digits)
                .HasColumnName("CREDIT_CARD_NUMBER_4_DIGITS")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .IsRequired()
                .HasColumnName("CREDIT_CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Creditcardbegindate)
                .HasColumnName("CREDITCARDBEGINDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ErrorDesc)
                .HasColumnName("ERROR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TmpCcn)
                .HasColumnName("TMP_CCN")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.TmpEds)
                .HasColumnName("TMP_EDS")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ValidYn)
                .HasColumnName("VALID_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.VaultId)
                .HasColumnName("VAULT_ID")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(StageProfiles)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.ResortNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("STAGE_PROFILE_CARDS_FK1");
        });
	}
}
