namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RfmScoreVw
{
    public decimal? RfmScoreHdrId { get; set; }
    public string? ChainCode { get; set; }
    public string? RfmCode { get; set; }
    public string? RfmFormula { get; set; }
    public string? HdrProcessingMessage { get; set; }
    public DateTime? HdrProcessingDate { get; set; }
    public DateTime? EvaluationDate { get; set; }
    public decimal? RfmScoreDtlId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? NameScore { get; set; }
    public string? DtlProcessingMessage { get; set; }
    public DateTime? DtlProcessingDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RfmScoreVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RFM_SCORE_VW");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DtlProcessingDate)
                .HasColumnName("DTL_PROCESSING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DtlProcessingMessage)
                .HasColumnName("DTL_PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.EvaluationDate)
                .HasColumnName("EVALUATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HdrProcessingDate)
                .HasColumnName("HDR_PROCESSING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HdrProcessingMessage)
                .HasColumnName("HDR_PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameScore)
                .HasColumnName("NAME_SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RfmCode)
                .IsRequired()
                .HasColumnName("RFM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RfmFormula)
                .IsRequired()
                .HasColumnName("RFM_FORMULA")
                .IsUnicode(false);

            entity.Property(e => e.RfmScoreDtlId)
                .HasColumnName("RFM_SCORE_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RfmScoreHdrId)
                .HasColumnName("RFM_SCORE_HDR_ID")
                .HasColumnType("NUMBER");
        });
	}
}
