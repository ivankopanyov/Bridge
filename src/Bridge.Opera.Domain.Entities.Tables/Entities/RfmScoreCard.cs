namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RfmScoreCard
{
    public string ChainCode { get; set; }
    public string RfmCode { get; set; }
    public string DetailCode { get; set; }
    public decimal Score { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal ValueRequired { get; set; }

    public virtual RfmCodeDetails RfmCodeDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RfmScoreCard>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RfmCode, e.DetailCode, e.Score })
                .HasName("RFM_SCORE_CARD_PK");

            entity.ToTable("RFM_SCORE_CARD");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RfmCode)
                .HasColumnName("RFM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DetailCode)
                .HasColumnName("DETAIL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Score)
                .HasColumnName("SCORE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValueRequired)
                .HasColumnName("VALUE_REQUIRED")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RfmCodeDetails)))
				entity.Ignore(e => e.RfmCodeDetails);
			else
	            entity.HasOne(d => d.RfmCodeDetails)
	                .WithMany(p => p.RfmScoreCard)
	                .HasForeignKey(d => new { d.ChainCode, d.RfmCode, d.DetailCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RFM_SCORE_CARD_DETAILS_FK");
        });
	}
}
