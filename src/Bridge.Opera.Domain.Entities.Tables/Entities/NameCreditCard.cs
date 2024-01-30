namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameCreditCard
{
    public NameCreditCard()
    {
        ReservationName = new HashSet<ReservationName>();
        ReservationReceipts = new HashSet<ReservationReceipts>();
        ReservationReceiptsJrnl = new HashSet<ReservationReceiptsJrnl>();
    }

    public decimal? CreditCardId { get; set; }
    public decimal? NameId { get; set; }
    public string? CreditCardType { get; set; }
    public string? CreditCardNumber { get; set; }
    public string? CreditCardName { get; set; }
    public DateTime? CreditCardExpirationDate { get; set; }
    public string? Track2Data { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? CreditLimit { get; set; }
    public string? PrimaryYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string? IssueNumber { get; set; }
    public DateTime? StartDate { get; set; }
    public byte? LaptopChange { get; set; }
    public string? PaymentType { get; set; }
    public decimal? CardUsage { get; set; }
    public string? CreditCardExpirationDtStr { get; set; }
    public string? CardUsedFor { get; set; }
    public string? TmpCcn { get; set; }
    public string? TmpEds { get; set; }
    public string? PurgedYn { get; set; }
    public string? CreditCardNumber4Digits { get; set; }
    public string? VaultId { get; set; }
    public string? Resort { get; set; }
    public string? ChainCode { get; set; }

    public virtual Name Name { get; set; }
    public virtual ICollection<ReservationName> ReservationName { get; set; }
    public virtual ICollection<ReservationReceipts> ReservationReceipts { get; set; }
    public virtual ICollection<ReservationReceiptsJrnl> ReservationReceiptsJrnl { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameCreditCard>(entity =>
        {
            entity.HasKey(e => e.CreditCardId)
                .HasName("NAME_CREDIT_CARD_PK");

            entity.ToTable("NAME$_CREDIT_CARD");

            entity.HasIndex(e => e.CreditCardNumber)
                .HasName("NAME_CREDIT_CARD_N2");

            entity.HasIndex(e => e.NameId)
                .HasName("NAME_CREDIT_CARD_N1");

            entity.HasIndex(e => new { e.PurgedYn, e.InsertDate, e.LaptopChange })
                .HasName("NAME_CREDIT_CARD_PURGE_IDX");

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CardUsage)
                .HasColumnName("CARD_USAGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CardUsedFor)
                .HasColumnName("CARD_USED_FOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardExpirationDate)
                .HasColumnName("CREDIT_CARD_EXPIRATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardExpirationDtStr)
                .HasColumnName("CREDIT_CARD_EXPIRATION_DT_STR")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardName)
                .HasColumnName("CREDIT_CARD_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .HasMaxLength(65)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardNumber4Digits)
                .HasColumnName("CREDIT_CARD_NUMBER_4_DIGITS")
                .HasMaxLength(4)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditCardType)
                .IsRequired()
                .HasColumnName("CREDIT_CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

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
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PurgedYn)
                .HasColumnName("PURGED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TmpCcn)
                .HasColumnName("TMP_CCN")
                .HasMaxLength(65)
                .IsUnicode(false);

            entity.Property(e => e.TmpEds)
                .HasColumnName("TMP_EDS")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Track2Data)
                .HasColumnName("TRACK2_DATA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VaultId)
                .HasColumnName("VAULT_ID")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.NameCreditCard)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.Cascade)
	                .HasConstraintName("NAME_ID_FK7");
        
			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.ReservationName);

			if (!types.Contains(typeof(ReservationReceipts)))
				entity.Ignore(e => e.ReservationReceipts);

			if (!types.Contains(typeof(ReservationReceiptsJrnl)))
				entity.Ignore(e => e.ReservationReceiptsJrnl);
		});
	}
}
