namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SfaCroChains
{
    public string CroCode { get; set; }
    public string ChainCode { get; set; }
    public string DefaultYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SfaCroChains>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SFA_CRO_CHAINS");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CroCode)
                .IsRequired()
                .HasColumnName("CRO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
