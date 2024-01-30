namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RfmScoreDetails
{
    public decimal? RfmScoreDtlId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? RfmScoreHdrId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? NameScore { get; set; }
    public string? ProcessingMessage { get; set; }
    public DateTime? ProcessingDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RfmScoreDetails>(entity =>
        {
            entity.HasKey(e => e.RfmScoreDtlId)
                .HasName("RFM_SCORE_DETAILS_PK");

            entity.ToTable("RFM_SCORE_DETAILS");

            entity.HasIndex(e => new { e.RfmScoreHdrId, e.NameScore })
                .HasName("RFM_SCORE_DETAILS_IDX1");

            entity.HasIndex(e => new { e.NameId, e.RfmScoreHdrId, e.NameScore })
                .HasName("RFM_SCORE_DETAILS_IDX2");

            entity.Property(e => e.RfmScoreDtlId)
                .HasColumnName("RFM_SCORE_DTL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameScore)
                .HasColumnName("NAME_SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessingDate)
                .HasColumnName("PROCESSING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProcessingMessage)
                .HasColumnName("PROCESSING_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.RfmScoreHdrId)
                .HasColumnName("RFM_SCORE_HDR_ID")
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
