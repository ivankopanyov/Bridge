namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTrxRevenueDtl
{
    public decimal MemTrxRevDtlId { get; set; }
    public DateTime TransactionDate { get; set; }
    public string TransactionRevenueType { get; set; }
    public decimal? LocalRevenueAmount { get; set; }
    public string FolioView { get; set; }
    public decimal? CentralRevenueAmount { get; set; }
    public decimal MembershipTrxLinkId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxRevenueDtl>(entity =>
        {
            entity.HasKey(e => e.MemTrxRevDtlId)
                .HasName("MEMBERSHIP_TRX_REVENUES_F_PK");

            entity.ToTable("MEMBERSHIP_TRX_REVENUE_DTL");

            entity.HasIndex(e => e.MembershipTrxLinkId)
                .HasName("MEMBERSHIP_REVENUE_LINK_F_IND");

            entity.HasIndex(e => e.TransactionRevenueType)
                .HasName("MEMBERSHIP_TRX_REVENUES_F_IND3");

            entity.HasIndex(e => new { e.TransactionDate, e.TransactionRevenueType, e.FolioView })
                .HasName("MEMBERSHIP_TRX_REVENUES_F_IND4");

            entity.Property(e => e.MemTrxRevDtlId)
                .HasColumnName("MEM_TRX_REV_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CentralRevenueAmount)
                .HasColumnName("CENTRAL_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .IsRequired()
                .HasColumnName("FOLIO_VIEW")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LocalRevenueAmount)
                .HasColumnName("LOCAL_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxLinkId)
                .HasColumnName("MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransactionDate)
                .HasColumnName("TRANSACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TransactionRevenueType)
                .IsRequired()
                .HasColumnName("TRANSACTION_REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
