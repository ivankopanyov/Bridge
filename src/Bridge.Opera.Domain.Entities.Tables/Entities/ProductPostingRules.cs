namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProductPostingRules
{
    public decimal? PostingRuleId { get; set; }
    public string? Resort { get; set; }
    public string? Product { get; set; }
    public string? RType { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public string? TrxCode { get; set; }
    public string? TaxInclYn { get; set; }

    public virtual ResortProducts ResortProducts { get; set; }
    public virtual TrxCodes TrxCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProductPostingRules>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Product, e.RType, e.PostingRuleId })
                .HasName("PROD_POSTING_RULES_PK");

            entity.ToTable("PRODUCT_POSTING_RULES");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("POSTING_RULE_TRX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Product)
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RType)
                .HasColumnName("R_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PostingRuleId)
                .HasColumnName("POSTING_RULE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaxInclYn)
                .HasColumnName("TAX_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ResortProducts)))
				entity.Ignore(e => e.ResortProducts);
			else
	            entity.HasOne(d => d.ResortProducts)
	                .WithMany(p => p.ProductPostingRules)
	                .HasForeignKey(d => new { d.Resort, d.Product })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("POSTING_RULE_R_PRODUCTS_FK");

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.ProductPostingRules)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .HasConstraintName("POSTING_RULE_TRX_FK");
        });
	}
}
