namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CroChains
{
    public string? CroCode { get; set; }
    public string? ChainCode { get; set; }
    public string? DefaultYn { get; set; }

    public virtual Resort CroCodeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CroChains>(entity =>
        {
            entity.HasKey(e => new { e.CroCode, e.ChainCode })
                .HasName("CROCHAIN_PK");

            entity.ToTable("CRO_CHAINS");

            entity.Property(e => e.CroCode)
                .HasColumnName("CRO_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.CroCodeNavigation);
			else
	            entity.HasOne(d => d.CroCodeNavigation)
	                .WithMany(p => p.CroChains)
	                .HasForeignKey(d => d.CroCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CROCH_RESORT_FK");
        });
	}
}
