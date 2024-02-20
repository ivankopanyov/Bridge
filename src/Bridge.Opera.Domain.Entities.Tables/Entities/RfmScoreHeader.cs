namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RfmScoreHeader
{
    public decimal? RfmScoreHdrId { get; set; }
    public string? ChainCode { get; set; }
    public string? RfmCode { get; set; }
    public string? RfmFormula { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ProcessingMessage { get; set; }
    public DateTime? ProcessingDate { get; set; }
    public DateTime? EvaluationDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RfmScoreHeader>(entity =>
        {
            entity.HasKey(e => e.RfmScoreHdrId)
                .HasName("RFM_SCORE_HEADER_PK");

            entity.ToTable("RFM_SCORE_HEADER");

            entity.HasIndex(e => new { e.ChainCode, e.RfmCode })
                .HasName("RFM_SCORE_HEADER_IDX1");

            entity.Property(e => e.RfmScoreHdrId)
                .HasColumnName("RFM_SCORE_HDR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EvaluationDate)
                .HasColumnName("EVALUATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessingDate)
                .HasColumnName("PROCESSING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProcessingMessage)
                .HasColumnName("PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.RfmCode)
                .IsRequired()
                .HasColumnName("RFM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RfmFormula)
                .IsRequired()
                .HasColumnName("RFM_FORMULA")
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
