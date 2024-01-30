namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SfaChains
{
    public string? SfaCode { get; set; }
    public string? ChainCode { get; set; }
    public string? DefaultYn { get; set; }

    public virtual Resort SfaCodeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SfaChains>(entity =>
        {
            entity.HasKey(e => new { e.SfaCode, e.ChainCode })
                .HasName("SFACHAIN_PK");

            entity.ToTable("SFA_CHAINS");

            entity.Property(e => e.SfaCode)
                .HasColumnName("SFA_CODE")
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
				entity.Ignore(e => e.SfaCodeNavigation);
			else
	            entity.HasOne(d => d.SfaCodeNavigation)
	                .WithMany(p => p.SfaChains)
	                .HasForeignKey(d => d.SfaCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("SFACH_RESORT_FK");
        });
	}
}
