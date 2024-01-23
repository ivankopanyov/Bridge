namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBeoBeverageCombined
{
    public string Resort { get; set; }
    public decimal BevBookId { get; set; }
    public decimal? BeveragecombinedEventId { get; set; }
    public decimal? FbOrderby1 { get; set; }
    public decimal? BeverageCourse { get; set; }
    public decimal? BeverageCourseOrder { get; set; }
    public decimal? FbEventId1 { get; set; }
    public string FbRoom1 { get; set; }
    public DateTime BeverageStartDate { get; set; }
    public DateTime BeverageEndDate { get; set; }
    public decimal? BeveragemenuId { get; set; }
    public decimal? BeverageresourceId { get; set; }
    public string BeverageresourceIds { get; set; }
    public string BeveragemenuName { get; set; }
    public decimal? BeveragemenuPkgId { get; set; }
    public decimal? BeveragemenuExp { get; set; }
    public decimal? BeveragemenuGtd { get; set; }
    public decimal? BeveragemenuSet { get; set; }
    public decimal? BeveragemenuPrice { get; set; }
    public string BeveragemenuConsumption { get; set; }
    public string BeveragemenuResort { get; set; }
    public string BeveragemenuServing { get; set; }
    public DateTime? BeveragemenuServingStart { get; set; }
    public DateTime? BeveragemenuServingEnd { get; set; }
    public string BeverageResort { get; set; }
    public decimal? BeverageId { get; set; }
    public decimal? BeverageMenuId1 { get; set; }
    public decimal? BeverageMitId { get; set; }
    public decimal? BeverageExp { get; set; }
    public decimal? BeverageGtd { get; set; }
    public decimal? BeverageSet { get; set; }
    public string BeverageIncluded { get; set; }
    public decimal? BeveragePrice { get; set; }
    public decimal? BevmenudetPrice { get; set; }
    public decimal? BevmenudetDiscount { get; set; }
    public string BeveragePortion { get; set; }
    public string BeverageContainer { get; set; }
    public byte? BeverageYear { get; set; }
    public string BeverageName1 { get; set; }
    public string BeverageName2 { get; set; }
    public string BeverageName3 { get; set; }
    public string BeverageOrigin1 { get; set; }
    public string BeverageOrigin2 { get; set; }
    public string BeverageOrigin3 { get; set; }
    public string BeverageShow { get; set; }
    public string BeveragedetailConsumption { get; set; }
    public decimal? BeveragedetailPrice { get; set; }
    public string BeveragedetailIncluded { get; set; }
    public decimal? BeverageresourceNoteId { get; set; }
    public string PrintBevNotesYn { get; set; }
    public decimal? BeveragemenuGtdPkg { get; set; }
    public decimal? BeveragemenuExpPkg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBeoBeverageCombined>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BEO_BEVERAGE_COMBINED");

            entity.Property(e => e.BevBookId)
                .HasColumnName("BEV_BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageContainer)
                .HasColumnName("BEVERAGE_CONTAINER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BeverageCourse)
                .HasColumnName("BEVERAGE_COURSE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageCourseOrder)
                .HasColumnName("BEVERAGE_COURSE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageEndDate)
                .HasColumnName("BEVERAGE_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BeverageExp)
                .HasColumnName("BEVERAGE_EXP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageGtd)
                .HasColumnName("BEVERAGE_GTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageId)
                .HasColumnName("BEVERAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageIncluded)
                .HasColumnName("BEVERAGE_INCLUDED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeverageMenuId1)
                .HasColumnName("BEVERAGE_MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageMitId)
                .HasColumnName("BEVERAGE_MIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageName1)
                .HasColumnName("BEVERAGE_NAME1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BeverageName2)
                .HasColumnName("BEVERAGE_NAME2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BeverageName3)
                .HasColumnName("BEVERAGE_NAME3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BeverageOrigin1)
                .HasColumnName("BEVERAGE_ORIGIN1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BeverageOrigin2)
                .HasColumnName("BEVERAGE_ORIGIN2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BeverageOrigin3)
                .HasColumnName("BEVERAGE_ORIGIN3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BeveragePortion)
                .HasColumnName("BEVERAGE_PORTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BeveragePrice)
                .HasColumnName("BEVERAGE_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageResort)
                .HasColumnName("BEVERAGE_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeverageSet)
                .HasColumnName("BEVERAGE_SET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageShow)
                .HasColumnName("BEVERAGE_SHOW")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeverageStartDate)
                .HasColumnName("BEVERAGE_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BeverageYear)
                .HasColumnName("BEVERAGE_YEAR")
                .HasColumnType("NUMBER(4)");

            entity.Property(e => e.BeveragecombinedEventId)
                .HasColumnName("BEVERAGECOMBINED_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeveragedetailConsumption)
                .HasColumnName("BEVERAGEDETAIL_CONSUMPTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeveragedetailIncluded)
                .HasColumnName("BEVERAGEDETAIL_INCLUDED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeveragedetailPrice)
                .HasColumnName("BEVERAGEDETAIL_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeveragemenuConsumption)
                .HasColumnName("BEVERAGEMENU_CONSUMPTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeveragemenuExp)
                .HasColumnName("BEVERAGEMENU_EXP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeveragemenuExpPkg)
                .HasColumnName("BEVERAGEMENU_EXP_PKG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeveragemenuGtd)
                .HasColumnName("BEVERAGEMENU_GTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeveragemenuGtdPkg)
                .HasColumnName("BEVERAGEMENU_GTD_PKG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeveragemenuId)
                .HasColumnName("BEVERAGEMENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeveragemenuName)
                .HasColumnName("BEVERAGEMENU_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BeveragemenuPkgId)
                .HasColumnName("BEVERAGEMENU_PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeveragemenuPrice)
                .HasColumnName("BEVERAGEMENU_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeveragemenuResort)
                .HasColumnName("BEVERAGEMENU_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeveragemenuServing)
                .HasColumnName("BEVERAGEMENU_SERVING")
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.BeveragemenuServingEnd)
                .HasColumnName("BEVERAGEMENU_SERVING_END")
                .HasColumnType("DATE");

            entity.Property(e => e.BeveragemenuServingStart)
                .HasColumnName("BEVERAGEMENU_SERVING_START")
                .HasColumnType("DATE");

            entity.Property(e => e.BeveragemenuSet)
                .HasColumnName("BEVERAGEMENU_SET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageresourceId)
                .HasColumnName("BEVERAGERESOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageresourceIds)
                .HasColumnName("BEVERAGERESOURCE_IDS")
                .IsUnicode(false);

            entity.Property(e => e.BeverageresourceNoteId)
                .HasColumnName("BEVERAGERESOURCE_NOTE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BevmenudetDiscount)
                .HasColumnName("BEVMENUDET_DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BevmenudetPrice)
                .HasColumnName("BEVMENUDET_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbEventId1)
                .HasColumnName("FB_EVENT_ID1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbOrderby1)
                .HasColumnName("FB_ORDERBY1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbRoom1)
                .HasColumnName("FB_ROOM1")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrintBevNotesYn)
                .HasColumnName("PRINT_BEV_NOTES_YN")
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
