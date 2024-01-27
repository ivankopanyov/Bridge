namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipTscHeader
{
    public decimal ReportId { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? OrderBy { get; set; }
    public string RecordType { get; set; }
    public string MembershipType { get; set; }
    public string ReportStatus { get; set; }
    public DateTime? EvalDate { get; set; }
    public string ReportLog { get; set; }
    public string ReportError { get; set; }
    public decimal? InsertUser { get; set; }
    public string ChainCode { get; set; }
    public decimal? RfmScoreHdrId { get; set; }
    public string ReQualifyYn { get; set; }
    public string TmrActiveYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipTscHeader>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.ReportId })
                .HasName("MEMBERSHIP_TSC_HDR_PK");

            entity.ToTable("MEMBERSHIP_TSC_HEADER");

            entity.HasIndex(e => e.RfmScoreHdrId)
                .HasName("MEMBERSHIP_TSC_HEADER_IDX1");

            entity.HasIndex(e => new { e.RecordType, e.ReportId })
                .HasName("MEM_TSC_HDR_REC_TYPE");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EvalDate)
                .HasColumnName("EVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReQualifyYn)
                .HasColumnName("RE_QUALIFY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .IsRequired()
                .HasColumnName("RECORD_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReportError)
                .HasColumnName("REPORT_ERROR")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReportLog)
                .HasColumnName("REPORT_LOG")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReportStatus)
                .IsRequired()
                .HasColumnName("REPORT_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RfmScoreHdrId)
                .HasColumnName("RFM_SCORE_HDR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TmrActiveYn)
                .HasColumnName("TMR_ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
