namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmBookActPostHeaderVw
{
    public string Resort { get; set; }
    public decimal BookedActId { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string GuestName { get; set; }
    public string ActCode { get; set; }
    public string ActDesc { get; set; }
    public string ActType { get; set; }
    public string PostOnEvent { get; set; }
    public string ActLongDesc { get; set; }
    public string ActStatus { get; set; }
    public decimal Price { get; set; }
    public string PriceCode { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? BeginTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string ActAgeText { get; set; }
    public decimal ServiceId { get; set; }
    public string ServiceResort { get; set; }
    public string ArticleCode { get; set; }
    public string TrxCode { get; set; }
    public string ServiceActCode { get; set; }
    public string ArticleResort { get; set; }
    public decimal ArticleId { get; set; }
    public string ArticleDescription { get; set; }
    public decimal? ArticleDefaultPrice { get; set; }
    public string ArticlePostitYn { get; set; }
    public decimal? NoOfPeople { get; set; }
    public string ActivityDateChr { get; set; }
    public string BeginTimeChr { get; set; }
    public string EndTimeChr { get; set; }
    public string LocationDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookActPostHeaderVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_BOOK_ACT_POST_HEADER_VW");

            entity.Property(e => e.ActAgeText)
                .HasColumnName("ACT_AGE_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasColumnName("ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActDesc)
                .IsRequired()
                .HasColumnName("ACT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActLongDesc)
                .HasColumnName("ACT_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ActStatus)
                .IsRequired()
                .HasColumnName("ACT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActType)
                .IsRequired()
                .HasColumnName("ACT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActivityDateChr)
                .HasColumnName("ACTIVITY_DATE_CHR")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ArticleCode)
                .IsRequired()
                .HasColumnName("ARTICLE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArticleDefaultPrice)
                .HasColumnName("ARTICLE_DEFAULT_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArticleDescription)
                .IsRequired()
                .HasColumnName("ARTICLE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ArticleId)
                .HasColumnName("ARTICLE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArticlePostitYn)
                .HasColumnName("ARTICLE_POSTIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ArticleResort)
                .IsRequired()
                .HasColumnName("ARTICLE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginTime)
                .HasColumnName("BEGIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginTimeChr)
                .HasColumnName("BEGIN_TIME_CHR")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTimeChr)
                .HasColumnName("END_TIME_CHR")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.LocationDesc)
                .HasColumnName("LOCATION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfPeople)
                .HasColumnName("NO_OF_PEOPLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostOnEvent)
                .HasColumnName("POST_ON_EVENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ServiceActCode)
                .HasColumnName("SERVICE_ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServiceId)
                .HasColumnName("SERVICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ServiceResort)
                .IsRequired()
                .HasColumnName("SERVICE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
