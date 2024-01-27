namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScPreferences1
{
    public decimal AppUserId { get; set; }
    public string FormName { get; set; }
    public string AppUser { get; set; }
    public string PrefCode { get; set; }
    public string PrefValue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPreferences1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_PREFERENCES");

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FormName)
                .IsRequired()
                .HasColumnName("FORM_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PrefCode)
                .IsRequired()
                .HasColumnName("PREF_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrefValue)
                .HasColumnName("PREF_VALUE")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
