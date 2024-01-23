namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MailInactiveFields
{
    public string TableName { get; set; }
    public string FieldName { get; set; }
    public string ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailInactiveFields>(entity =>
        {
            entity.HasKey(e => new { e.TableName, e.FieldName, e.ParameterName })
                .HasName("MID_PK");

            entity.ToTable("MAIL_INACTIVE_FIELDS");

            entity.Property(e => e.TableName)
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FieldName)
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
