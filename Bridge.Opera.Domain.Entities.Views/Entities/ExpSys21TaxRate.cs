namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21TaxRate
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Percentage { get; set; }
    public string TrxCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21TaxRate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_TAX_RATE");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
