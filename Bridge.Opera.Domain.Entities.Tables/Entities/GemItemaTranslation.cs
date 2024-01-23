namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemaTranslation
{
    public decimal ItmaId { get; set; }
    public string Language { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

    public virtual GemItemAttributes Itma { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemaTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ItmaId, e.Language, e.Field })
                .HasName("ITMAT_PK");

            entity.ToTable("GEM$ITEMA_TRANSLATION");

            entity.Property(e => e.ItmaId)
                .HasColumnName("ITMA_ID")
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

			if (!types.Contains(typeof(GemItemAttributes)))
				entity.Ignore(e => e.Itma);
			else
	            entity.HasOne(d => d.Itma)
	                .WithMany(p => p.GemItemaTranslation)
	                .HasForeignKey(d => d.ItmaId)
	                .HasConstraintName("ITMAT_ITMA_FK");
        });
	}
}
