namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArticleRevenues
{
    public string? Resort { get; set; }
    public DateTime? TrxDate { get; set; }
    public decimal? ArticleId { get; set; }
    public string? ArticleCode { get; set; }
    public string? TrxCode { get; set; }
    public decimal? Amount { get; set; }
    public decimal? TimesUsed { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArticleRevenues>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TrxDate, e.ArticleId, e.TrxCode })
                .HasName("AREV_PK");

            entity.ToTable("ARTICLE$_REVENUES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ArticleId)
                .HasColumnName("ARTICLE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArticleCode)
                .IsRequired()
                .HasColumnName("ARTICLE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimesUsed)
                .HasColumnName("TIMES_USED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
