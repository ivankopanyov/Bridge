namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaVoucherBenefitsGtt
{
    public string? TabName { get; set; }
    public decimal? TabRowId { get; set; }
    public string? SelectedYn { get; set; }
    public decimal? ResvVoucherId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ResvPromotion { get; set; }
    public string? VoucherNo { get; set; }
    public string? VoucherType { get; set; }
    public string? VoucherBenefitCode { get; set; }
    public string? VoucherBenefitDtlCode { get; set; }
    public DateTime? StayDate { get; set; }
    public decimal? StayDay { get; set; }
    public string? BenefitBasedOn { get; set; }
    public decimal? NoOfUnits { get; set; }
    public string? VouRateCode { get; set; }
    public string? ResvRateCode { get; set; }
    public decimal? ApplySeq { get; set; }
    public string? RetroBenefitYn { get; set; }
    public string? ECertificateNo { get; set; }
    public string? RefTypeCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? ExpDate { get; set; }
    public string? SysStatus { get; set; }
    public string? ValidFlg { get; set; }
    public string? ErrCode { get; set; }
    public string? ErrDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaVoucherBenefitsGtt>(entity =>
        {
            entity.HasKey(e => new { e.TabName, e.TabRowId })
                .HasName("O_VOU_BEN_GTT_PK");

            entity.ToTable("OPERA_VOUCHER_BENEFITS_GTT");

            entity.HasIndex(e => new { e.TabName, e.VoucherNo })
                .HasName("O_VOU_BEN_GTT_IND1");

            entity.HasIndex(e => new { e.TabName, e.BenefitBasedOn, e.StayDate })
                .HasName("O_VOU_BEN_GTT_IND2");

            entity.Property(e => e.TabName)
                .HasColumnName("TAB_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TabRowId)
                .HasColumnName("TAB_ROW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ApplySeq)
                .HasColumnName("APPLY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BenefitBasedOn)
                .HasColumnName("BENEFIT_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ECertificateNo)
                .HasColumnName("E_CERTIFICATE_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ErrCode)
                .HasColumnName("ERR_CODE")
                .IsUnicode(false);

            entity.Property(e => e.ErrDesc)
                .HasColumnName("ERR_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ExpDate)
                .HasColumnName("EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NoOfUnits)
                .HasColumnName("NO_OF_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RefTypeCode)
                .HasColumnName("REF_TYPE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvPromotion)
                .HasColumnName("RESV_PROMOTION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResvRateCode)
                .HasColumnName("RESV_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvVoucherId)
                .HasColumnName("RESV_VOUCHER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RetroBenefitYn)
                .HasColumnName("RETRO_BENEFIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SelectedYn)
                .HasColumnName("SELECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StayDate)
                .HasColumnName("STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StayDay)
                .HasColumnName("STAY_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SysStatus)
                .HasColumnName("SYS_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ValidFlg)
                .HasColumnName("VALID_FLG")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'U'");

            entity.Property(e => e.VouRateCode)
                .HasColumnName("VOU_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.VoucherBenefitCode)
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.VoucherBenefitDtlCode)
                .HasColumnName("VOUCHER_BENEFIT_DTL_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.VoucherNo)
                .HasColumnName("VOUCHER_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.VoucherType)
                .HasColumnName("VOUCHER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
