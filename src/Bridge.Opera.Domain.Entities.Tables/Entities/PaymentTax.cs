namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PaymentTax
{
    public string? Resort { get; set; }
    public string? TaxInvNo { get; set; }
    public string? TaxInvNoLink { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? TrxNo { get; set; }
    public string? TrxCode { get; set; }
    public string? PaymentType { get; set; }
    public decimal? PaymentAmount { get; set; }
    public decimal? VatableAmount { get; set; }
    public decimal? NonVatableAmount { get; set; }
    public decimal? VatPaid { get; set; }
    public decimal? CreditApplied { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? InvoiceNo { get; set; }
    public decimal? AccountCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? PayeeNameId { get; set; }
    public string? ProcessType { get; set; }
    public DateTime? PaymentDate { get; set; }
    public decimal? Tax2 { get; set; }
    public decimal? Tax3 { get; set; }
    public decimal? Tax4 { get; set; }
    public decimal? Tax5 { get; set; }
    public decimal? Tax6 { get; set; }
    public decimal? Tax7 { get; set; }
    public decimal? Tax8 { get; set; }
    public decimal? Tax9 { get; set; }
    public decimal? Xtax1 { get; set; }
    public decimal? Xtax2 { get; set; }
    public decimal? Xtax3 { get; set; }
    public decimal? Xtax4 { get; set; }
    public decimal? Xtax5 { get; set; }
    public decimal? Xtax6 { get; set; }
    public decimal? Xtax7 { get; set; }
    public decimal? Xtax8 { get; set; }
    public decimal? Xtax9 { get; set; }
    public decimal? Xtax10 { get; set; }
    public decimal? Tax11 { get; set; }
    public decimal? Tax12 { get; set; }
    public decimal? Tax13 { get; set; }
    public decimal? Tax14 { get; set; }
    public decimal? Tax15 { get; set; }
    public decimal? Tax16 { get; set; }
    public decimal? Tax17 { get; set; }
    public decimal? Tax18 { get; set; }
    public decimal? Tax19 { get; set; }
    public decimal? Tax20 { get; set; }
    public decimal? Xtax11 { get; set; }
    public decimal? Xtax12 { get; set; }
    public decimal? Xtax13 { get; set; }
    public decimal? Xtax14 { get; set; }
    public decimal? Xtax15 { get; set; }
    public decimal? Xtax16 { get; set; }
    public decimal? Xtax17 { get; set; }
    public decimal? Xtax18 { get; set; }
    public decimal? Xtax19 { get; set; }
    public decimal? Xtax20 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PaymentTax>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TaxInvNo })
                .HasName("PT_PK");

            entity.ToTable("PAYMENT_TAX");

            entity.HasIndex(e => e.PaymentType)
                .HasName("PT_PTT_FK_I");

            entity.HasIndex(e => e.TrxNo)
                .HasName("PAYMENT_TAX_IDX2");

            entity.HasIndex(e => new { e.NameId, e.Resort })
                .HasName("PAYMENT_TAX_NAMEID_IDX");

            entity.HasIndex(e => new { e.Resort, e.InvoiceNo })
                .HasName("PAYMENT_TAX_IDX3");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.FolioView })
                .HasName("PAYMENT_TAX_IDX1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxInvNo)
                .HasColumnName("TAX_INV_NO")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreditApplied)
                .HasColumnName("CREDIT_APPLIED")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NonVatableAmount)
                .HasColumnName("NON_VATABLE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PayeeNameId)
                .HasColumnName("PAYEE_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentAmount)
                .HasColumnName("PAYMENT_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentDate)
                .HasColumnName("PAYMENT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentType)
                .IsRequired()
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProcessType)
                .HasColumnName("PROCESS_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax11)
                .HasColumnName("TAX11")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax12)
                .HasColumnName("TAX12")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax13)
                .HasColumnName("TAX13")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax14)
                .HasColumnName("TAX14")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax15)
                .HasColumnName("TAX15")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax16)
                .HasColumnName("TAX16")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax17)
                .HasColumnName("TAX17")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax18)
                .HasColumnName("TAX18")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax19)
                .HasColumnName("TAX19")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax2)
                .HasColumnName("TAX2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax20)
                .HasColumnName("TAX20")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax3)
                .HasColumnName("TAX3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax4)
                .HasColumnName("TAX4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax5)
                .HasColumnName("TAX5")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax6)
                .HasColumnName("TAX6")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax7)
                .HasColumnName("TAX7")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax8)
                .HasColumnName("TAX8")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Tax9)
                .HasColumnName("TAX9")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxInvNoLink)
                .HasColumnName("TAX_INV_NO_LINK")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
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

            entity.Property(e => e.VatPaid)
                .HasColumnName("VAT_PAID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.VatableAmount)
                .HasColumnName("VATABLE_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax1)
                .HasColumnName("XTAX1")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax10)
                .HasColumnName("XTAX10")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax11)
                .HasColumnName("XTAX11")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax12)
                .HasColumnName("XTAX12")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax13)
                .HasColumnName("XTAX13")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax14)
                .HasColumnName("XTAX14")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax15)
                .HasColumnName("XTAX15")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax16)
                .HasColumnName("XTAX16")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax17)
                .HasColumnName("XTAX17")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax18)
                .HasColumnName("XTAX18")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax19)
                .HasColumnName("XTAX19")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax2)
                .HasColumnName("XTAX2")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax20)
                .HasColumnName("XTAX20")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax3)
                .HasColumnName("XTAX3")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax4)
                .HasColumnName("XTAX4")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax5)
                .HasColumnName("XTAX5")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax6)
                .HasColumnName("XTAX6")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax7)
                .HasColumnName("XTAX7")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax8)
                .HasColumnName("XTAX8")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Xtax9)
                .HasColumnName("XTAX9")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
