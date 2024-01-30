namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpeProfPref
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public decimal? NameId { get; set; }
    public decimal? PrefTypeSeq { get; set; }
    public decimal? PrefSeq { get; set; }
    public string? PreferenceType { get; set; }
    public string? PrefGrp { get; set; }
    public string? PreferenceValue { get; set; }
    public string? Resort { get; set; }
    public string? GlobalYn { get; set; }
    public string? PrefDescription { get; set; }
    public string? UpePrefCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpeProfPref>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_PROF_PREF");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrefDescription)
                .HasColumnName("PREF_DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrefGrp)
                .HasColumnName("PREF_GRP")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrefSeq)
                .HasColumnName("PREF_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrefTypeSeq)
                .HasColumnName("PREF_TYPE_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreferenceType)
                .HasColumnName("PREFERENCE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PreferenceValue)
                .HasColumnName("PREFERENCE_VALUE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpePrefCode)
                .HasColumnName("UPE_PREF_CODE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
