namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsAvailUpdMessage
{
    public string EchoToken { get; set; }
    public string GdsHost { get; set; }
    public string Resort { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string RateCode { get; set; }
    public string RoomCategory { get; set; }
    public string Status { get; set; }
    public string ErrorText { get; set; }
    public string ChainCode { get; set; }
    public string RestrictionType { get; set; }
    public decimal? Los { get; set; }
    public string LosDays { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? RetryCount { get; set; }
    public string ErrorCode { get; set; }
    public string SubCode { get; set; }
    public string OldEchoToken { get; set; }
    public string ResendYn { get; set; }
    public decimal? ResendCount { get; set; }
    public decimal AvhRequestId { get; set; }
    public DateTime UpdateDate { get; set; }
    public string AllotmentCode { get; set; }
    public decimal? RateTier { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAvailUpdMessage>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GDS_AVAIL_UPD_MESSAGE");

            entity.HasIndex(e => e.EchoToken)
                .HasName("GDS_AVAIL_UPD_MESSAGE_IND1");

            entity.HasIndex(e => new { e.Status, e.AvhRequestId })
                .HasName("GDS_AVAIL_UPD_MESSAGE_IND2");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.BeginDate, e.EndDate, e.RateCode, e.RoomCategory, e.EchoToken, e.RestrictionType })
                .HasName("GDS_AVAIL_UPD_MESSAGE_PK")
                .IsUnique();

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AvhRequestId)
                .HasColumnName("AVH_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EchoToken)
                .IsRequired()
                .HasColumnName("ECHO_TOKEN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ErrorCode)
                .HasColumnName("ERROR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorText)
                .HasColumnName("ERROR_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("TIMESTAMP(2)");

            entity.Property(e => e.Los)
                .HasColumnName("LOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LosDays)
                .HasColumnName("LOS_DAYS")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.OldEchoToken)
                .HasColumnName("OLD_ECHO_TOKEN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateTier)
                .HasColumnName("RATE_TIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResendCount)
                .HasColumnName("RESEND_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResendYn)
                .HasColumnName("RESEND_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RestrictionType)
                .IsRequired()
                .HasColumnName("RESTRICTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SubCode)
                .HasColumnName("SUB_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("TIMESTAMP(2)");
        });
	}
}
