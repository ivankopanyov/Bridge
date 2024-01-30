namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventResources
{
    public string? ResourceType { get; set; }
    public decimal? ResourceGroupId { get; set; }
    public decimal? ResourceId { get; set; }
    public string? ResourceName { get; set; }
    public string? SetupOrAttribute { get; set; }
    public string? Quantity { get; set; }
    public string? QuantityIncl { get; set; }
    public string? QuantityExcl { get; set; }
    public string? UnitPrice { get; set; }
    public string? Revenue { get; set; }
    public string? Code { get; set; }
    public string? Resort { get; set; }
    public decimal? EventId { get; set; }
    public decimal? BookId { get; set; }
    public string? NotesYn { get; set; }
    public string? ExternalOrderYn { get; set; }
    public decimal? ResourceSegment { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? PkgId { get; set; }
    public decimal? ClassId { get; set; }
    public string? OrderByChar { get; set; }
    public string? OrderByResort { get; set; }
    public decimal? Discount { get; set; }
    public string? FinTrxYn { get; set; }
    public string? HasDiscountedMenuItemsYn { get; set; }
    public string? DiscountableYn { get; set; }
    public string? ResourceConfigId { get; set; }
    public string? ResourceConfigResort { get; set; }
    public decimal? RoomRateAmount { get; set; }
    public decimal? RoomDiscountAmount { get; set; }
    public string? CustomYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventResources>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_RESOURCES");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClassId)
                .HasColumnName("CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CustomYn)
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DiscountableYn)
                .HasColumnName("DISCOUNTABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalOrderYn)
                .HasColumnName("EXTERNAL_ORDER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FinTrxYn)
                .HasColumnName("FIN_TRX_YN")
                .IsUnicode(false);

            entity.Property(e => e.HasDiscountedMenuItemsYn)
                .HasColumnName("HAS_DISCOUNTED_MENU_ITEMS_YN")
                .IsUnicode(false);

            entity.Property(e => e.NotesYn)
                .HasColumnName("NOTES_YN")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderByChar)
                .HasColumnName("ORDER_BY_CHAR")
                .HasMaxLength(81)
                .IsUnicode(false);

            entity.Property(e => e.OrderByResort)
                .HasColumnName("ORDER_BY_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasMaxLength(83)
                .IsUnicode(false);

            entity.Property(e => e.QuantityExcl)
                .HasColumnName("QUANTITY_EXCL")
                .HasMaxLength(83)
                .IsUnicode(false);

            entity.Property(e => e.QuantityIncl)
                .HasColumnName("QUANTITY_INCL")
                .HasMaxLength(83)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResourceConfigId)
                .HasColumnName("RESOURCE_CONFIG_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ResourceConfigResort)
                .HasColumnName("RESOURCE_CONFIG_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResourceGroupId)
                .HasColumnName("RESOURCE_GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceId)
                .HasColumnName("RESOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceName)
                .HasColumnName("RESOURCE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResourceSegment)
                .HasColumnName("RESOURCE_SEGMENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceType)
                .HasColumnName("RESOURCE_TYPE")
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .IsUnicode(false);

            entity.Property(e => e.RoomDiscountAmount)
                .HasColumnName("ROOM_DISCOUNT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomRateAmount)
                .HasColumnName("ROOM_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupOrAttribute)
                .HasColumnName("SETUP_OR_ATTRIBUTE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .IsUnicode(false);
        });
	}
}
