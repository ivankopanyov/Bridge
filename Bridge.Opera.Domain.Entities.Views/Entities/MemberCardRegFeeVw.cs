namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberCardRegFeeVw
{
    public decimal FeeRecId { get; set; }
    public string MemberCardRegCode { get; set; }
    public DateTime? PaymentDate { get; set; }
    public string SourceType { get; set; }
    public string Source { get; set; }
    public string MembershipType { get; set; }
    public string OrigMembershipLevel { get; set; }
    public string FinalMembershipLevel { get; set; }
    public DateTime? OrigExpirationDate { get; set; }
    public DateTime? FinalExpirationDate { get; set; }
    public string MemberCardRegAction { get; set; }
    public string FeeCode { get; set; }
    public decimal FeeAmount { get; set; }
    public string CentralCurrencyCode { get; set; }
    public string PaymentComments { get; set; }
    public string CreditCardType { get; set; }
    public string PaymentType { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? MembershipId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberCardRegFeeVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_CARD_REG_FEE_VW");

            entity.Property(e => e.CentralCurrencyCode)
                .HasColumnName("CENTRAL_CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FeeAmount)
                .HasColumnName("FEE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FeeCode)
                .IsRequired()
                .HasColumnName("FEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FeeRecId)
                .HasColumnName("FEE_REC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FinalExpirationDate)
                .HasColumnName("FINAL_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FinalMembershipLevel)
                .HasColumnName("FINAL_MEMBERSHIP_LEVEL")
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

            entity.Property(e => e.MemberCardRegAction)
                .HasColumnName("MEMBER_CARD_REG_ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MemberCardRegCode)
                .HasColumnName("MEMBER_CARD_REG_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrigExpirationDate)
                .HasColumnName("ORIG_EXPIRATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OrigMembershipLevel)
                .HasColumnName("ORIG_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PaymentComments)
                .HasColumnName("PAYMENT_COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.PaymentDate)
                .HasColumnName("PAYMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceType)
                .HasColumnName("SOURCE_TYPE")
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
