namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaBankAccounts
{
    public string Resort { get; set; }
    public decimal AccountId { get; set; }
    public string AccountNo { get; set; }
    public string BankName { get; set; }
    public string Currency { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaBankAccounts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TA_BANK_ACCOUNTS");

            entity.Property(e => e.AccountId)
                .HasColumnName("ACCOUNT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountNo)
                .IsRequired()
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .HasColumnName("BANK_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
