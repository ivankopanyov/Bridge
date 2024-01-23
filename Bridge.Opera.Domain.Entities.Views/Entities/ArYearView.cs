namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArYearView
{
    public decimal AccountCode { get; set; }
    public string AccountName { get; set; }
    public string Month { get; set; }
    public decimal? Debits { get; set; }
    public decimal? Credits { get; set; }
    public decimal? Balance { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArYearView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AR_YEAR_VIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Credits)
                .HasColumnName("CREDITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Debits)
                .HasColumnName("DEBITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Month)
                .HasColumnName("MONTH")
                .IsUnicode(false);
        });
	}
}
