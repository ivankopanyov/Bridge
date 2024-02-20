namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationVoucherBenefits
{
    public decimal? ResvVoucherId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? VoucherNo { get; set; }
    public string? VoucherType { get; set; }
    public string? VoucherBenefitCode { get; set; }
    public string? VoucherBenefitDtlCode { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? StayDay { get; set; }
    public string? BenefitBasedOn { get; set; }
    public decimal? NoOfUnits { get; set; }
    public string? RateCode { get; set; }
    public decimal? ApplySeq { get; set; }
    public string? RetroBenefitYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? RefTypeCode { get; set; }
    public string? ECertificateNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationVoucherBenefits>(entity =>
        {
            entity.HasKey(e => e.ResvVoucherId)
                .HasName("RESV_VOUCHER_BENEFIT_PK");

            entity.ToTable("RESERVATION_VOUCHER_BENEFITS");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("RESV_VOUCHER_BENEFIT_IDX1");

            entity.HasIndex(e => new { e.VoucherBenefitCode, e.VoucherBenefitDtlCode })
                .HasName("RESV_VOUCHER_BENEFIT_IDX3");

            entity.HasIndex(e => new { e.VoucherNo, e.VoucherType })
                .HasName("RESV_VOUCHER_BENEFIT_IDX2");

            entity.Property(e => e.ResvVoucherId)
                .HasColumnName("RESV_VOUCHER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ApplySeq)
                .HasColumnName("APPLY_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BenefitBasedOn)
                .HasColumnName("BENEFIT_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ECertificateNo)
                .HasColumnName("E_CERTIFICATE_NO")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RefTypeCode)
                .HasColumnName("REF_TYPE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RetroBenefitYn)
                .HasColumnName("RETRO_BENEFIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StayDay)
                .HasColumnName("STAY_DAY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VoucherBenefitCode)
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VoucherBenefitDtlCode)
                .HasColumnName("VOUCHER_BENEFIT_DTL_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VoucherNo)
                .IsRequired()
                .HasColumnName("VOUCHER_NO")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VoucherType)
                .IsRequired()
                .HasColumnName("VOUCHER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
