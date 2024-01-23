namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsTypbRejectHeader
{
    public decimal TypbRejectId { get; set; }
    public string TypbHost { get; set; }
    public string TypbMessageNo { get; set; }
    public string TypbErrorText { get; set; }
    public decimal TypbRetryCount { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string ReadyForRetry { get; set; }
    public string HeaderText { get; set; }
    public string GdsTransactionNo { get; set; }
    public string Resort { get; set; }
    public DateTime? ReserveBeginDate { get; set; }
    public string Comments { get; set; }
    public decimal? BookNo { get; set; }
    public string TypbRetryErrorText { get; set; }
    public string UseRetryErrorYn { get; set; }
    public string BookrqText { get; set; }
    public string GuestText { get; set; }
    public string GdsPassthrough { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsTypbRejectHeader>(entity =>
        {
            entity.HasKey(e => e.TypbRejectId)
                .HasName("GDS_TYPB_REJECT_HEADER_PK");

            entity.ToTable("GDS_TYPB_REJECT_HEADER");

            entity.Property(e => e.TypbRejectId)
                .HasColumnName("TYPB_REJECT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookNo)
                .HasColumnName("BOOK_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookrqText)
                .HasColumnName("BOOKRQ_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GdsPassthrough)
                .HasColumnName("GDS_PASSTHROUGH")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.GdsTransactionNo)
                .HasColumnName("GDS_TRANSACTION_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.GuestText)
                .HasColumnName("GUEST_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HeaderText)
                .HasColumnName("HEADER_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReadyForRetry)
                .HasColumnName("READY_FOR_RETRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReserveBeginDate)
                .HasColumnName("RESERVE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypbErrorText)
                .IsRequired()
                .HasColumnName("TYPB_ERROR_TEXT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TypbHost)
                .IsRequired()
                .HasColumnName("TYPB_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypbMessageNo)
                .IsRequired()
                .HasColumnName("TYPB_MESSAGE_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypbRetryCount)
                .HasColumnName("TYPB_RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TypbRetryErrorText)
                .HasColumnName("TYPB_RETRY_ERROR_TEXT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UseRetryErrorYn)
                .HasColumnName("USE_RETRY_ERROR_YN")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
