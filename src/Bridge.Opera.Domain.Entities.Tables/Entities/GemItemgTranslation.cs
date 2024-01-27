namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemgTranslation
{
    public decimal ItemgroupId { get; set; }
    public string Language { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

    public virtual GemItemgroup Itemgroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemgTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ItemgroupId, e.Language, e.Field })
                .HasName("ITMGT_PK");

            entity.ToTable("GEM$ITEMG_TRANSLATION");

            entity.Property(e => e.ItemgroupId)
                .HasColumnName("ITEMGROUP_ID")
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

			if (!types.Contains(typeof(GemItemgroup)))
				entity.Ignore(e => e.Itemgroup);
			else
	            entity.HasOne(d => d.Itemgroup)
	                .WithMany(p => p.GemItemgTranslation)
	                .HasForeignKey(d => d.ItemgroupId)
	                .HasConstraintName("ITMGT_ITG_FK");
        });
	}
}
