namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipExtractLogs
{
    public decimal ExtractLogId { get; set; }
    public decimal MembershipId { get; set; }
    public decimal NameId { get; set; }
    public string MembershipType { get; set; }
    public string MembershipCardNo { get; set; }
    public string ExtractCode { get; set; }
    public DateTime? ExtractedDate { get; set; }
    public decimal? ExtractBatchId { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string FulfillmentDeliveryFlag { get; set; }
    public decimal? TscReportId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipExtractLogs>(entity =>
        {
            entity.HasKey(e => e.ExtractLogId)
                .HasName("MEMBERSHIP_EXTRACT_LOGS_PK");

            entity.ToTable("MEMBERSHIP_EXTRACT_LOGS");

            entity.HasIndex(e => e.MembershipId)
                .HasName("MEMBERSHIP_EXTRACT_LOGS_IDX1");

            entity.HasIndex(e => e.NameId)
                .HasName("MEMBERSHIP_EXTRACT_LOGS_IDX2");

            entity.Property(e => e.ExtractLogId)
                .HasColumnName("EXTRACT_LOG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtractBatchId)
                .HasColumnName("EXTRACT_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtractCode)
                .HasColumnName("EXTRACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtractedDate)
                .HasColumnName("EXTRACTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FulfillmentDeliveryFlag)
                .HasColumnName("FULFILLMENT_DELIVERY_FLAG")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipCardNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TscReportId)
                .HasColumnName("TSC_REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
