namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AppUserDefaultForms
{
    public string? Form { get; set; }
    public string? Description { get; set; }
    public string? MainForm { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppUserDefaultForms>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("APP_USER_DEFAULT_FORMS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.Form)
                .HasColumnName("FORM")
                .HasMaxLength(14)
                .IsUnicode(false);

            entity.Property(e => e.MainForm)
                .HasColumnName("MAIN_FORM")
                .HasMaxLength(6)
                .IsUnicode(false);
        });
	}
}
