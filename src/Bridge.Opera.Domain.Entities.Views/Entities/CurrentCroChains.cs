namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CurrentCroChains
{
    public string? ChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CurrentCroChains>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CURRENT_CRO_CHAINS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .IsUnicode(false);
        });
	}
}
