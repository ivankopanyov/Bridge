namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SfaCurrencies
{
    public string? CurrencyCode { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SfaCurrencies>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SFA_CURRENCIES");

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
