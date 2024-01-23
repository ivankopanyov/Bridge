namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NamePreferencesTmp
{
    public decimal? ResvNameId { get; set; }
    public decimal? PreferenceId { get; set; }
    public string PreferenceType { get; set; }
    public string PreferenceValue { get; set; }
    public string PreferenceText { get; set; }
    public string GuestHasYn { get; set; }
    public string ResvHasYn { get; set; }
    public string OldGuestHasYn { get; set; }
    public string OldResvHasYn { get; set; }
    public string GlobProp { get; set; }
    public DateTime? NpUpdateDate { get; set; }
    public DateTime? RpUpdateDate { get; set; }
    public decimal? TypeOrderBy { get; set; }
    public decimal? ValueOrderBy { get; set; }
    public string ResvPrefYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NamePreferencesTmp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NAME_PREFERENCES_TMP");

            entity.Property(e => e.GlobProp)
                .HasColumnName("GLOB_PROP")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GuestHasYn)
                .HasColumnName("GUEST_HAS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NpUpdateDate)
                .HasColumnName("NP_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OldGuestHasYn)
                .HasColumnName("OLD_GUEST_HAS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OldResvHasYn)
                .HasColumnName("OLD_RESV_HAS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceId)
                .HasColumnName("PREFERENCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PreferenceText)
                .HasColumnName("PREFERENCE_TEXT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceType)
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PreferenceValue)
                .HasColumnName("PREFERENCE_VALUE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResvHasYn)
                .HasColumnName("RESV_HAS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvPrefYn)
                .HasColumnName("RESV_PREF_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RpUpdateDate)
                .HasColumnName("RP_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TypeOrderBy)
                .HasColumnName("TYPE_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValueOrderBy)
                .HasColumnName("VALUE_ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
