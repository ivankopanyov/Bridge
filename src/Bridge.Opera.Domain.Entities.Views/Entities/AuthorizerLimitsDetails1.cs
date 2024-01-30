namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AuthorizerLimitsDetails1
{
    public string? Resort { get; set; }
    public decimal? AuthDetailId { get; set; }
    public decimal? AuthHeaderId { get; set; }
    public decimal? AuthorizerId { get; set; }
    public string? TrxCode { get; set; }
    public string? CompTrxCode { get; set; }
    public decimal? ArrangementId { get; set; }
    public string? ArrangementCode { get; set; }
    public string? AuthGroupCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AuthorizerLimitsDetails1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AUTHORIZER_LIMITS_DETAILS");

            entity.Property(e => e.ArrangementCode)
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthDetailId)
                .HasColumnName("AUTH_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthGroupCode)
                .HasColumnName("AUTH_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AuthHeaderId)
                .HasColumnName("AUTH_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompTrxCode)
                .HasColumnName("COMP_TRX_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
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
