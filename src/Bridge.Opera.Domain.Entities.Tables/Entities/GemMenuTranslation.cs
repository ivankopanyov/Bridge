namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemMenuTranslation
{
    public decimal MenuId { get; set; }
    public string Language { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

    public virtual GemMenu Menu { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuTranslation>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.Language, e.Field })
                .HasName("MENT_PK");

            entity.ToTable("GEM$MENU_TRANSLATION");

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
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

			if (!types.Contains(typeof(GemMenu)))
				entity.Ignore(e => e.Menu);
			else
	            entity.HasOne(d => d.Menu)
	                .WithMany(p => p.GemMenuTranslation)
	                .HasForeignKey(d => d.MenuId)
	                .HasConstraintName("MENT_MEN_FK");
        });
	}
}
