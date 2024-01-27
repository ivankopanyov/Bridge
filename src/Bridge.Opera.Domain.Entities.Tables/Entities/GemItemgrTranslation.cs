namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemgrTranslation
{
    public decimal ItmgRateId { get; set; }
    public string Language { get; set; }
    public string Field { get; set; }
    public string Text { get; set; }

    public virtual GemItemgroupRates ItmgRate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemgrTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ItmgRateId, e.Language, e.Field })
                .HasName("ITMGRT_PK");

            entity.ToTable("GEM$ITEMGR_TRANSLATION");

            entity.Property(e => e.ItmgRateId)
                .HasColumnName("ITMG_RATE_ID")
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

			if (!types.Contains(typeof(GemItemgroupRates)))
				entity.Ignore(e => e.ItmgRate);
			else
	            entity.HasOne(d => d.ItmgRate)
	                .WithMany(p => p.GemItemgrTranslation)
	                .HasForeignKey(d => d.ItmgRateId)
	                .HasConstraintName("ITMGRT_ITGR_FK");
        });
	}
}
