namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MemTrxGroupDtls
{
    public string? TrxGroupCode { get; set; }
    public string? TrxCode { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? Resort { get; set; }
    public string? ChainCode { get; set; }

    public virtual MemTrxGroup MemTrxGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemTrxGroupDtls>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MEM_TRX_GROUP_DTLS");

            entity.HasIndex(e => new { e.ChainCode, e.TrxGroupCode, e.TrxCode, e.Resort })
                .HasName("MEM_TRX_GROUP_DTLS_UK")
                .IsUnique();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxGroupCode)
                .IsRequired()
                .HasColumnName("TRX_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(MemTrxGroup)))
				entity.Ignore(e => e.MemTrxGroup);
			else
	            entity.HasOne(d => d.MemTrxGroup)
	                .WithMany()
	                .HasForeignKey(d => new { d.ChainCode, d.TrxGroupCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEM_TRX_GROUP_FK");
        });
	}
}
