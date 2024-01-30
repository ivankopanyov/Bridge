namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTrxRevenues
{
    public DateTime? TransactionDate { get; set; }
    public string? TransactionRevenueType { get; set; }
    public decimal? LocalRevenueAmount { get; set; }
    public decimal? CentralRevenueAmount { get; set; }
    public decimal? MembershipTrxLinkId { get; set; }
    public string? QualifiedRevenueYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxRevenues>(entity =>
        {
            entity.HasKey(e => new { e.MembershipTrxLinkId, e.TransactionRevenueType, e.TransactionDate })
                .HasName("MEMBERSHIP_TRX_REVENUES_PK");

            entity.ToTable("MEMBERSHIP_TRX_REVENUES");

            entity.HasIndex(e => e.MembershipTrxLinkId)
                .HasName("MEMBERSHIP_REVENUE_LINK_IND");

            entity.HasIndex(e => e.TransactionRevenueType)
                .HasName("MEMBERSHIP_TRX_REVENUES_IND3");

            entity.HasIndex(e => new { e.TransactionDate, e.TransactionRevenueType })
                .HasName("MEMBERSHIP_TRX_REVENUES_IND4");

            entity.Property(e => e.MembershipTrxLinkId)
                .HasColumnName("MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionRevenueType)
                .HasColumnName("TRANSACTION_REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDate)
                .HasColumnName("TRANSACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CentralRevenueAmount)
                .HasColumnName("CENTRAL_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalRevenueAmount)
                .HasColumnName("LOCAL_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QualifiedRevenueYn)
                .HasColumnName("QUALIFIED_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
