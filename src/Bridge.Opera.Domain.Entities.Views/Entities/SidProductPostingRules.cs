namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidProductPostingRules
{
    public decimal PostingRuleId { get; set; }
    public string Resort { get; set; }
    public string Product { get; set; }
    public string RType { get; set; }
    public string TcGroup { get; set; }
    public string TcSubgroup { get; set; }
    public string TrxCode { get; set; }
    public string TaxInclYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidProductPostingRules>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_PRODUCT_POSTING_RULES");

            entity.Property(e => e.PostingRuleId)
                .HasColumnName("POSTING_RULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Product)
                .IsRequired()
                .HasColumnName("PRODUCT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RType)
                .IsRequired()
                .HasColumnName("R_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxInclYn)
                .HasColumnName("TAX_INCL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
