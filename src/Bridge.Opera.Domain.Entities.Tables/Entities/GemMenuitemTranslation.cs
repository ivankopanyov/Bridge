namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemMenuitemTranslation
{
    public string? Resort { get; set; }
    public decimal? MitId { get; set; }
    public string? Language { get; set; }
    public string? Field { get; set; }
    public string? Text { get; set; }

    public virtual GemMenuitem GemMenuitem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuitemTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.MitId, e.Language, e.Field })
                .HasName("GMIT_PK");

            entity.ToTable("GEM$MENUITEM_TRANSLATION");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemMenuitem)))
				entity.Ignore(e => e.GemMenuitem);
			else
	            entity.HasOne(d => d.GemMenuitem)
	                .WithMany(p => p.GemMenuitemTranslation)
	                .HasForeignKey(d => new { d.Resort, d.MitId })
	                .HasConstraintName("GMIT_MIT_FK");
        });
	}
}
