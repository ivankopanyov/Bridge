namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxCodesCompXref
{
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public string CompTrxCode { get; set; }

    public virtual TrxCodes TrxCodes { get; set; }
    public virtual TrxCodes TrxCodesNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodesCompXref>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TrxCode, e.CompTrxCode })
                .HasName("TRXCXREF_PK");

            entity.ToTable("TRX$_CODES_COMP_XREF");

            entity.HasIndex(e => new { e.Resort, e.CompTrxCode })
                .HasName("TRXCXREF_COMPTRX_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompTrxCode)
                .HasColumnName("COMP_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.TrxCodesCompXrefTrxCodes)
	                .HasForeignKey(d => new { d.Resort, d.CompTrxCode })
	                .HasConstraintName("TRXCXREF_TC_FK2");

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodesNavigation);
			else
	            entity.HasOne(d => d.TrxCodesNavigation)
	                .WithMany(p => p.TrxCodesCompXrefTrxCodesNavigation)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .HasConstraintName("TRXCXREF_TC_FK1");
        });
	}
}
