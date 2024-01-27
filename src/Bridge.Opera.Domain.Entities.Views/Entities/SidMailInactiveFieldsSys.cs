namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidMailInactiveFieldsSys
{
    public string TableName { get; set; }
    public string FieldName { get; set; }
    public string ParameterName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidMailInactiveFieldsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_MAIL_INACTIVE_FIELDS_SYS");

            entity.Property(e => e.FieldName)
                .IsRequired()
                .HasColumnName("FIELD_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasColumnName("TABLE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
