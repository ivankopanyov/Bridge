namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ComputedCommissions
{
    public string? Resort { get; set; }
    public decimal? PaymentId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? CommissionableRevenue { get; set; }
    public decimal? GrossCommAmt { get; set; }
    public decimal? PrepaidComm { get; set; }
    public decimal? ArAmount { get; set; }
    public decimal? VatAmount { get; set; }
    public string? CommStatus { get; set; }
    public string? CommissionHoldCode { get; set; }
    public string? CommissionHoldDesc { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? CommType { get; set; }
    public string? TaCommCode { get; set; }
    public string? ManualEditYn { get; set; }
    public string? PayeeType { get; set; }
    public string? ManualResvYn { get; set; }
    public string? Remarks { get; set; }
    public string? PpdRemarks { get; set; }
    public string? PpdEditYn { get; set; }
    public decimal? DecimalPositions { get; set; }
    public decimal? ExchangeRate { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public string? CommCodeDiffYn { get; set; }
    public DateTime? Departure { get; set; }
    public string? AdjustmentNote { get; set; }
    public string? ArYn { get; set; }
    public string? TaxFileStatus { get; set; }
    public DateTime? TaxFileDate { get; set; }
    public string? OwnerCommProcessedYn { get; set; }
    public decimal? CommissionId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }

    public virtual CommissionPayments Payment { get; set; }
    public virtual Name TravelAgent { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ComputedCommissions>(entity =>
        {
            entity.HasKey(e => e.CommissionId)
                .HasName("COMPUTED_COMMISSIONS_PK");

            entity.ToTable("COMPUTED_COMMISSIONS");

            entity.HasIndex(e => e.PaymentId)
                .HasName("PAYMENT_ID_FK_I");

            entity.HasIndex(e => new { e.Departure, e.Resort })
                .HasName("CC_DEPARTURE");

            entity.HasIndex(e => new { e.TravelAgentId, e.Resort })
                .HasName("RESORT_TA_COMMISSIONS_");

            entity.HasIndex(e => new { e.CommStatus, e.Resort, e.TravelAgentId })
                .HasName("CC_COMM_STATUS");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.TravelAgentId, e.BeginDate, e.EndDate })
                .HasName("COMPUTED_COMMISSIONS_UK")
                .IsUnique();

            entity.Property(e => e.CommissionId)
                .HasColumnName("COMMISSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustmentNote)
                .HasColumnName("ADJUSTMENT_NOTE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ArAmount)
                .HasColumnName("AR_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArYn)
                .HasColumnName("AR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CommCodeDiffYn)
                .HasColumnName("COMM_CODE_DIFF_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.CommStatus)
                .HasColumnName("COMM_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.CommType)
                .HasColumnName("COMM_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CommissionHoldCode)
                .HasColumnName("COMMISSION_HOLD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionHoldDesc)
                .HasColumnName("COMMISSION_HOLD_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CommissionableRevenue)
                .HasColumnName("COMMISSIONABLE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DecimalPositions)
                .HasColumnName("DECIMAL_POSITIONS")
                .HasColumnType("NUMBER(30)");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GrossCommAmt)
                .HasColumnName("GROSS_COMM_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ManualEditYn)
                .HasColumnName("MANUAL_EDIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ManualResvYn)
                .HasColumnName("MANUAL_RESV_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OwnerCommProcessedYn)
                .HasColumnName("OWNER_COMM_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PayeeType)
                .HasColumnName("PAYEE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PaymentId)
                .HasColumnName("PAYMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PpdEditYn)
                .HasColumnName("PPD_EDIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PpdRemarks)
                .HasColumnName("PPD_REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrepaidComm)
                .HasColumnName("PREPAID_COMM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaCommCode)
                .HasColumnName("TA_COMM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxFileDate)
                .HasColumnName("TAX_FILE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TaxFileStatus)
                .HasColumnName("TAX_FILE_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VatAmount)
                .HasColumnName("VAT_AMOUNT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(CommissionPayments)))
				entity.Ignore(e => e.Payment);
			else
	            entity.HasOne(d => d.Payment)
	                .WithMany(p => p.ComputedCommissions)
	                .HasForeignKey(d => d.PaymentId)
	                .HasConstraintName("PAYMENT_ID_FK");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.TravelAgent);
			else
	            entity.HasOne(d => d.TravelAgent)
	                .WithMany(p => p.ComputedCommissions)
	                .HasForeignKey(d => d.TravelAgentId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("COMMISSION_NAME_FK");
        });
	}
}
