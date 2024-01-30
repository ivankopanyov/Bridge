namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SgiPreferencesView
{
    public string? PreferenceType { get; set; }
    public string? Description { get; set; }
    public string? PreferenceValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SgiPreferencesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SGI_PREFERENCES_VIEW");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceType)
                .IsRequired()
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceValue)
                .IsRequired()
                .HasColumnName("PREFERENCE_VALUE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
