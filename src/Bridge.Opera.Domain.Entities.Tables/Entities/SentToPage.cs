namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SentToPage
{
    public decimal ToPageSeqNo { get; set; }
    public decimal? TotalAttemptsMade { get; set; }
    public string Resort { get; set; }
    public string ToPageString { get; set; }
    public DateTime LastPageRequestedDate { get; set; }
    public DateTime? LastPageSentDate { get; set; }
    public string PagerNumber { get; set; }
    public string PageSentYn { get; set; }
    public decimal? PageCount { get; set; }
    public string NumericPageYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SentToPage>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SENT_TO_PAGE");

            entity.Property(e => e.LastPageRequestedDate)
                .HasColumnName("LAST_PAGE_REQUESTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastPageSentDate)
                .HasColumnName("LAST_PAGE_SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NumericPageYn)
                .HasColumnName("NUMERIC_PAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.PageCount)
                .HasColumnName("PAGE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PageSentYn)
                .HasColumnName("PAGE_SENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PagerNumber)
                .HasColumnName("PAGER_NUMBER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToPageSeqNo)
                .HasColumnName("TO_PAGE_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToPageString)
                .IsRequired()
                .HasColumnName("TO_PAGE_STRING")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TotalAttemptsMade)
                .HasColumnName("TOTAL_ATTEMPTS_MADE")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql(@"0");
        });
	}
}
