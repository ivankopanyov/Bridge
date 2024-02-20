namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FiscalFolioTax
{
    public string? Resort { get; set; }
    public string? BillNo { get; set; }
    public string? FolioType { get; set; }
    public string? QueueName { get; set; }
    public string? Status { get; set; }
    public string? MessageText { get; set; }
    public string? BillGenerationDate { get; set; }
    public string? TotalGrossAmount { get; set; }
    public string? TotalNetAmount { get; set; }
    public string? Tax1Amt { get; set; }
    public string? Tax2Amt { get; set; }
    public string? Tax3Amt { get; set; }
    public string? Tax4Amt { get; set; }
    public string? Tax5Amt { get; set; }
    public string? Tax6Amt { get; set; }
    public string? Tax7Amt { get; set; }
    public string? Tax8Amt { get; set; }
    public string? Tax9Amt { get; set; }
    public string? Tax10Amt { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? FiscalBillNo { get; set; }
    public string? CollTax1 { get; set; }
    public string? CollTax2 { get; set; }
    public string? CollTax3 { get; set; }
    public string? CollTax4 { get; set; }
    public string? CollTax5 { get; set; }
    public decimal? PageNumber { get; set; }
    public string? Tax11Amt { get; set; }
    public string? Tax12Amt { get; set; }
    public string? Tax13Amt { get; set; }
    public string? Tax14Amt { get; set; }
    public string? Tax15Amt { get; set; }
    public string? Tax16Amt { get; set; }
    public string? Tax17Amt { get; set; }
    public string? Tax18Amt { get; set; }
    public string? Tax19Amt { get; set; }
    public string? Tax20Amt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FiscalFolioTax>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FISCAL_FOLIO_TAX");

            entity.HasIndex(e => new { e.Resort, e.FolioType, e.FiscalBillNo })
                .HasName("FISCAL_FOLIO_TAX_IND");

            entity.Property(e => e.BillGenerationDate)
                .HasColumnName("BILL_GENERATION_DATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CollTax1)
                .HasColumnName("COLL_TAX1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CollTax2)
                .HasColumnName("COLL_TAX2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CollTax3)
                .HasColumnName("COLL_TAX3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CollTax4)
                .HasColumnName("COLL_TAX4")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CollTax5)
                .HasColumnName("COLL_TAX5")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FiscalBillNo)
                .HasColumnName("FISCAL_BILL_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MessageText)
                .HasColumnName("MESSAGE_TEXT")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.PageNumber)
                .HasColumnName("PAGE_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.QueueName)
                .HasColumnName("QUEUE_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax10Amt)
                .HasColumnName("TAX10_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax11Amt)
                .HasColumnName("TAX11_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax12Amt)
                .HasColumnName("TAX12_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax13Amt)
                .HasColumnName("TAX13_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax14Amt)
                .HasColumnName("TAX14_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax15Amt)
                .HasColumnName("TAX15_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax16Amt)
                .HasColumnName("TAX16_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax17Amt)
                .HasColumnName("TAX17_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax18Amt)
                .HasColumnName("TAX18_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax19Amt)
                .HasColumnName("TAX19_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax1Amt)
                .HasColumnName("TAX1_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax20Amt)
                .HasColumnName("TAX20_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax2Amt)
                .HasColumnName("TAX2_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax3Amt)
                .HasColumnName("TAX3_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax4Amt)
                .HasColumnName("TAX4_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax5Amt)
                .HasColumnName("TAX5_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax6Amt)
                .HasColumnName("TAX6_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax7Amt)
                .HasColumnName("TAX7_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax8Amt)
                .HasColumnName("TAX8_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tax9Amt)
                .HasColumnName("TAX9_AMT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalGrossAmount)
                .HasColumnName("TOTAL_GROSS_AMOUNT")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TotalNetAmount)
                .HasColumnName("TOTAL_NET_AMOUNT")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
