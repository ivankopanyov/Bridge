namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RevenueTypesTranslation
{
    public string RevType { get; set; }
    public string Language { get; set; }
    public string Description { get; set; }
    public string ChainCode { get; set; }

    public virtual RevenueTypes RevenueTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RevenueTypesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RevType, e.Language })
                .HasName("REVTT_PK");

            entity.ToTable("REVENUE$TYPES_TRANSLATION");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(RevenueTypes)))
				entity.Ignore(e => e.RevenueTypes);
			else
	            entity.HasOne(d => d.RevenueTypes)
	                .WithMany(p => p.RevenueTypesTranslation)
	                .HasForeignKey(d => new { d.ChainCode, d.RevType })
	                .HasConstraintName("REVTT_REVT_FK");
        });
	}
}
