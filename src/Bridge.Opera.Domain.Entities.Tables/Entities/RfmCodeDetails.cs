namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RfmCodeDetails
{
    public RfmCodeDetails()
    {
        RfmScoreCard = new HashSet<RfmScoreCard>();
    }

    public string? ChainCode { get; set; }
    public string? RfmCode { get; set; }
    public string? DetailCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? FormulaLabel { get; set; }
    public string? BasedOn { get; set; }
    public string? RevenueGroup { get; set; }

    public virtual RfmCodes RfmCodes { get; set; }
    public virtual ICollection<RfmScoreCard> RfmScoreCard { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RfmCodeDetails>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RfmCode, e.DetailCode })
                .HasName("RFM_CODE_DETAILS_PK");

            entity.ToTable("RFM_CODE_DETAILS");

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

            entity.Property(e => e.BasedOn)
                .IsRequired()
                .HasColumnName("BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormulaLabel)
                .IsRequired()
                .HasColumnName("FORMULA_LABEL")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueGroup)
                .HasColumnName("REVENUE_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RfmCodes)))
				entity.Ignore(e => e.RfmCodes);
			else
	            entity.HasOne(d => d.RfmCodes)
	                .WithMany(p => p.RfmCodeDetails)
	                .HasForeignKey(d => new { d.ChainCode, d.RfmCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RFM_DETAILS_HEADER_FK");
        
			if (!types.Contains(typeof(RfmScoreCard)))
				entity.Ignore(e => e.RfmScoreCard);
		});
	}
}
