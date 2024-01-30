namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21ClCreditCard
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? TransId { get; set; }
    public decimal? EntryAmount { get; set; }
    public string? AccountingId { get; set; }
    public string? EntryType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21ClCreditCard>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_CL_CREDIT_CARD");

            entity.Property(e => e.AccountingId)
                .HasColumnName("ACCOUNTING_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EntryAmount)
                .HasColumnName("ENTRY_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EntryType)
                .HasColumnName("ENTRY_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransId)
                .HasColumnName("TRANS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
