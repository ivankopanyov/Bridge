namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemMenu1
{
    public decimal? MenuId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? MencId { get; set; }
    public string? BeverageClass { get; set; }
    public decimal? Price { get; set; }
    public string? Restriction { get; set; }
    public decimal? ServingId { get; set; }
    public string? ServingCode { get; set; }
    public string? Serving { get; set; }
    public string? ConsumptionYn { get; set; }
    public string? MultiChoiceYn { get; set; }
    public string? ArticleNumber { get; set; }
    public decimal? PersonsPerTable { get; set; }
    public string? Resort { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? SellDateStart { get; set; }
    public DateTime? SellDateEnd { get; set; }
    public DateTime? BookDateStart { get; set; }
    public DateTime? BookDateEnd { get; set; }
    public string? InactiveYn { get; set; }
    public string? WebBookingYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenu1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_MENU");

            entity.Property(e => e.ArticleNumber)
                .HasColumnName("ARTICLE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeverageClass)
                .HasColumnName("BEVERAGE_CLASS")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookDateEnd)
                .HasColumnName("BOOK_DATE_END")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookDateStart)
                .HasColumnName("BOOK_DATE_START")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumptionYn)
                .HasColumnName("CONSUMPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MencId)
                .HasColumnName("MENC_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MultiChoiceYn)
                .HasColumnName("MULTI_CHOICE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PersonsPerTable)
                .HasColumnName("PERSONS_PER_TABLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Restriction)
                .HasColumnName("RESTRICTION")
                .HasMaxLength(400)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellDateEnd)
                .HasColumnName("SELL_DATE_END")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellDateStart)
                .HasColumnName("SELL_DATE_START")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Serving)
                .HasColumnName("SERVING")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ServingCode)
                .HasColumnName("SERVING_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ServingId)
                .HasColumnName("SERVING_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
