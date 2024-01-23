namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NoteTypes
{
    public string NoteType { get; set; }
    public string NoteCode { get; set; }
    public string Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }
    public string CanDeleteYn { get; set; }
    public string InternalYn { get; set; }
    public string DefaultYn { get; set; }
    public string OverrideInternal { get; set; }
    public string ChainCode { get; set; }
    public string NoteClass { get; set; }
    public string DeptNoteYn { get; set; }
    public string HelpText { get; set; }
    public string GlobalYn { get; set; }
    public string ProtectDescriptionYn { get; set; }
    public string WebProposalYn { get; set; }
    public string NotificationAreas { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NoteTypes>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.NoteCode, e.NoteType })
                .HasName("NTYP_PK");

            entity.ToTable("NOTE$TYPES");

            entity.HasIndex(e => new { e.ChainCode, e.NoteType, e.NoteCode })
                .HasName("NTYP_UK")
                .IsUnique();

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteCode)
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteType)
                .HasColumnName("NOTE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptNoteYn)
                .HasColumnName("DEPT_NOTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HelpText)
                .HasColumnName("HELP_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteClass)
                .HasColumnName("NOTE_CLASS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NotificationAreas)
                .HasColumnName("NOTIFICATION_AREAS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OverrideInternal)
                .HasColumnName("OVERRIDE_INTERNAL")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.ProtectDescriptionYn)
                .HasColumnName("PROTECT_DESCRIPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WebProposalYn)
                .HasColumnName("WEB_PROPOSAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
