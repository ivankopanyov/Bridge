namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExcludeTrxCodesView
{
    public string Resort { get; set; }
    public string TrxCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExcludeTrxCodesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXCLUDE_TRX_CODES_VIEW");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
