namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AgendaResource
{
    public string ResourceCode { get; set; }
    public string Description { get; set; }
    public string LanguageCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AgendaResource>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AGENDA_RESOURCE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResourceCode)
                .IsRequired()
                .HasColumnName("RESOURCE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
