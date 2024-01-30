namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameDeptNoteMerge
{
    public decimal? FromNoteId { get; set; }
    public decimal? FromNameId { get; set; }
    public string? FromNoteCode { get; set; }
    public string? FromResort { get; set; }
    public string? FromShortNote { get; set; }
    public string? FromLongNote { get; set; }
    public DateTime? FromApprovalSubDate { get; set; }
    public DateTime? FromApprovalDate { get; set; }
    public decimal? FromApprovalUserId { get; set; }
    public string? FromResortLastUpdated { get; set; }
    public DateTime? FromInsertDate { get; set; }
    public decimal? FromInsertUser { get; set; }
    public DateTime? FromUpdateDate { get; set; }
    public decimal? FromUpdateUser { get; set; }
    public string? FromStatusFlg { get; set; }
    public DateTime? FromInactiveDate { get; set; }
    public string? FromSharedYn { get; set; }
    public string? FromDescStatus { get; set; }
    public decimal? ToNoteId { get; set; }
    public decimal? ToNameId { get; set; }
    public string? ToNoteCode { get; set; }
    public string? ToResort { get; set; }
    public string? ToShortNote { get; set; }
    public string? ToLongNote { get; set; }
    public DateTime? ToApprovalSubDate { get; set; }
    public DateTime? ToApprovalDate { get; set; }
    public decimal? ToApprovalUserId { get; set; }
    public string? ToResortLastUpdated { get; set; }
    public DateTime? ToInsertDate { get; set; }
    public decimal? ToInsertUser { get; set; }
    public DateTime? ToUpdateDate { get; set; }
    public decimal? ToUpdateUser { get; set; }
    public string? ToStatusFlg { get; set; }
    public DateTime? ToInactiveDate { get; set; }
    public string? ToSharedYn { get; set; }
    public string? ToDescStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameDeptNoteMerge>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_DEPT_NOTE_MERGE");

            entity.Property(e => e.FromApprovalDate)
                .HasColumnName("FROM_APPROVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromApprovalSubDate)
                .HasColumnName("FROM_APPROVAL_SUB_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromApprovalUserId)
                .HasColumnName("FROM_APPROVAL_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromDescStatus)
                .HasColumnName("FROM_DESC_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.FromInactiveDate)
                .HasColumnName("FROM_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromInsertDate)
                .HasColumnName("FROM_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromInsertUser)
                .HasColumnName("FROM_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromLongNote)
                .HasColumnName("FROM_LONG_NOTE")
                .IsUnicode(false);

            entity.Property(e => e.FromNameId)
                .HasColumnName("FROM_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromNoteCode)
                .IsRequired()
                .HasColumnName("FROM_NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FromNoteId)
                .HasColumnName("FROM_NOTE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromResort)
                .IsRequired()
                .HasColumnName("FROM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FromResortLastUpdated)
                .HasColumnName("FROM_RESORT_LAST_UPDATED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FromSharedYn)
                .HasColumnName("FROM_SHARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FromShortNote)
                .HasColumnName("FROM_SHORT_NOTE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FromStatusFlg)
                .HasColumnName("FROM_STATUS_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FromUpdateDate)
                .HasColumnName("FROM_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromUpdateUser)
                .HasColumnName("FROM_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToApprovalDate)
                .HasColumnName("TO_APPROVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToApprovalSubDate)
                .HasColumnName("TO_APPROVAL_SUB_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToApprovalUserId)
                .HasColumnName("TO_APPROVAL_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToDescStatus)
                .HasColumnName("TO_DESC_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ToInactiveDate)
                .HasColumnName("TO_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToInsertDate)
                .HasColumnName("TO_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToInsertUser)
                .HasColumnName("TO_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToLongNote)
                .HasColumnName("TO_LONG_NOTE")
                .IsUnicode(false);

            entity.Property(e => e.ToNameId)
                .HasColumnName("TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToNoteCode)
                .IsRequired()
                .HasColumnName("TO_NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToNoteId)
                .HasColumnName("TO_NOTE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToResort)
                .IsRequired()
                .HasColumnName("TO_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToResortLastUpdated)
                .HasColumnName("TO_RESORT_LAST_UPDATED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToSharedYn)
                .HasColumnName("TO_SHARED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToShortNote)
                .HasColumnName("TO_SHORT_NOTE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ToStatusFlg)
                .HasColumnName("TO_STATUS_FLG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ToUpdateDate)
                .HasColumnName("TO_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToUpdateUser)
                .HasColumnName("TO_UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
