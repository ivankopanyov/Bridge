namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRatingUpdate
{
    public string Resort { get; set; }
    public string Rating { get; set; }
    public decimal PropupId { get; set; }

    public virtual GdsPropupUpdate Propup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRatingUpdate>(entity =>
        {
            entity.HasKey(e => e.Resort)
                .HasName("GDS_RATING_UPDATE_PK");

            entity.ToTable("GDS_RATING_UPDATE");

            entity.HasIndex(e => e.PropupId)
                .HasName("GDS_RATING_UPDATE_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropupId)
                .HasColumnName("PROPUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Rating)
                .IsRequired()
                .HasColumnName("RATING")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(GdsPropupUpdate)))
				entity.Ignore(e => e.Propup);
			else
	            entity.HasOne(d => d.Propup)
	                .WithMany(p => p.GdsRatingUpdate)
	                .HasForeignKey(d => d.PropupId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GDS_RATING_UPDATE_FK1");
        });
	}
}
