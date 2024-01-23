namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RevenueTypesDetails
{
    public string RevType { get; set; }
    public string ChainCode { get; set; }
    public string Resort { get; set; }
    public decimal? Vat { get; set; }
    public string ContributeMinRevenueYn { get; set; }

    public virtual RevenueTypes RevenueTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RevenueTypesDetails>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RevType, e.Resort })
                .HasName("REVTD_PK");

            entity.ToTable("REVENUE$TYPES$DETAILS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContributeMinRevenueYn)
                .HasColumnName("CONTRIBUTE_MIN_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Vat)
                .HasColumnName("VAT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RevenueTypes)))
				entity.Ignore(e => e.RevenueTypes);
			else
	            entity.HasOne(d => d.RevenueTypes)
	                .WithMany(p => p.RevenueTypesDetails)
	                .HasForeignKey(d => new { d.ChainCode, d.RevType })
	                .HasConstraintName("REVTD_REVT_FK");
        });
	}
}
