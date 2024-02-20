namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipAwardFinTrxVw
{
    public string? MembershipType { get; set; }
    public string? AwardType { get; set; }
    public string? ChainCode { get; set; }
    public string? Resort { get; set; }
    public string? TrxCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipAwardFinTrxVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_AWARD_FIN_TRX_VW");

            entity.Property(e => e.AwardType)
                .HasColumnName("AWARD_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
