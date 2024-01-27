namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ArticleCodes1
{
    public string Resort { get; set; }
    public decimal ArticleId { get; set; }
    public string ArticleCode { get; set; }
    public string TrxCode { get; set; }
    public string Description { get; set; }
    public decimal? DefaultPrice { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string TrxDescription { get; set; }
    public string ManualPostYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string PostitYn { get; set; }
    public string PostitColour { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArticleCodes1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ARTICLE_CODES");

            entity.Property(e => e.ArticleCode)
                .IsRequired()
                .HasColumnName("ARTICLE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArticleId)
                .HasColumnName("ARTICLE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefaultPrice)
                .HasColumnName("DEFAULT_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ManualPostYn)
                .HasColumnName("MANUAL_POST_YN")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostitColour)
                .HasColumnName("POSTIT_COLOUR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PostitYn)
                .HasColumnName("POSTIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDescription)
                .HasColumnName("TRX_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
