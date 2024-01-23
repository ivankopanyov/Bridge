namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxClassRelationships
{
    public decimal Id { get; set; }
    public string Resort { get; set; }
    public string TcGroup { get; set; }
    public string TcSubgroup { get; set; }
    public string TrxCode { get; set; }
    public string TcGroupGenerator { get; set; }
    public string TcSubgroupGenerator { get; set; }
    public string TrxCodeGenerator { get; set; }
    public string TclCodeGenerator { get; set; }
    public string TcrType { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Percentage { get; set; }
    public bool? PercentageBaseCode { get; set; }
    public string UdfFunction { get; set; }
    public decimal CalculationSequence { get; set; }
    public string AmountFromScheduleYn { get; set; }
    public string Currency { get; set; }
    public string ResultIncludedInSumArray { get; set; }
    public string GeneratedPrintedOnFolioYn { get; set; }
    public string NameTaxType { get; set; }
    public string UdfInverse { get; set; }
    public decimal? StopDays { get; set; }
    public string AdjustmentType { get; set; }
    public string UseTaxBracketYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual TcGroups TcGroups { get; set; }
    public virtual TrxClasses TrxClasses { get; set; }
    public virtual TrxCodes TrxCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxClassRelationships>(entity =>
        {
            entity.ToTable("TRX_CLASS_RELATIONSHIPS");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("TCR_TC_IDX");

            entity.HasIndex(e => new { e.Resort, e.TrxCodeGenerator })
                .HasName("TCR_CODEGENERATOR_IDX");

            entity.HasIndex(e => new { e.TcGroupGenerator, e.Resort })
                .HasName("TCR_TMG_IDX");

            entity.HasIndex(e => new { e.TclCodeGenerator, e.Resort })
                .HasName("TCR_TCL_FK_I");

            entity.HasIndex(e => new { e.TcGroup, e.TcSubgroup, e.TrxCode })
                .HasName("TCR_TC_FK_I");

            entity.HasIndex(e => new { e.TcGroupGenerator, e.TcSubgroupGenerator, e.TrxCodeGenerator })
                .HasName("TCR_TC_GENERATED_BY_FK_I");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AdjustmentType)
                .HasColumnName("ADJUSTMENT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AmountFromScheduleYn)
                .HasColumnName("AMOUNT_FROM_SCHEDULE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CalculationSequence)
                .HasColumnName("CALCULATION_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GeneratedPrintedOnFolioYn)
                .HasColumnName("GENERATED_PRINTED_ON_FOLIO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PercentageBaseCode)
                .HasColumnName("PERCENTAGE_BASE_CODE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResultIncludedInSumArray)
                .HasColumnName("RESULT_INCLUDED_IN_SUM_ARRAY")
                .HasColumnType("CHAR(5)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.StopDays)
                .HasColumnName("STOP_DAYS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TcGroup)
                .IsRequired()
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TcGroupGenerator)
                .HasColumnName("TC_GROUP_GENERATOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TcSubgroup)
                .IsRequired()
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TcSubgroupGenerator)
                .HasColumnName("TC_SUBGROUP_GENERATOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TclCodeGenerator)
                .HasColumnName("TCL_CODE_GENERATOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TcrType)
                .IsRequired()
                .HasColumnName("TCR_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCodeGenerator)
                .HasColumnName("TRX_CODE_GENERATOR")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UdfFunction)
                .HasColumnName("UDF_FUNCTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UdfInverse)
                .HasColumnName("UDF_INVERSE")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UseTaxBracketYn)
                .HasColumnName("USE_TAX_BRACKET_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.TrxClassRelationships)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TCR_TC_FK");

			if (!types.Contains(typeof(TcGroups)))
				entity.Ignore(e => e.TcGroups);
			else
	            entity.HasOne(d => d.TcGroups)
	                .WithMany(p => p.TrxClassRelationships)
	                .HasForeignKey(d => new { d.TcGroupGenerator, d.Resort })
	                .HasConstraintName("TCR_TMG_FK");

			if (!types.Contains(typeof(TrxClasses)))
				entity.Ignore(e => e.TrxClasses);
			else
	            entity.HasOne(d => d.TrxClasses)
	                .WithMany(p => p.TrxClassRelationships)
	                .HasForeignKey(d => new { d.TclCodeGenerator, d.Resort })
	                .HasConstraintName("TCR_TCL_FK");
        });
	}
}
