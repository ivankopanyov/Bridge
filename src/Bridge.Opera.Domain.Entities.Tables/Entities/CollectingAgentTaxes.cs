namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CollectingAgentTaxes
{
    public string? Resort { get; set; }
    public decimal? TaxCodeSeq { get; set; }
    public decimal? Percentage { get; set; }
    public decimal? TriggerAmount { get; set; }
    public decimal? TaxVoid { get; set; }
    public string? TrxCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? CollectionBillingInstrnCode { get; set; }
    public string? CollectionTrxCode { get; set; }
    public string? TaxType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CollectingAgentTaxes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("COLLECTING$_AGENT_TAXES");

            entity.HasIndex(e => new { e.Resort, e.TaxCodeSeq, e.TaxType })
                .HasName("COLL_AGENT_TAXES_IDX1");

            entity.Property(e => e.CollectionBillingInstrnCode)
                .HasColumnName("COLLECTION_BILLING_INSTRN_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CollectionTrxCode)
                .HasColumnName("COLLECTION_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxCodeSeq)
                .HasColumnName("TAX_CODE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaxType)
                .HasColumnName("TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxVoid)
                .HasColumnName("TAX_VOID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TriggerAmount)
                .HasColumnName("TRIGGER_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
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
