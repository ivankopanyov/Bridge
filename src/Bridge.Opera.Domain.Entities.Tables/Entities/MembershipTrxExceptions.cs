namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTrxExceptions
{
    public decimal? MembershipTrxId { get; set; }
    public string? ExceptionType { get; set; }
    public decimal? ExpGroupId { get; set; }
    public string? MsgText { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxExceptions>(entity =>
        {
            entity.HasKey(e => new { e.MembershipTrxId, e.ExceptionType, e.ExpGroupId })
                .HasName("MTN_PK");

            entity.ToTable("MEMBERSHIP_TRX_EXCEPTIONS");

            entity.HasIndex(e => new { e.ExceptionType, e.ExpGroupId })
                .HasName("MEMBERSHIP_TRX_GRP_IDX");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExceptionType)
                .HasColumnName("EXCEPTION_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ExpGroupId)
                .HasColumnName("EXP_GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MsgText)
                .HasColumnName("MSG_TEXT")
                .HasMaxLength(240)
                .IsUnicode(false);
        });
	}
}
