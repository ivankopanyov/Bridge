namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventMenuDetails1
{
    public decimal? ActualNumber { get; set; }
    public decimal? ActualRevenue { get; set; }
    public string? ArticleNumber { get; set; }
    public string? Beverage { get; set; }
    public decimal? BookId { get; set; }
    public string? Container { get; set; }
    public decimal? Cost { get; set; }
    public decimal? Course { get; set; }
    public decimal? CourseOrder { get; set; }
    public string? CustomYn { get; set; }
    public string? Description { get; set; }
    public decimal? EventId { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public decimal? ExpectedNumber { get; set; }
    public decimal? GuaranteedNumber { get; set; }
    public decimal? GuaranteedRevenue { get; set; }
    public string? IncludedYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? MenuId { get; set; }
    public decimal? MitId { get; set; }
    public string? Name1 { get; set; }
    public string? Name2 { get; set; }
    public string? Name3 { get; set; }
    public string? Portion { get; set; }
    public decimal? Price { get; set; }
    public string? Resort { get; set; }
    public string? RevenueType { get; set; }
    public decimal? Serving { get; set; }
    public decimal? SetNumber { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public byte? Year { get; set; }
    public string? Origin1 { get; set; }
    public string? Origin2 { get; set; }
    public string? Origin3 { get; set; }
    public decimal? EventMenuId { get; set; }
    public decimal? EmdId { get; set; }
    public decimal? BilledNumber { get; set; }
    public string? ShowbeoYn { get; set; }
    public decimal? DemandFactor { get; set; }
    public string? Restrictions { get; set; }
    public decimal? PkgId { get; set; }
    public string? MenuitemResort { get; set; }
    public string? ConsumptionYn { get; set; }
    public string? MandatoryYn { get; set; }
    public decimal? DiscountPercentage { get; set; }
    public decimal? DiscountedPrice { get; set; }
    public string? DiscPriceNoDisc { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventMenuDetails1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_MENU_DETAILS");

            entity.Property(e => e.ActualNumber)
                .HasColumnName("ACTUAL_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArticleNumber)
                .HasColumnName("ARTICLE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Beverage)
                .HasColumnName("BEVERAGE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BilledNumber)
                .HasColumnName("BILLED_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumptionYn)
                .HasColumnName("CONSUMPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Container)
                .HasColumnName("CONTAINER")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cost)
                .HasColumnName("COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Course)
                .HasColumnName("COURSE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CourseOrder)
                .HasColumnName("COURSE_ORDER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CustomYn)
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DemandFactor)
                .HasColumnName("DEMAND_FACTOR")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(500)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscPriceNoDisc)
                .HasColumnName("DISC_PRICE_NO_DISC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DiscountPercentage)
                .HasColumnName("DISCOUNT_PERCENTAGE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountedPrice)
                .HasColumnName("DISCOUNTED_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EmdId)
                .HasColumnName("EMD_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventMenuId)
                .HasColumnName("EVENT_MENU_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpectedNumber)
                .HasColumnName("EXPECTED_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaranteedNumber)
                .HasColumnName("GUARANTEED_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaranteedRevenue)
                .HasColumnName("GUARANTEED_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IncludedYn)
                .HasColumnName("INCLUDED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MandatoryYn)
                .HasColumnName("MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MenuitemResort)
                .HasColumnName("MENUITEM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name1)
                .HasColumnName("NAME1")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Origin1)
                .HasColumnName("ORIGIN_1")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Origin2)
                .HasColumnName("ORIGIN_2")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Origin3)
                .HasColumnName("ORIGIN_3")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Portion)
                .HasColumnName("PORTION")
                .HasMaxLength(50)
                .IsUnicode(false)
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

            entity.Property(e => e.Restrictions)
                .HasColumnName("RESTRICTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Serving)
                .HasColumnName("SERVING")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetNumber)
                .HasColumnName("SET_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowbeoYn)
                .HasColumnName("SHOWBEO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasColumnType("NUMBER(4)")
                .ValueGeneratedOnAdd();
        });
	}
}
