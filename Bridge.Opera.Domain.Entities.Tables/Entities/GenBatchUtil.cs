namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GenBatchUtil
{
    public decimal SeqNo { get; set; }
    public string ReportId { get; set; }
    public string ReportType { get; set; }
    public string Resort { get; set; }
    public string OldGenval1 { get; set; }
    public string OldGenval2 { get; set; }
    public string OldGenval3 { get; set; }
    public string NewGenval1 { get; set; }
    public string NewGenval2 { get; set; }
    public string NewGenval3 { get; set; }
    public string Status { get; set; }
    public string ProcessingMsg { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GenBatchUtil>(entity =>
        {
            entity.HasKey(e => e.SeqNo)
                .HasName("GBL_PK");

            entity.ToTable("GEN_BATCH_UTIL");

            entity.HasIndex(e => e.ReportId)
                .HasName("GBL_IDX1");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewGenval1)
                .HasColumnName("NEW_GENVAL1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NewGenval2)
                .HasColumnName("NEW_GENVAL2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NewGenval3)
                .HasColumnName("NEW_GENVAL3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.OldGenval1)
                .HasColumnName("OLD_GENVAL1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OldGenval2)
                .HasColumnName("OLD_GENVAL2")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OldGenval3)
                .HasColumnName("OLD_GENVAL3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProcessingMsg)
                .HasColumnName("PROCESSING_MSG")
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .IsRequired()
                .HasColumnName("REPORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReportType)
                .HasColumnName("REPORT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
