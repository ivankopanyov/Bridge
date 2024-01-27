namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class WeblinkItems
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string FormName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WeblinkItems>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("WEBLINK_ITEMS");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(183)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(230)
                .IsUnicode(false);

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
