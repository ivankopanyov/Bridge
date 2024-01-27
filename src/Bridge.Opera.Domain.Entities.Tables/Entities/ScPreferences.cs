namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScPreferences
{
    public decimal AppUserId { get; set; }
    public string FormName { get; set; }
    public string AppUser { get; set; }
    public string PrefCode { get; set; }
    public string PrefValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPreferences>(entity =>
        {
            entity.HasKey(e => new { e.AppUserId, e.FormName, e.PrefCode })
                .HasName("PREF_PK");

            entity.ToTable("SC$PREFERENCES");

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FormName)
                .HasColumnName("FORM_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PrefCode)
                .HasColumnName("PREF_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PrefValue)
                .HasColumnName("PREF_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
