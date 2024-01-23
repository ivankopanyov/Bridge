namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaxGeneratesView
{
    public string Resort { get; set; }
    public decimal? Id { get; set; }
    public decimal? SeqNo { get; set; }
    public decimal? CalculationSequence { get; set; }
    public string TrxCode { get; set; }
    public string AmountFromScheduleYn { get; set; }
    public decimal? Percentage { get; set; }
    public decimal? Amount { get; set; }
    public string UdfFunction { get; set; }
    public bool? PercentageBaseCode { get; set; }
    public string ResultIncludedInSumArray { get; set; }
    public string TcrType { get; set; }
    public string TrxCodeGenerator { get; set; }
    public string TcSubgroupGenerator { get; set; }
    public string TcGroupGenerator { get; set; }
    public string TclCodeGenerator { get; set; }
    public decimal? StopDays { get; set; }
    public string AdjustmnetType { get; set; }
    public string GeneratedPrintedOnFolioYn { get; set; }
    public string UdfInverse { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaxGeneratesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TAX_GENERATES_VIEW");

            entity.Property(e => e.AdjustmnetType)
                .HasColumnName("ADJUSTMNET_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountFromScheduleYn)
                .HasColumnName("AMOUNT_FROM_SCHEDULE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CalculationSequence)
                .HasColumnName("CALCULATION_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GeneratedPrintedOnFolioYn)
                .HasColumnName("GENERATED_PRINTED_ON_FOLIO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercentageBaseCode).HasColumnName("PERCENTAGE_BASE_CODE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResultIncludedInSumArray)
                .HasColumnName("RESULT_INCLUDED_IN_SUM_ARRAY")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StopDays)
                .HasColumnName("STOP_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TcGroupGenerator)
                .HasColumnName("TC_GROUP_GENERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroupGenerator)
                .HasColumnName("TC_SUBGROUP_GENERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TclCodeGenerator)
                .HasColumnName("TCL_CODE_GENERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcrType)
                .HasColumnName("TCR_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCodeGenerator)
                .HasColumnName("TRX_CODE_GENERATOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UdfFunction)
                .HasColumnName("UDF_FUNCTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UdfInverse)
                .HasColumnName("UDF_INVERSE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
