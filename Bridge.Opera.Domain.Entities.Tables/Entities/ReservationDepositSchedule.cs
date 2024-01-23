namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationDepositSchedule
{
    public decimal ResvDepositScheduleId { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string ProductId { get; set; }
    public decimal? DepositAmount { get; set; }
    public DateTime? DepositDueDate { get; set; }
    public decimal? CancelPnltyAmount { get; set; }
    public DateTime? CancelDeadline { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public string Type { get; set; }
    public decimal? Percentage { get; set; }
    public string PaymentFlag { get; set; }
    public string Description { get; set; }
    public string ProcessedYn { get; set; }
    public decimal? ForeignDepositAmount { get; set; }
    public string ExchangeRateInfo { get; set; }
    public string RuleCode { get; set; }
    public decimal? RateDcSeq { get; set; }
    public decimal? RoomDeposit { get; set; }
    public decimal? ActivityDeposit { get; set; }
    public string ExternalId { get; set; }
    public string ManualYn { get; set; }
    public decimal? DepositReqReceiptNo { get; set; }
    public string DepositReqReversalYn { get; set; }
    public decimal? DepositReqLinkId { get; set; }
    public DateTime? TrxDate { get; set; }

    public virtual ReservationName Res { get; set; }
    public virtual ResortProducts ResortProducts { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationDepositSchedule>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.ResvDepositScheduleId })
                .HasName("RESERVATION_DEPOSIT_SCHEDUL_PK");

            entity.ToTable("RESERVATION_DEPOSIT_SCHEDULE");

            entity.HasIndex(e => e.ExternalId)
                .HasName("RESV_DEPOSIT_IDX1");

            entity.HasIndex(e => e.ResvDepositScheduleId)
                .HasName("RESERVATION_DEP_SCH_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.DepositDueDate })
                .HasName("RESV_DEPOSIT_DUE_DATE_I");

            entity.HasIndex(e => new { e.Resort, e.ProductId })
                .HasName("RESV_DEPOSIT_SCHEDULE_FK3_I");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvDepositScheduleId)
                .HasColumnName("RESV_DEPOSIT_SCHEDULE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActivityDeposit)
                .HasColumnName("ACTIVITY_DEPOSIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelDeadline)
                .HasColumnName("CANCEL_DEADLINE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelPnltyAmount)
                .HasColumnName("CANCEL_PNLTY_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositAmount)
                .HasColumnName("DEPOSIT_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepositDueDate)
                .HasColumnName("DEPOSIT_DUE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepositReqLinkId)
                .HasColumnName("DEPOSIT_REQ_LINK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepositReqReceiptNo)
                .HasColumnName("DEPOSIT_REQ_RECEIPT_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DepositReqReversalYn)
                .HasColumnName("DEPOSIT_REQ_REVERSAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(1000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangeRateInfo)
                .HasColumnName("EXCHANGE_RATE_INFO")
                .HasMaxLength(800)
                .IsUnicode(false);

            entity.Property(e => e.ExternalId)
                .HasColumnName("EXTERNAL_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ForeignDepositAmount)
                .HasColumnName("FOREIGN_DEPOSIT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ManualYn)
                .HasColumnName("MANUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PaymentFlag)
                .HasColumnName("PAYMENT_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ProcessedYn)
                .HasColumnName("PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateDcSeq)
                .HasColumnName("RATE_DC_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomDeposit)
                .HasColumnName("ROOM_DEPOSIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
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

			if (!types.Contains(typeof(ResortProducts)))
				entity.Ignore(e => e.ResortProducts);
			else
	            entity.HasOne(d => d.ResortProducts)
	                .WithMany(p => p.ReservationDepositSchedule)
	                .HasForeignKey(d => new { d.Resort, d.ProductId })
	                .HasConstraintName("RESV_DEPOSIT_SCHEDULE_FK3");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationDepositSchedule)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESV_DEPOSIT_SCHEDULE_FK1");
        });
	}
}
