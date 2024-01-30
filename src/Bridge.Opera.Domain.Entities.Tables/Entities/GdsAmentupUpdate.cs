namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsAmentupUpdate
{
    public string? Resort { get; set; }
    public string? AmenityCode { get; set; }
    public string? AmenityCodeIdentifier { get; set; }
    public string? AmenityCodeFlag { get; set; }
    public decimal? PropupId { get; set; }
    public string? GdsHost { get; set; }

    public virtual GdsPropupUpdate Propup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAmentupUpdate>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AmenityCode, e.AmenityCodeIdentifier })
                .HasName("GDS_AMENTUP_UPDATE_PK");

            entity.ToTable("GDS_AMENTUP_UPDATE");

            entity.HasIndex(e => e.PropupId)
                .HasName("GDS_AMENTUP_UPDATE_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AmenityCode)
                .HasColumnName("AMENITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AmenityCodeIdentifier)
                .HasColumnName("AMENITY_CODE_IDENTIFIER")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AmenityCodeFlag)
                .IsRequired()
                .HasColumnName("AMENITY_CODE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .IsRequired()
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropupId)
                .HasColumnName("PROPUP_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsPropupUpdate)))
				entity.Ignore(e => e.Propup);
			else
	            entity.HasOne(d => d.Propup)
	                .WithMany(p => p.GdsAmentupUpdate)
	                .HasForeignKey(d => d.PropupId)
	                .HasConstraintName("GDS_AMENTUP_UPDATE_FK1");
        });
	}
}
