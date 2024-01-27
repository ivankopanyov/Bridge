namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepProfileDeptnotes
{
    public decimal NoteId { get; set; }
    public decimal NameId { get; set; }
    public string RepNoteCode { get; set; }
    public string Resort { get; set; }
    public string ShortNote { get; set; }
    public string LongNote { get; set; }
    public DateTime? ApprovalSubDate { get; set; }
    public DateTime? ApprovalDate { get; set; }
    public decimal? ApprovalUserId { get; set; }
    public string ResortLastUpdated { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string StatusFlg { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string NotetypeDesc { get; set; }
    public string Departments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepProfileDeptnotes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_PROFILE_DEPTNOTES");

            entity.Property(e => e.ApprovalDate)
                .HasColumnName("APPROVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ApprovalSubDate)
                .HasColumnName("APPROVAL_SUB_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ApprovalUserId)
                .HasColumnName("APPROVAL_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departments)
                .HasColumnName("DEPARTMENTS")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LongNote)
                .HasColumnName("LONG_NOTE")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoteId)
                .HasColumnName("NOTE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NotetypeDesc)
                .IsRequired()
                .HasColumnName("NOTETYPE_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RepNoteCode)
                .IsRequired()
                .HasColumnName("REP_NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortLastUpdated)
                .HasColumnName("RESORT_LAST_UPDATED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShortNote)
                .HasColumnName("SHORT_NOTE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.StatusFlg)
                .HasColumnName("STATUS_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
