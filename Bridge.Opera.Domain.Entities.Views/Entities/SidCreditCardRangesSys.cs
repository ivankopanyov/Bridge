namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidCreditCardRangesSys
{
    public string CcCard { get; set; }
    public string CardnoFrom { get; set; }
    public string CardnoTo { get; set; }
    public string AuthReversalYn { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string PaymentMethod { get; set; }
    public string CardNumberLength { get; set; }
    public string CardPrefix { get; set; }
    public string ValidationRule { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidCreditCardRangesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CREDIT_CARD_RANGES_SYS");

            entity.Property(e => e.AuthReversalYn)
                .HasColumnName("AUTH_REVERSAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CardNumberLength)
                .HasColumnName("CARD_NUMBER_LENGTH")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CardPrefix)
                .HasColumnName("CARD_PREFIX")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CardnoFrom)
                .IsRequired()
                .HasColumnName("CARDNO_FROM")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CardnoTo)
                .IsRequired()
                .HasColumnName("CARDNO_TO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CcCard)
                .IsRequired()
                .HasColumnName("CC_CARD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValidationRule)
                .HasColumnName("VALIDATION_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
