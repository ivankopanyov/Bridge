namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PlantItemsAttachments
{
    public string Resort { get; set; }
    public string PlantItemCode { get; set; }
    public string AttachmentName { get; set; }
    public string AttachmentPath { get; set; }
    public string AdditionalInfo { get; set; }
    public string ApplicationToOpen { get; set; }

    public virtual PlantItems PlantItems { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PlantItemsAttachments>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AttachmentName, e.PlantItemCode })
                .HasName("PLANT_ITEMS_ATTACHMENTS_PK");

            entity.ToTable("PLANT_ITEMS_ATTACHMENTS");

            entity.HasIndex(e => new { e.Resort, e.PlantItemCode })
                .HasName("PIA_PI_FK_I");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttachmentName)
                .HasColumnName("ATTACHMENT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PlantItemCode)
                .HasColumnName("PLANT_ITEM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AdditionalInfo)
                .HasColumnName("ADDITIONAL_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ApplicationToOpen)
                .HasColumnName("APPLICATION_TO_OPEN")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AttachmentPath)
                .HasColumnName("ATTACHMENT_PATH")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(PlantItems)))
				entity.Ignore(e => e.PlantItems);
			else
	            entity.HasOne(d => d.PlantItems)
	                .WithMany(p => p.PlantItemsAttachments)
	                .HasForeignKey(d => new { d.Resort, d.PlantItemCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PIA_PI_FK");
        });
	}
}
