namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemTranslation
{
    public string Resort { get; set; }
    public decimal ItemId { get; set; }
    public string Language { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

    public virtual GemItem GemItem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ItemId, e.Language, e.Field })
                .HasName("ITMT_PK");

            entity.ToTable("GEM$ITEM_TRANSLATION");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
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
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);
			else
	            entity.HasOne(d => d.GemItem)
	                .WithMany(p => p.GemItemTranslation)
	                .HasForeignKey(d => new { d.Resort, d.ItemId })
	                .HasConstraintName("ITMT_ITM_FK");
        });
	}
}
