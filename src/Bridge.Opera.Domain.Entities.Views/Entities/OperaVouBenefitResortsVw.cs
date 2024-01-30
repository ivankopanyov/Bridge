namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OperaVouBenefitResortsVw
{
    public string? VoucherBenefitCode { get; set; }
    public string? VoucherType { get; set; }
    public string? RefTypeCode { get; set; }
    public string? VoucherResort { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaVouBenefitResortsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OPERA_VOU_BENEFIT_RESORTS_VW");

            entity.Property(e => e.RefTypeCode)
                .HasColumnName("REF_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VoucherBenefitCode)
                .IsRequired()
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.VoucherResort)
                .HasColumnName("VOUCHER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VoucherType)
                .IsRequired()
                .HasColumnName("VOUCHER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
