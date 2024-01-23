namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepBeoItemCombined
{
    public string Resort { get; set; }
    public decimal ItemBookId { get; set; }
    public decimal? CombinedEventId { get; set; }
    public decimal? EventId { get; set; }
    public string EventItemResourceIds { get; set; }
    public decimal? ClassId { get; set; }
    public string ClassName { get; set; }
    public string ClassResort { get; set; }
    public string ItemName { get; set; }
    public string ItemOrderBy { get; set; }
    public string ItemRooms { get; set; }
    public DateTime ItemStartDate { get; set; }
    public DateTime ItemEndDate { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? ItemPkgId { get; set; }
    public string ItmaName { get; set; }
    public decimal? ItemQuantity { get; set; }
    public string ItemAttribute { get; set; }
    public decimal? ItemPrice { get; set; }
    public string ItemPriceCode { get; set; }
    public string ItemPriceName { get; set; }
    public string ItemStartTimeForm { get; set; }
    public string ItemEndTimeForm { get; set; }
    public DateTime? ItemStartTime { get; set; }
    public DateTime? ItemEndTime { get; set; }
    public decimal? ItemVendorId { get; set; }
    public string ItemVendorName { get; set; }
    public string ItemVendorPhone { get; set; }
    public decimal? EventitemPrice { get; set; }
    public decimal? EventitemDiscount { get; set; }
    public decimal? EventitemClassOrderBy { get; set; }
    public decimal? EventitemItemOrderBy { get; set; }
    public string ItemShow { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepBeoItemCombined>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_BEO_ITEM_COMBINED");

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

            entity.Property(e => e.CombinedEventId)
                .HasColumnName("COMBINED_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventItemResourceIds)
                .HasColumnName("EVENT_ITEM_RESOURCE_IDS")
                .IsUnicode(false);

            entity.Property(e => e.EventitemClassOrderBy)
                .HasColumnName("EVENTITEM_CLASS_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemDiscount)
                .HasColumnName("EVENTITEM_DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemItemOrderBy)
                .HasColumnName("EVENTITEM_ITEM_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventitemPrice)
                .HasColumnName("EVENTITEM_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemAttribute)
                .HasColumnName("ITEM_ATTRIBUTE")
                .IsUnicode(false);

            entity.Property(e => e.ItemBookId)
                .HasColumnName("ITEM_BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemEndDate)
                .HasColumnName("ITEM_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ItemEndTime)
                .HasColumnName("ITEM_END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ItemEndTimeForm)
                .HasColumnName("ITEM_END_TIME_FORM")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ItemOrderBy)
                .HasColumnName("ITEM_ORDER_BY")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.ItemPkgId)
                .HasColumnName("ITEM_PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemPrice)
                .HasColumnName("ITEM_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemPriceCode)
                .HasColumnName("ITEM_PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemPriceName)
                .HasColumnName("ITEM_PRICE_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ItemQuantity)
                .HasColumnName("ITEM_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemRooms)
                .HasColumnName("ITEM_ROOMS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemShow)
                .HasColumnName("ITEM_SHOW")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ItemStartDate)
                .HasColumnName("ITEM_START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ItemStartTime)
                .HasColumnName("ITEM_START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ItemStartTimeForm)
                .HasColumnName("ITEM_START_TIME_FORM")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ItemVendorId)
                .HasColumnName("ITEM_VENDOR_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemVendorName)
                .HasColumnName("ITEM_VENDOR_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ItemVendorPhone)
                .HasColumnName("ITEM_VENDOR_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.ItmaName)
                .HasColumnName("ITMA_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
