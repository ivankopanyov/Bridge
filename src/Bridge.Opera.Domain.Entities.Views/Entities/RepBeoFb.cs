namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBeoFb
{
    public decimal? BookId { get; set; }
    public string? Resort { get; set; }
    public decimal? EventId { get; set; }
    public string? EventName { get; set; }
    public DateTime? FbStartDate { get; set; }
    public DateTime? FbEndDate { get; set; }
    public string? EventRoom { get; set; }
    public string? EventFbStartDate { get; set; }
    public string? EventFbEndDate { get; set; }
    public string? EventFbTimeInterval { get; set; }
    public decimal? EventmenuEventId { get; set; }
    public decimal? EventmenuOrderBy { get; set; }
    public decimal? EventmenuPkgId { get; set; }
    public decimal? EventmenuMenuId { get; set; }
    public string? EventmenuConsumption { get; set; }
    public string? EventmenuDescription { get; set; }
    public string? EventmenuName { get; set; }
    public string? EventmenuResort { get; set; }
    public decimal? EventMenuId { get; set; }
    public string? EventmenuBeverageClass { get; set; }
    public decimal? EventmenuExpNum { get; set; }
    public decimal? EventmenuGtdNum { get; set; }
    public decimal? EventmenuSetNum { get; set; }
    public decimal? MenudetailExp { get; set; }
    public decimal? MenudetailGtd { get; set; }
    public decimal? MenudetailSet { get; set; }
    public DateTime? ServingStart { get; set; }
    public DateTime? ServingEnd { get; set; }
    public string? ServingTime { get; set; }
    public decimal? EventmenuPrice { get; set; }
    public decimal? EventmenuEventMenuId { get; set; }
    public string? Serving { get; set; }
    public decimal? MenudetailEventId { get; set; }
    public decimal? MenudetailPkgId { get; set; }
    public decimal? MenudetailMenuId { get; set; }
    public string? MenudetailResort { get; set; }
    public string? MenudetailBeverage { get; set; }
    public decimal? MenudetailMitId { get; set; }
    public decimal? MenudetailId { get; set; }
    public string? MenudetailName1 { get; set; }
    public string? MenudetailName2 { get; set; }
    public string? MenudetailName3 { get; set; }
    public string? MenudetailOrigin1 { get; set; }
    public string? MenudetailOrigin2 { get; set; }
    public string? MenudetailOrigin3 { get; set; }
    public byte? MenudetailYear { get; set; }
    public string? MenudetailArticleNumber { get; set; }
    public string? MenudetailIncluded { get; set; }
    public string? MenudetailContainer { get; set; }
    public string? MenudetailPortion { get; set; }
    public decimal? MenudetailPrice { get; set; }
    public decimal? MenudetailCourse { get; set; }
    public string? Showbeo { get; set; }
    public decimal? MenudetailCourseOrder { get; set; }
    public string? EventmenudetailConsumption { get; set; }
    public decimal? Discount { get; set; }
    public decimal? EventmenuExpPkgNum { get; set; }
    public decimal? EventmenuGuaPkgNum { get; set; }
    public decimal? EventmenuActPkgNum { get; set; }
    public decimal? EventmenuBilPkgNum { get; set; }
    public decimal? MenudetDiscountedPercentage { get; set; }
    public decimal? MenudetDiscountedPrice { get; set; }
    public decimal? MenuDiscountedPrice { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBeoFb>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BEO_FB");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventFbEndDate)
                .HasColumnName("EVENT_FB_END_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EventFbStartDate)
                .HasColumnName("EVENT_FB_START_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EventFbTimeInterval)
                .HasColumnName("EVENT_FB_TIME_INTERVAL")
                .HasMaxLength(151)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventMenuId)
                .HasColumnName("EVENT_MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventName)
                .IsRequired()
                .HasColumnName("EVENT_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.EventRoom)
                .HasColumnName("EVENT_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventmenuActPkgNum)
                .HasColumnName("EVENTMENU_ACT_PKG_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuBeverageClass)
                .HasColumnName("EVENTMENU_BEVERAGE_CLASS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EventmenuBilPkgNum)
                .HasColumnName("EVENTMENU_BIL_PKG_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuConsumption)
                .HasColumnName("EVENTMENU_CONSUMPTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EventmenuDescription)
                .HasColumnName("EVENTMENU_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EventmenuEventId)
                .HasColumnName("EVENTMENU_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuEventMenuId)
                .HasColumnName("EVENTMENU_EVENT_MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuExpNum)
                .HasColumnName("EVENTMENU_EXP_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuExpPkgNum)
                .HasColumnName("EVENTMENU_EXP_PKG_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuGtdNum)
                .HasColumnName("EVENTMENU_GTD_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuGuaPkgNum)
                .HasColumnName("EVENTMENU_GUA_PKG_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuMenuId)
                .HasColumnName("EVENTMENU_MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuName)
                .HasColumnName("EVENTMENU_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EventmenuOrderBy)
                .HasColumnName("EVENTMENU_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuPkgId)
                .HasColumnName("EVENTMENU_PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuPrice)
                .HasColumnName("EVENTMENU_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenuResort)
                .HasColumnName("EVENTMENU_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventmenuSetNum)
                .HasColumnName("EVENTMENU_SET_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventmenudetailConsumption)
                .HasColumnName("EVENTMENUDETAIL_CONSUMPTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FbEndDate)
                .HasColumnName("FB_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FbStartDate)
                .HasColumnName("FB_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MenuDiscountedPrice)
                .HasColumnName("MENU_DISCOUNTED_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetDiscountedPercentage)
                .HasColumnName("MENUDET_DISCOUNTED_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetDiscountedPrice)
                .HasColumnName("MENUDET_DISCOUNTED_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailArticleNumber)
                .HasColumnName("MENUDETAIL_ARTICLE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailBeverage)
                .HasColumnName("MENUDETAIL_BEVERAGE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailContainer)
                .HasColumnName("MENUDETAIL_CONTAINER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailCourse)
                .HasColumnName("MENUDETAIL_COURSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailCourseOrder)
                .HasColumnName("MENUDETAIL_COURSE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailEventId)
                .HasColumnName("MENUDETAIL_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailExp)
                .HasColumnName("MENUDETAIL_EXP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailGtd)
                .HasColumnName("MENUDETAIL_GTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailId)
                .HasColumnName("MENUDETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailIncluded)
                .HasColumnName("MENUDETAIL_INCLUDED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailMenuId)
                .HasColumnName("MENUDETAIL_MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailMitId)
                .HasColumnName("MENUDETAIL_MIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailName1)
                .HasColumnName("MENUDETAIL_NAME1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailName2)
                .HasColumnName("MENUDETAIL_NAME2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailName3)
                .HasColumnName("MENUDETAIL_NAME3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailOrigin1)
                .HasColumnName("MENUDETAIL_ORIGIN1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailOrigin2)
                .HasColumnName("MENUDETAIL_ORIGIN2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailOrigin3)
                .HasColumnName("MENUDETAIL_ORIGIN3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailPkgId)
                .HasColumnName("MENUDETAIL_PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailPortion)
                .HasColumnName("MENUDETAIL_PORTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailPrice)
                .HasColumnName("MENUDETAIL_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailResort)
                .HasColumnName("MENUDETAIL_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailSet)
                .HasColumnName("MENUDETAIL_SET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenudetailYear)
                .HasColumnName("MENUDETAIL_YEAR")
                .HasColumnType("NUMBER(4)");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Serving)
                .HasColumnName("SERVING")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.ServingEnd)
                .HasColumnName("SERVING_END")
                .HasColumnType("DATE");

            entity.Property(e => e.ServingStart)
                .HasColumnName("SERVING_START")
                .HasColumnType("DATE");

            entity.Property(e => e.ServingTime)
                .HasColumnName("SERVING_TIME")
                .HasMaxLength(151)
                .IsUnicode(false);

            entity.Property(e => e.Showbeo)
                .HasColumnName("SHOWBEO")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
