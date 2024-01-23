namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CurrencyExchDiffCodesVw
{
    public string Code { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CurrencyExchDiffCodesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CURRENCY_EXCH_DIFF_CODES_VW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
