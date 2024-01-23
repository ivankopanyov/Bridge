namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationCancelPolicy
{
    public decimal ResvCancelPolicyId { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public decimal? PercCancel { get; set; }
    public DateTime? CancelDate { get; set; }
    public decimal? PercDue { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? CancelAmount { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public string ProcessedYn { get; set; }
    public string ExternalId { get; set; }
    public decimal? ForeignCancelAmount { get; set; }
    public string ExchangeRateInfo { get; set; }
    public string ManualYn { get; set; }
    public decimal? RateDcSeq { get; set; }
    public string RuleCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationCancelPolicy>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.ResvCancelPolicyId })
                .HasName("RESERVATION_CANCEL_POLICY_PK");

            entity.ToTable("RESERVATION_CANCEL_POLICY");

            entity.HasIndex(e => e.ExternalId)
                .HasName("RESV_CANCELLATION_IDX1");

            entity.HasIndex(e => e.ResvCancelPolicyId)
                .HasName("RESERVATION_CAN_POL_UK")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvCancelPolicyId)
                .HasColumnName("RESV_CANCEL_POLICY_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancelAmount)
                .HasColumnName("CANCEL_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CancelDate)
                .HasColumnName("CANCEL_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

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

            entity.Property(e => e.ForeignCancelAmount)
                .HasColumnName("FOREIGN_CANCEL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ManualYn)
                .HasColumnName("MANUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PercCancel)
                .HasColumnName("PERC_CANCEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PercDue)
                .HasColumnName("PERC_DUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessedYn)
                .HasColumnName("PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateDcSeq)
                .HasColumnName("RATE_DC_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
