namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MailingScFields
{
    public string? Tablename { get; set; }
    public string? Fieldname { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MailingScFields>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MAILING_SC_FIELDS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Fieldname)
                .HasColumnName("FIELDNAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Tablename)
                .HasColumnName("TABLENAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
