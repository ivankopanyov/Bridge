namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemrTranslation
{
    public decimal? ItemrateId { get; set; }
    public string? Language { get; set; }
    public string? Field { get; set; }
    public string? Text { get; set; }

    public virtual GemItemRates Itemrate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemrTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ItemrateId, e.Language, e.Field })
                .HasName("ITMRT_PK");

            entity.ToTable("GEM$ITEMR_TRANSLATION");

            entity.Property(e => e.ItemrateId)
                .HasColumnName("ITEMRATE_ID")
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

			if (!types.Contains(typeof(GemItemRates)))
				entity.Ignore(e => e.Itemrate);
			else
	            entity.HasOne(d => d.Itemrate)
	                .WithMany(p => p.GemItemrTranslation)
	                .HasForeignKey(d => d.ItemrateId)
	                .HasConstraintName("ITMRT_ITMR_FK");
        });
	}
}
