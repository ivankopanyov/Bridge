namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailView
{
    public decimal? SourceId { get; set; }
    public string? SourceType { get; set; }
    public decimal? ViewOrder { get; set; }
    public string? Description { get; set; }
    public string? CharColumn1 { get; set; }
    public string? NumberColumn1 { get; set; }

    public virtual MailSource Source { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailView>(entity =>
        {
            entity.HasKey(e => new { e.SourceId, e.SourceType })
                .HasName("MAILV_PK");

            entity.ToTable("MAIL_VIEW");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceType)
                .HasColumnName("SOURCE_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CharColumn1)
                .HasColumnName("CHAR_COLUMN1")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.NumberColumn1)
                .HasColumnName("NUMBER_COLUMN1")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ViewOrder)
                .HasColumnName("VIEW_ORDER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MailSource)))
				entity.Ignore(e => e.Source);
			else
	            entity.HasOne(d => d.Source)
	                .WithMany(p => p.MailView)
	                .HasForeignKey(d => d.SourceId)
	                .HasConstraintName("MAILV_MAILS_FK");
        });
	}
}
