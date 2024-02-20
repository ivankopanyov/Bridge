namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpConPreference
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NameId { get; set; }
    public string? PreferenceType { get; set; }
    public string? Resort { get; set; }
    public string? ResortActual { get; set; }
    public string? PreferenceValue { get; set; }
    public string? PreferenceDescription { get; set; }
    public string? PreferenceTypeDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpConPreference>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_CON_PREFERENCE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreferenceDescription)
                .HasColumnName("PREFERENCE_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceType)
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceTypeDescription)
                .HasColumnName("PREFERENCE_TYPE_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceValue)
                .HasColumnName("PREFERENCE_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResortActual)
                .HasColumnName("RESORT_ACTUAL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
