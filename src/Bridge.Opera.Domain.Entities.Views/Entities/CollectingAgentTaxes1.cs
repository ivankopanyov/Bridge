namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CollectingAgentTaxes1
{
    public string? Resort { get; set; }
    public decimal? TaxCodeSeq { get; set; }
    public decimal? Percentage { get; set; }
    public decimal? TriggerAmount { get; set; }
    public decimal? TaxVoid { get; set; }
    public string? TrxCode { get; set; }
    public string? TaxType { get; set; }
    public string? CodeBillInstDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CollectingAgentTaxes1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COLLECTING_AGENT_TAXES");

            entity.Property(e => e.CodeBillInstDesc)
                .HasColumnName("CODE_BILL_INST_DESC")
                .IsUnicode(false);

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
        });
	}
}
