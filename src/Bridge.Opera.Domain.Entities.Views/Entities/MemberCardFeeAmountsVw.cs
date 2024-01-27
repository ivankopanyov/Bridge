namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemberCardFeeAmountsVw
{
    public string ChainCode { get; set; }
    public string MembershipType { get; set; }
    public string MembershipLevel { get; set; }
    public string FeeCode { get; set; }
    public string Description { get; set; }
    public string FeeLabel { get; set; }
    public decimal FeeAmount { get; set; }
    public DateTime? FeeCodeInactiveDate { get; set; }
    public DateTime? FeeAmountInactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemberCardFeeAmountsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBER_CARD_FEE_AMOUNTS_VW");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.FeeAmount)
                .HasColumnName("FEE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FeeAmountInactiveDate)
                .HasColumnName("FEE_AMOUNT_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FeeCode)
                .IsRequired()
                .HasColumnName("FEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FeeCodeInactiveDate)
                .HasColumnName("FEE_CODE_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FeeLabel)
                .IsRequired()
                .HasColumnName("FEE_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipLevel)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
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
