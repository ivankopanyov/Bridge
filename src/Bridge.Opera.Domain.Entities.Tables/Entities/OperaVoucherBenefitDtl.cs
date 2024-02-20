namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaVoucherBenefitDtl
{
    public string? VoucherBenefitDtlCode { get; set; }
    public string? VoucherBenefitCode { get; set; }
    public string? BenefitBasedOn { get; set; }
    public decimal? NoOfUnits { get; set; }
    public string? RateCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? ApplySeq { get; set; }
    public string? ChainCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaVoucherBenefitDtl>(entity =>
        {
            entity.HasKey(e => e.VoucherBenefitDtlCode)
                .HasName("OPERA_VOU_BEN_DTL_PK");

            entity.ToTable("OPERA_VOUCHER_BENEFIT_DTL");

            entity.HasIndex(e => e.RateCode)
                .HasName("VOUC_BEN_DTL_IND1");

            entity.HasIndex(e => e.VoucherBenefitCode)
                .HasName("VOUC_BEN_DTL_IND2");

            entity.Property(e => e.VoucherBenefitDtlCode)
                .HasColumnName("VOUCHER_BENEFIT_DTL_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ApplySeq)
                .HasColumnName("APPLY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BenefitBasedOn)
                .IsRequired()
                .HasColumnName("BENEFIT_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoOfUnits)
                .HasColumnName("NO_OF_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VoucherBenefitCode)
                .IsRequired()
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
