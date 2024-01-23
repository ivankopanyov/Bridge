namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailSourceFields
{
    public decimal SourceId { get; set; }
    public string TableName { get; set; }
    public string FieldName { get; set; }
    public string VirtualYn { get; set; }

    public virtual MailSource Source { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailSourceFields>(entity =>
        {
            entity.HasKey(e => new { e.SourceId, e.TableName, e.FieldName, e.VirtualYn })
                .HasName("MSEF_PK");

            entity.ToTable("MAIL_SOURCE_FIELDS");

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
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
                .HasColumnName("VIRTUAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(MailSource)))
				entity.Ignore(e => e.Source);
			else
	            entity.HasOne(d => d.Source)
	                .WithMany(p => p.MailSourceFields)
	                .HasForeignKey(d => d.SourceId)
	                .HasConstraintName("MSEF_MSE_FK");
        });
	}
}
