namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEdwPreferences
{
    public decimal? ExportId { get; set; }
    public string? EdwType { get; set; }
    public string? PmsVersion { get; set; }
    public string? DataSource { get; set; }
    public string? BrandId { get; set; }
    public string? HotelCode { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? GuestNameId { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? PreferenceType { get; set; }
    public string? PreferenceValue { get; set; }
    public DateTime? CreateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEdwPreferences>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EDW_PREFERENCES");

            entity.Property(e => e.BrandId)
                .HasColumnName("BRAND_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreateDate)
                .HasColumnName("CREATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DataSource)
                .HasColumnName("DATA_SOURCE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EdwType)
                .HasColumnName("EDW_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsVersion)
                .HasColumnName("PMS_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceType)
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceValue)
                .HasColumnName("PREFERENCE_VALUE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
