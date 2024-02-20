namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaVoucherBenefitHdr
{
    public string? VoucherBenefitCode { get; set; }
    public string? VoucherType { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? ChainCode { get; set; }
    public string? RefTypeCode { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaVoucherBenefitHdr>(entity =>
        {
            entity.HasKey(e => e.VoucherBenefitCode)
                .HasName("OPERA_VOU_BEN_HDR_PK");

            entity.ToTable("OPERA_VOUCHER_BENEFIT_HDR");

            entity.HasIndex(e => new { e.VoucherType, e.RefTypeCode, e.Resort })
                .HasName("VOUC_BEN_HDR_IND1");

            entity.Property(e => e.VoucherBenefitCode)
                .HasColumnName("VOUCHER_BENEFIT_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

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

            entity.Property(e => e.RefTypeCode)
                .HasColumnName("REF_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
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

            entity.Property(e => e.VoucherType)
                .IsRequired()
                .HasColumnName("VOUCHER_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
