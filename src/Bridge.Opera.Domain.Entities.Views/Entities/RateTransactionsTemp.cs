namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateTransactionsTemp
{
    public decimal? ReportId { get; set; }
    public string EntityType { get; set; }
    public string EntityValue { get; set; }
    public string TrxCode { get; set; }
    public string EntityValueDisp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateTransactionsTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_TRANSACTIONS_TEMP");

            entity.Property(e => e.EntityType)
                .HasColumnName("ENTITY_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EntityValue)
                .HasColumnName("ENTITY_VALUE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EntityValueDisp)
                .HasColumnName("ENTITY_VALUE_DISP")
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
