namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RfmNameCurrScore
{
    public string? ChainCode { get; set; }
    public string? RfmCode { get; set; }
    public decimal? NameId { get; set; }
    public decimal? RfmScoreDtlId { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RfmNameCurrScore>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RfmCode, e.NameId })
                .HasName("RFM_NAME_CURR_SCORE_PK");

            entity.ToTable("RFM_NAME_CURR_SCORE");

            entity.HasIndex(e => e.NameId)
                .HasName("RFM_NAME_CURR_SCORE_IDX1");

            entity.HasIndex(e => e.RfmScoreDtlId)
                .HasName("RFM_NAME_CURR_SCORE_IDX2");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RfmCode)
                .HasColumnName("RFM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RfmScoreDtlId)
                .HasColumnName("RFM_SCORE_DTL_ID")
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
