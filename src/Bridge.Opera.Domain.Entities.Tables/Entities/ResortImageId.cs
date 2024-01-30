namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortImageId
{
    public string? Resort { get; set; }
    public decimal? BlobId { get; set; }
    public byte MapNo { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortImageId>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_IMAGE_ID");

            entity.HasIndex(e => e.Resort)
                .HasName("RESORT_IMAGE_IND1");

            entity.Property(e => e.BlobId)
                .HasColumnName("BLOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MapNo).HasColumnName("MAP_NO");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RI_RESORT_FK");
        });
	}
}
