namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBeoItem
{
    public decimal BookId { get; set; }
    public string Resort { get; set; }
    public DateTime ItemStartDate { get; set; }
    public DateTime ItemEndDate { get; set; }
    public string EventItemStartDate { get; set; }
    public decimal EventId { get; set; }
    public string EventName { get; set; }
    public string EventTime { get; set; }
    public string EventRoom { get; set; }
    public decimal? ClassId { get; set; }
    public string ClassResort { get; set; }
    public string ClassName { get; set; }
    public string ItemName { get; set; }
    public string ItemShow { get; set; }
    public string EventType { get; set; }
    public decimal? EventitemEventId { get; set; }
    public decimal? EventitemEventItemId { get; set; }
    public decimal? EventitemPkgId { get; set; }
    public string EventitemName { get; set; }
    public string EventitemItmaName { get; set; }
    public string EventitemDescription { get; set; }
    public string EventitemStartTimeForm { get; set; }
    public string EventitemEndTimeForm { get; set; }
    public DateTime? EventitemStartTime { get; set; }
    public DateTime? EventitemEndTime { get; set; }
    public decimal? EventitemQuantity { get; set; }
    public decimal? EventitemPrice { get; set; }
    public string EventitemArticleNumber { get; set; }
    public decimal? EventitemItemId { get; set; }
    public decimal? EventitemItmgId { get; set; }
    public string EventitemPriceCode { get; set; }
    public string EventitemPriceName { get; set; }
    public decimal? EventresourcePkgId { get; set; }
    public string EventitemAttr { get; set; }
    public decimal? EventitemVendorId { get; set; }
    public string EventitemVendorName { get; set; }
    public string EventitemVendorPhone { get; set; }
    public string EventitemOrderBy { get; set; }
    public decimal? EventitemClassOrderBy { get; set; }
    public decimal? EventitemItemOrderBy { get; set; }
    public decimal? EventitemItemPrice { get; set; }
    public decimal? EventitemItemDiscount { get; set; }
    public string ItemClassCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBeoItem>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BEO_ITEM");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClassId)
                .HasColumnName("CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClassName)
                .HasColumnName("CLASS_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ClassResort)
                .HasColumnName("CLASS_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventItemStartDate)
                .HasColumnName("EVENT_ITEM_START_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EventName)
                .IsRequired()
                .HasColumnName("EVENT_NAME")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.EventRoom)
                .HasColumnName("EVENT_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventTime)
                .HasColumnName("EVENT_TIME")
                .HasMaxLength(153)
                .IsUnicode(false);

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EventitemArticleNumber)
                .HasColumnName("EVENTITEM_ARTICLE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventitemAttr)
                .HasColumnName("EVENTITEM_ATTR")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EventitemClassOrderBy)
                .HasColumnName("EVENTITEM_CLASS_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemDescription)
                .HasColumnName("EVENTITEM_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EventitemEndTime)
                .HasColumnName("EVENTITEM_END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.EventitemEndTimeForm)
                .HasColumnName("EVENTITEM_END_TIME_FORM")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EventitemEventId)
                .HasColumnName("EVENTITEM_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemEventItemId)
                .HasColumnName("EVENTITEM_EVENT_ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemItemDiscount)
                .HasColumnName("EVENTITEM_ITEM_DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemItemId)
                .HasColumnName("EVENTITEM_ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemItemOrderBy)
                .HasColumnName("EVENTITEM_ITEM_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemItemPrice)
                .HasColumnName("EVENTITEM_ITEM_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemItmaName)
                .HasColumnName("EVENTITEM_ITMA_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EventitemItmgId)
                .HasColumnName("EVENTITEM_ITMG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemName)
                .HasColumnName("EVENTITEM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EventitemOrderBy)
                .HasColumnName("EVENTITEM_ORDER_BY")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.EventitemPkgId)
                .HasColumnName("EVENTITEM_PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemPrice)
                .HasColumnName("EVENTITEM_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemPriceCode)
                .HasColumnName("EVENTITEM_PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EventitemPriceName)
                .HasColumnName("EVENTITEM_PRICE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.EventitemQuantity)
                .HasColumnName("EVENTITEM_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemStartTime)
                .HasColumnName("EVENTITEM_START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.EventitemStartTimeForm)
                .HasColumnName("EVENTITEM_START_TIME_FORM")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EventitemVendorId)
                .HasColumnName("EVENTITEM_VENDOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemVendorName)
                .HasColumnName("EVENTITEM_VENDOR_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EventitemVendorPhone)
                .HasColumnName("EVENTITEM_VENDOR_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.EventresourcePkgId)
                .HasColumnName("EVENTRESOURCE_PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemClassCode)
                .HasColumnName("ITEM_CLASS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemEndDate)
                .HasColumnName("ITEM_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ItemShow)
                .HasColumnName("ITEM_SHOW")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ItemStartDate)
                .HasColumnName("ITEM_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
