namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailTags
{
    public decimal SourceId { get; set; }
    public string Tag { get; set; }
    public string TableName { get; set; }
    public string FieldName { get; set; }

    public virtual MailSource Source { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailTags>(entity =>
        {
            entity.HasKey(e => new { e.Tag, e.SourceId })
                .HasName("MAIL_TAGS_PK");

            entity.ToTable("MAIL_TAGS");

            entity.HasIndex(e => new { e.SourceId, e.TableName, e.FieldName })
                .HasName("MAIL_TAGS_UK")
                .IsUnique();

            entity.Property(e => e.Tag)
                .HasColumnName("TAG")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

			if (!types.Contains(typeof(MailSource)))
				entity.Ignore(e => e.Source);
			else
	            entity.HasOne(d => d.Source)
	                .WithMany(p => p.MailTags)
	                .HasForeignKey(d => d.SourceId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MAILTAGS_MAILSOURCE_FK");
        });
	}
}
