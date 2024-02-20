namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemcTranslation
{
    public decimal? ItemclassId { get; set; }
    public string? Language { get; set; }
    public string? Field { get; set; }
    public string? Text { get; set; }

    public virtual GemItemClass Itemclass { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemcTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ItemclassId, e.Language, e.Field })
                .HasName("ITMCT_PK");

            entity.ToTable("GEM$ITEMC_TRANSLATION");

            entity.Property(e => e.ItemclassId)
                .HasColumnName("ITEMCLASS_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Field)
                .HasColumnName("FIELD")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Text)
                .HasColumnName("TEXT")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(GemItemClass)))
				entity.Ignore(e => e.Itemclass);
			else
	            entity.HasOne(d => d.Itemclass)
	                .WithMany(p => p.GemItemcTranslation)
	                .HasForeignKey(d => d.ItemclassId)
	                .HasConstraintName("ITMCT_ITMC_FK");
        });
	}
}
