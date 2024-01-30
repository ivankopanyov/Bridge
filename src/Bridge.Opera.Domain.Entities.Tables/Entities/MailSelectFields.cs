namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailSelectFields
{
    public decimal? ListId { get; set; }
    public string? TableName { get; set; }
    public string? FieldName { get; set; }
    public string? VirtualYn { get; set; }

    public virtual MailFieldList List { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailSelectFields>(entity =>
        {
            entity.HasKey(e => new { e.ListId, e.TableName, e.FieldName })
                .HasName("MAILSF_PK");

            entity.ToTable("MAIL_SELECT_FIELDS");

            entity.Property(e => e.ListId)
                .HasColumnName("LIST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.VirtualYn)
                .IsRequired()
                .HasColumnName("VIRTUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

			if (!types.Contains(typeof(MailFieldList)))
				entity.Ignore(e => e.List);
			else
	            entity.HasOne(d => d.List)
	                .WithMany(p => p.MailSelectFields)
	                .HasForeignKey(d => d.ListId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MAILSF_MAILFL_FK");
        });
	}
}
