namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScPkgTranslation
{
    public string Resort { get; set; }
    public decimal PkgId { get; set; }
    public string Language { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

    public virtual ScPackage Pkg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPkgTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.PkgId, e.Language, e.Field })
                .HasName("PKGTRANS_PK");

            entity.ToTable("SC$PKG_TRANSLATION");

            entity.HasIndex(e => e.Language)
                .HasName("PKGTRANS_LANG_IDX");

            entity.HasIndex(e => e.PkgId)
                .HasName("PKGTRANS_PKGID_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Field)
                .HasColumnName("FIELD")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(200)
                .IsUnicode(false);

			if (!types.Contains(typeof(ScPackage)))
				entity.Ignore(e => e.Pkg);
			else
	            entity.HasOne(d => d.Pkg)
	                .WithMany(p => p.ScPkgTranslation)
	                .HasForeignKey(d => d.PkgId)
	                .HasConstraintName("PKGTRANS_PKG_FK");
        });
	}
}
