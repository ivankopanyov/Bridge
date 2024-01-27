namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBeoFoodCombined
{
    public string Resort { get; set; }
    public decimal FoodBookId { get; set; }
    public decimal? FoodcombinedEventId { get; set; }
    public decimal? FbEventId { get; set; }
    public string FbEventIds { get; set; }
    public string FbRoom { get; set; }
    public decimal? FbOrderby { get; set; }
    public decimal? MenudetailCourseOrder { get; set; }
    public DateTime FoodStartDate { get; set; }
    public DateTime FoodEndDate { get; set; }
    public decimal? FoodmenuId { get; set; }
    public decimal? FoodresourceId { get; set; }
    public string FoodresourceIds { get; set; }
    public string FoodmenuName { get; set; }
    public decimal? FoodmenuPkgId { get; set; }
    public decimal? FoodmenuExp { get; set; }
    public decimal? FoodmenuGtd { get; set; }
    public decimal? FoodmenuSet { get; set; }
    public decimal? FoodmenuPrice { get; set; }
    public decimal? FoodDiscount { get; set; }
    public decimal? DiscountedFoodmenuPrice { get; set; }
    public decimal? FoodmenuDiscount { get; set; }
    public string FoodmenuResort { get; set; }
    public string FoodmenuServing { get; set; }
    public DateTime? FoodmenuServingStart { get; set; }
    public DateTime? FoodmenuServingEnd { get; set; }
    public string FoodResort { get; set; }
    public decimal? FoodCourse { get; set; }
    public decimal? FoodId { get; set; }
    public decimal? FoodMenuId1 { get; set; }
    public decimal? FoodMitId { get; set; }
    public decimal? FoodExp { get; set; }
    public decimal? FoodGtd { get; set; }
    public decimal? FoodSet { get; set; }
    public string FoodIncluded { get; set; }
    public decimal? FoodPrice { get; set; }
    public string FoodPortion { get; set; }
    public string FoodContainer { get; set; }
    public byte? FoodYear { get; set; }
    public string FoodName1 { get; set; }
    public string FoodName2 { get; set; }
    public string FoodName3 { get; set; }
    public string FoodShow { get; set; }
    public string MenudetailConsumptionYn { get; set; }
    public string MenuConsumptionYn { get; set; }
    public decimal? DiscountedFoodPrice { get; set; }
    public decimal? FoodmenuGtdPkg { get; set; }
    public decimal? FoodmenuExpPkg { get; set; }
    public decimal? FoodresourceNoteId { get; set; }
    public string PrintFoodNotesYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBeoFoodCombined>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BEO_FOOD_COMBINED");

            entity.Property(e => e.DiscountedFoodPrice)
                .HasColumnName("DISCOUNTED_FOOD_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountedFoodmenuPrice)
                .HasColumnName("DISCOUNTED_FOODMENU_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbEventId)
                .HasColumnName("FB_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbEventIds)
                .HasColumnName("FB_EVENT_IDS")
                .IsUnicode(false);

            entity.Property(e => e.FbOrderby)
                .HasColumnName("FB_ORDERBY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRoom)
                .HasColumnName("FB_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FoodBookId)
                .HasColumnName("FOOD_BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodContainer)
                .HasColumnName("FOOD_CONTAINER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FoodCourse)
                .HasColumnName("FOOD_COURSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodDiscount)
                .HasColumnName("FOOD_DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodEndDate)
                .HasColumnName("FOOD_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FoodExp)
                .HasColumnName("FOOD_EXP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodGtd)
                .HasColumnName("FOOD_GTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodId)
                .HasColumnName("FOOD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodIncluded)
                .HasColumnName("FOOD_INCLUDED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FoodMenuId1)
                .HasColumnName("FOOD_MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodMitId)
                .HasColumnName("FOOD_MIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodName1)
                .HasColumnName("FOOD_NAME1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FoodName2)
                .HasColumnName("FOOD_NAME2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FoodName3)
                .HasColumnName("FOOD_NAME3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FoodPortion)
                .HasColumnName("FOOD_PORTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FoodPrice)
                .HasColumnName("FOOD_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodResort)
                .HasColumnName("FOOD_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FoodSet)
                .HasColumnName("FOOD_SET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodShow)
                .HasColumnName("FOOD_SHOW")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FoodStartDate)
                .HasColumnName("FOOD_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FoodYear)
                .HasColumnName("FOOD_YEAR")
                .HasColumnType("NUMBER(4)");

            entity.Property(e => e.FoodcombinedEventId)
                .HasColumnName("FOODCOMBINED_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodmenuDiscount)
                .HasColumnName("FOODMENU_DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodmenuExp)
                .HasColumnName("FOODMENU_EXP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodmenuExpPkg)
                .HasColumnName("FOODMENU_EXP_PKG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodmenuGtd)
                .HasColumnName("FOODMENU_GTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodmenuGtdPkg)
                .HasColumnName("FOODMENU_GTD_PKG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodmenuId)
                .HasColumnName("FOODMENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodmenuName)
                .HasColumnName("FOODMENU_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FoodmenuPkgId)
                .HasColumnName("FOODMENU_PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodmenuPrice)
                .HasColumnName("FOODMENU_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodmenuResort)
                .HasColumnName("FOODMENU_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FoodmenuServing)
                .HasColumnName("FOODMENU_SERVING")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.FoodmenuServingEnd)
                .HasColumnName("FOODMENU_SERVING_END")
                .HasColumnType("DATE");

            entity.Property(e => e.FoodmenuServingStart)
                .HasColumnName("FOODMENU_SERVING_START")
                .HasColumnType("DATE");

            entity.Property(e => e.FoodmenuSet)
                .HasColumnName("FOODMENU_SET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodresourceId)
                .HasColumnName("FOODRESOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FoodresourceIds)
                .HasColumnName("FOODRESOURCE_IDS")
                .IsUnicode(false);

            entity.Property(e => e.FoodresourceNoteId)
                .HasColumnName("FOODRESOURCE_NOTE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenuConsumptionYn)
                .HasColumnName("MENU_CONSUMPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailConsumptionYn)
                .HasColumnName("MENUDETAIL_CONSUMPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MenudetailCourseOrder)
                .HasColumnName("MENUDETAIL_COURSE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintFoodNotesYn)
                .HasColumnName("PRINT_FOOD_NOTES_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
