namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SpgPreferences
{
    public SpgPreferences()
    {
        GuestEnrollmentPref = new HashSet<GuestEnrollmentPref>();
    }

    public string Preference { get; set; }
    public string PreferenceType { get; set; }
    public string Description { get; set; }

    public virtual ICollection<GuestEnrollmentPref> GuestEnrollmentPref { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpgPreferences>(entity =>
        {
            entity.HasKey(e => new { e.Preference, e.PreferenceType })
                .HasName("GP_PREFERENCES_PK");

            entity.ToTable("SPG_PREFERENCES");

            entity.Property(e => e.Preference)
                .HasColumnName("PREFERENCE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceType)
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(GuestEnrollmentPref)))
				entity.Ignore(e => e.GuestEnrollmentPref);
		});
	}
}
