namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTrxExceptionLog
{
    public decimal MembershipTrxId { get; set; }
    public string ExceptionType { get; set; }
    public decimal RelatedTrxId { get; set; }
    public string ProcessingMsg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTrxExceptionLog>(entity =>
        {
            entity.HasKey(e => new { e.MembershipTrxId, e.ExceptionType, e.RelatedTrxId })
                .HasName("MTG_PK");

            entity.ToTable("MEMBERSHIP_TRX_EXCEPTION_LOG");

            entity.Property(e => e.MembershipTrxId)
                .HasColumnName("MEMBERSHIP_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExceptionType)
                .HasColumnName("EXCEPTION_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RelatedTrxId)
                .HasColumnName("RELATED_TRX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessingMsg)
                .HasColumnName("PROCESSING_MSG")
                .IsUnicode(false);
        });
	}
}
