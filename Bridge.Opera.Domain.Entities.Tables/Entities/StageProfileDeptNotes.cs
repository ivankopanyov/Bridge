namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageProfileDeptNotes
{
    public string Resort { get; set; }
    public string ResortNameId { get; set; }
    public string NoteCode { get; set; }
    public string NoteResort { get; set; }
    public string ShortNote { get; set; }
    public string LongNote { get; set; }
    public string ResortLastUpdated { get; set; }
    public string ValidFlg { get; set; }
    public string ErrorMsg { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? ApprovalDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageProfileDeptNotes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("STAGE_PROFILE_DEPT_NOTES");

            entity.HasIndex(e => new { e.Resort, e.ResortNameId })
                .HasName("STAGE_PROFILE_DN_IDX2");

            entity.HasIndex(e => new { e.NoteCode, e.NoteResort, e.Resort, e.ResortNameId })
                .HasName("STAGE_PROFILE_DN_IDX1")
                .IsUnique();

            entity.Property(e => e.ApprovalDate)
                .HasColumnName("APPROVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ErrorMsg)
                .HasColumnName("ERROR_MSG")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LongNote)
                .HasColumnName("LONG_NOTE")
                .IsUnicode(false);

            entity.Property(e => e.NoteCode)
                .IsRequired()
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoteResort)
                .IsRequired()
                .HasColumnName("NOTE_RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortLastUpdated)
                .HasColumnName("RESORT_LAST_UPDATED")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.ResortNameId)
                .IsRequired()
                .HasColumnName("RESORT_NAME_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShortNote)
                .HasColumnName("SHORT_NOTE")
                .IsUnicode(false);

            entity.Property(e => e.ValidFlg)
                .HasColumnName("VALID_FLG")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
