namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArStmtHistory
{
    public string? Resort { get; set; }
    public decimal? AccountCode { get; set; }
    public DateTime? StmtSentDate { get; set; }
    public DateTime? TruncStmtSentDate { get; set; }
    public string? AccountNo { get; set; }
    public DateTime? ForwardDate { get; set; }
    public DateTime? TillDate { get; set; }
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public string? PrintzeroYn { get; set; }
    public string? PrintfullYn { get; set; }
    public string? PromotionalText { get; set; }
    public DateTime? InsertDate { get; set; }
    public string? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UpdateUser { get; set; }
    public string? ReportName { get; set; }
    public decimal? StatementNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArStmtHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AR$_STMT_HISTORY");

            entity.HasIndex(e => new { e.AccountNo, e.TruncStmtSentDate, e.Resort })
                .HasName("STMT_ACCOUNT_NO_IND");

            entity.HasIndex(e => new { e.TruncStmtSentDate, e.AccountCode, e.Resort })
                .HasName("STMT_SENT_ACCOUNT_CODE_IND");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountNo)
                .IsRequired()
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ForwardDate)
                .HasColumnName("FORWARD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FromDate)
                .HasColumnName("FROM_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PrintfullYn)
                .HasColumnName("PRINTFULL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintzeroYn)
                .HasColumnName("PRINTZERO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PromotionalText)
                .HasColumnName("PROMOTIONAL_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReportName)
                .HasColumnName("REPORT_NAME")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StatementNo)
                .HasColumnName("STATEMENT_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StmtSentDate)
                .HasColumnName("STMT_SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TillDate)
                .HasColumnName("TILL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ToDate)
                .HasColumnName("TO_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncStmtSentDate)
                .HasColumnName("TRUNC_STMT_SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
