namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpdStaytrxrev
{
    public string RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string Resort { get; set; }
    public DateTime TransactionDate { get; set; }
    public string TransactionRevenueType { get; set; }
    public decimal? LocalRevenueAmount { get; set; }
    public decimal? CentralRevenueAmount { get; set; }
    public decimal MembershipTrxLinkId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpdStaytrxrev>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPD_STAYTRXREV");

            entity.Property(e => e.CentralRevenueAmount)
                .HasColumnName("CENTRAL_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalRevenueAmount)
                .HasColumnName("LOCAL_REVENUE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipTrxLinkId)
                .HasColumnName("MEMBERSHIP_TRX_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(121)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

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
