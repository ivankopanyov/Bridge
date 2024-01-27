namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidFolioType
{
    public string Resort { get; set; }
    public string FolioType { get; set; }
    public string NameTaxType { get; set; }
    public string ClFlag { get; set; }
    public string NationalityFlag { get; set; }
    public string LocalCurrFlag { get; set; }
    public string TaxNoFlag { get; set; }
    public string CreditFlag { get; set; }
    public string AllowConvertYn { get; set; }
    public string ConvertFolioType { get; set; }
    public string AllowCompressYn { get; set; }
    public string AllowCreditbillYn { get; set; }
    public string FolioName { get; set; }
    public string ArfolioName { get; set; }
    public string PasserbyfolioName { get; set; }
    public string QueueName { get; set; }
    public string CompressYn { get; set; }
    public string FiscalYn { get; set; }
    public string FiscalProgramName { get; set; }
    public string ColumnSeparator { get; set; }
    public string ManualFolioPrintTask { get; set; }
    public decimal? CurrActionId { get; set; }
    public decimal? GuestType { get; set; }
    public string TrxServiceType { get; set; }
    public string CorrectionFolioYn { get; set; }
    public string DebitFlag { get; set; }
    public string DepositFolioYn { get; set; }
    public string CorrectionHeaderYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidFolioType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_FOLIO$_TYPE");

            entity.Property(e => e.AllowCompressYn)
                .HasColumnName("ALLOW_COMPRESS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AllowConvertYn)
                .HasColumnName("ALLOW_CONVERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AllowCreditbillYn)
                .HasColumnName("ALLOW_CREDITBILL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArfolioName)
                .HasColumnName("ARFOLIO_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ClFlag)
                .HasColumnName("CL_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ColumnSeparator)
                .HasColumnName("COLUMN_SEPARATOR")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CompressYn)
                .HasColumnName("COMPRESS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConvertFolioType)
                .HasColumnName("CONVERT_FOLIO_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CorrectionFolioYn)
                .HasColumnName("CORRECTION_FOLIO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CorrectionHeaderYn)
                .HasColumnName("CORRECTION_HEADER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CreditFlag)
                .HasColumnName("CREDIT_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CurrActionId)
                .HasColumnName("CURR_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DebitFlag)
                .HasColumnName("DEBIT_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepositFolioYn)
                .HasColumnName("DEPOSIT_FOLIO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FiscalProgramName)
                .HasColumnName("FISCAL_PROGRAM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FiscalYn)
                .HasColumnName("FISCAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FolioName)
                .HasColumnName("FOLIO_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestType)
                .HasColumnName("GUEST_TYPE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocalCurrFlag)
                .HasColumnName("LOCAL_CURR_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ManualFolioPrintTask)
                .HasColumnName("MANUAL_FOLIO_PRINT_TASK")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NationalityFlag)
                .HasColumnName("NATIONALITY_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PasserbyfolioName)
                .HasColumnName("PASSERBYFOLIO_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.QueueName)
                .HasColumnName("QUEUE_NAME")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxNoFlag)
                .HasColumnName("TAX_NO_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TrxServiceType)
                .HasColumnName("TRX_SERVICE_TYPE")
                .HasMaxLength(5)
                .IsUnicode(false);
        });
	}
}
