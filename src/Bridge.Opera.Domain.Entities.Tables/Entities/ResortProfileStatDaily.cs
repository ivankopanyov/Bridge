namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortProfileStatDaily
{
    public string? Resort { get; set; }
    public DateTime? StatDate { get; set; }
    public decimal? PropertyPrefCreatedCount { get; set; }
    public decimal? GlobalPrefCreatedCount { get; set; }
    public decimal? InternalNotesCreatedCount { get; set; }
    public decimal? InternalNotesRCount { get; set; }
    public decimal? InternalNotesSCount { get; set; }
    public decimal? InternalNotesACount { get; set; }
    public decimal? InternalNotesArCount { get; set; }
    public DateTime? LastTransferedDate { get; set; }
    public string? TransferredFlgYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortProfileStatDaily>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.StatDate })
                .HasName("RPSD_PK");

            entity.ToTable("RESORT_PROFILE_STAT_DAILY");

            entity.HasIndex(e => e.TransferredFlgYn)
                .HasName("RPSD_IDX1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatDate)
                .HasColumnName("STAT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GlobalPrefCreatedCount)
                .HasColumnName("GLOBAL_PREF_CREATED_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalNotesACount)
                .HasColumnName("INTERNAL_NOTES_A_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalNotesArCount)
                .HasColumnName("INTERNAL_NOTES_AR_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalNotesCreatedCount)
                .HasColumnName("INTERNAL_NOTES_CREATED_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalNotesRCount)
                .HasColumnName("INTERNAL_NOTES_R_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalNotesSCount)
                .HasColumnName("INTERNAL_NOTES_S_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastTransferedDate)
                .HasColumnName("LAST_TRANSFERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PropertyPrefCreatedCount)
                .HasColumnName("PROPERTY_PREF_CREATED_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransferredFlgYn)
                .HasColumnName("TRANSFERRED_FLG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
