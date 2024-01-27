namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NoteTypes1
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
    public string NoteClass { get; set; }
    public string DeptNoteYn { get; set; }
    public string HelpText { get; set; }
    public string GlobalYn { get; set; }
    public string ProtectDescriptionYn { get; set; }
    public string WebProposalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NoteTypes1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NOTE_TYPES");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeptNoteYn)
                .HasColumnName("DEPT_NOTE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HelpText)
                .HasColumnName("HELP_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoteClass)
                .HasColumnName("NOTE_CLASS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NoteCode)
                .IsRequired()
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoteType)
                .IsRequired()
                .HasColumnName("NOTE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OverrideInternal)
                .HasColumnName("OVERRIDE_INTERNAL")
                .HasMaxLength(1)
                .IsUnicode(false);

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
