namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipFtIssuedAw
{
    public decimal TrxNo { get; set; }
    public string AwardVoucherNo { get; set; }
    public decimal? LocalIssuedAwardId { get; set; }
    public decimal? TotalLocalAmount { get; set; }
    public decimal? RedeemedLocalAmount { get; set; }
    public decimal? PointsRequired { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipFtIssuedAw>(entity =>
        {
            entity.HasKey(e => new { e.TrxNo, e.AwardVoucherNo })
                .HasName("MFW_PK");

            entity.ToTable("MEMBERSHIP_FT_ISSUED_AW");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardVoucherNo)
                .HasColumnName("AWARD_VOUCHER_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LocalIssuedAwardId)
                .HasColumnName("LOCAL_ISSUED_AWARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsRequired)
                .HasColumnName("POINTS_REQUIRED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RedeemedLocalAmount)
                .HasColumnName("REDEEMED_LOCAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalLocalAmount)
                .HasColumnName("TOTAL_LOCAL_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
