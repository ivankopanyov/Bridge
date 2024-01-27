namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ImMsgHdr
{
    public decimal RecordId { get; set; }
    public string Resort { get; set; }
    public string RefType { get; set; }
    public string RefCode { get; set; }
    public DateTime? ProcessStartTime { get; set; }
    public DateTime? ProcessEndTime { get; set; }
    public decimal? ProcessStartMillistime { get; set; }
    public decimal? ProcessEndMillistime { get; set; }
    public string Status { get; set; }
    public decimal? RequestId { get; set; }
    public decimal? RequestFailedCount { get; set; }
    public string RequestFailedCode { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ImMsgHdr>(entity =>
        {
            entity.HasKey(e => e.RecordId)
                .HasName("IM_MSG_HDR_PK");

            entity.ToTable("IM_MSG_HDR");

            entity.HasIndex(e => new { e.Resort, e.RefType, e.RefCode })
                .HasName("IM_MSG_HDR_IDX01");

            entity.HasIndex(e => new { e.Status, e.RefType, e.Resort })
                .HasName("IM_MSG_HDR_IDX02");

            entity.Property(e => e.RecordId)
                .HasColumnName("RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessEndMillistime)
                .HasColumnName("PROCESS_END_MILLISTIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessEndTime)
                .HasColumnName("PROCESS_END_TIME")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.ProcessStartMillistime)
                .HasColumnName("PROCESS_START_MILLISTIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessStartTime)
                .HasColumnName("PROCESS_START_TIME")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.RefCode)
                .IsRequired()
                .HasColumnName("REF_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RefType)
                .IsRequired()
                .HasColumnName("REF_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RequestFailedCode)
                .HasColumnName("REQUEST_FAILED_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RequestFailedCount)
                .HasColumnName("REQUEST_FAILED_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
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
