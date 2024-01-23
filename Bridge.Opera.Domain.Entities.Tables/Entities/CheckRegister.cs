namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CheckRegister
{
    public decimal AccountId { get; set; }
    public decimal BatchId { get; set; }
    public decimal? CheckAmt { get; set; }
    public DateTime? CheckDate { get; set; }
    public decimal? CheckNo { get; set; }
    public string ChkCurrency { get; set; }
    public decimal? ExchangeRate { get; set; }
    public string Status { get; set; }
    public string ClearedYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? TaPaymentId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string Resort { get; set; }
    public decimal? VatAmt { get; set; }
    public decimal? MicrNo { get; set; }
    public decimal? VatPercnt { get; set; }
    public decimal? TotalCheckAmt { get; set; }
    public decimal? FcTotalCheckAmt { get; set; }
    public string EftFileName { get; set; }
    public DateTime? ActionDate { get; set; }
    public string PositivePayStatus { get; set; }
    public DateTime? PositivePayDate { get; set; }
    public string FailedYn { get; set; }

    public virtual CommissionPayments TaPayment { get; set; }
    public virtual Name TravelAgent { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CheckRegister>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CHECK_REGISTER");

            entity.HasIndex(e => e.BatchId)
                .HasName("CHECK_REGISTER_BATCHID_IDX");

            entity.HasIndex(e => e.TravelAgentId)
                .HasName("CHECK_REGISTER_IDX2");

            entity.HasIndex(e => new { e.TaPaymentId, e.TravelAgentId, e.Resort })
                .HasName("TA_PAYMENT_IDX");

            entity.HasIndex(e => new { e.Resort, e.AccountId, e.Status, e.ClearedYn })
                .HasName("CHECK_REGISTER_IDX");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDate)
                .HasColumnName("ACTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckAmt)
                .HasColumnName("CHECK_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CheckDate)
                .HasColumnName("CHECK_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CheckNo)
                .HasColumnName("CHECK_NO")
                .HasColumnType("NUMBER(20)");

            entity.Property(e => e.ChkCurrency)
                .HasColumnName("CHK_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClearedYn)
                .HasColumnName("CLEARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EftFileName)
                .HasColumnName("EFT_FILE_NAME")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FailedYn)
                .HasColumnName("FAILED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FcTotalCheckAmt)
                .HasColumnName("FC_TOTAL_CHECK_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MicrNo)
                .HasColumnName("MICR_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PositivePayDate)
                .HasColumnName("POSITIVE_PAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PositivePayStatus)
                .HasColumnName("POSITIVE_PAY_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TaPaymentId)
                .HasColumnName("TA_PAYMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCheckAmt)
                .HasColumnName("TOTAL_CHECK_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VatAmt)
                .HasColumnName("VAT_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VatPercnt)
                .HasColumnName("VAT_PERCNT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(CommissionPayments)))
				entity.Ignore(e => e.TaPayment);
			else
	            entity.HasOne(d => d.TaPayment)
	                .WithMany()
	                .HasForeignKey(d => d.TaPaymentId)
	                .HasConstraintName("CHECK_PAYMENT_ID");

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.TravelAgent);
			else
	            entity.HasOne(d => d.TravelAgent)
	                .WithMany()
	                .HasForeignKey(d => d.TravelAgentId)
	                .HasConstraintName("CHECK_NAME_FK");
        });
	}
}
