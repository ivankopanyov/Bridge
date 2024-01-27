namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationComment
{
    public string Resort { get; set; }
    public decimal ResvCommentId { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal ResvNameId { get; set; }
    public string CommentType { get; set; }
    public string Comments { get; set; }
    public decimal? InsertActionInstanceId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public string NoteCode { get; set; }
    public string NoteResort { get; set; }
    public string InternalYn { get; set; }
    public string ExternalCommentId { get; set; }
    public string UserModifiableYn { get; set; }
    public string NoteTitle { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationComment>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.ResvCommentId })
                .HasName("RESERVATION_COMMENT_PK");

            entity.ToTable("RESERVATION_COMMENT");

            entity.HasIndex(e => e.ExternalCommentId)
                .HasName("RESERVATION_COMMENT_EXTID_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvCommentId)
                .HasColumnName("RESV_COMMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommentType)
                .HasColumnName("COMMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalCommentId)
                .HasColumnName("EXTERNAL_COMMENT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertActionInstanceId)
                .HasColumnName("INSERT_ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NoteCode)
                .HasColumnName("NOTE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NoteResort)
                .HasColumnName("NOTE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoteTitle)
                .HasColumnName("NOTE_TITLE")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserModifiableYn)
                .HasColumnName("USER_MODIFIABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.ReservationComment)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESV_COMMENT_RESV_NAME");
        });
	}
}
