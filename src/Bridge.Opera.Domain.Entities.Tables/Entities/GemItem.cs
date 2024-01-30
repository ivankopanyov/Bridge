namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItem
{
    public GemItem()
    {
        GemItemAttributes = new HashSet<GemItemAttributes>();
        GemItemDailyInventory = new HashSet<GemItemDailyInventory>();
        GemItemDepartment = new HashSet<GemItemDepartment>();
        GemItemRates = new HashSet<GemItemRates>();
        GemItemTranslation = new HashSet<GemItemTranslation>();
        GemItemVendor = new HashSet<GemItemVendor>();
        ItemEvtype = new HashSet<ItemEvtype>();
        ItemReservation = new HashSet<ItemReservation>();
    }

    public string? Resort { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? ItemclassId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? OrderExternalYn { get; set; }
    public string? CriticalYn { get; set; }
    public decimal? QtyInStock { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public string? ArticleNumber { get; set; }
    public string? RevenueType { get; set; }
    public decimal? Cost { get; set; }
    public string? ShowbeoYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? ObjectType { get; set; }
    public DateTime? AvailableFrom { get; set; }
    public DateTime? AvailableTo { get; set; }
    public string? DailyInventoryYn { get; set; }
    public decimal? DefaultQty { get; set; }
    public string? DiscountableYn { get; set; }
    public string? MandatoryYn { get; set; }
    public string? SellSeparate { get; set; }
    public decimal? ItemPoolId { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ActivityLinkYn { get; set; }
    public string? ActivityExtSystem { get; set; }
    public string? ActivityStatusCode { get; set; }
    public string? ActivityType { get; set; }
    public string? ActivityLocationCode { get; set; }
    public string? WebBookingYn { get; set; }
    public decimal? DefaultDuration { get; set; }
    public string? AllowedOutsideStayYn { get; set; }
    public string? PromptFixedChargesYn { get; set; }
    public string? BraceletRuleCode { get; set; }
    public string? DisplayColor { get; set; }

    public virtual GemItemPool ItemPool { get; set; }
    public virtual GemItemClass Itemclass { get; set; }
    public virtual ICollection<GemItemAttributes> GemItemAttributes { get; set; }
    public virtual ICollection<GemItemDailyInventory> GemItemDailyInventory { get; set; }
    public virtual ICollection<GemItemDepartment> GemItemDepartment { get; set; }
    public virtual ICollection<GemItemRates> GemItemRates { get; set; }
    public virtual ICollection<GemItemTranslation> GemItemTranslation { get; set; }
    public virtual ICollection<GemItemVendor> GemItemVendor { get; set; }
    public virtual ICollection<ItemEvtype> ItemEvtype { get; set; }
    public virtual ICollection<ItemReservation> ItemReservation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItem>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ItemId })
                .HasName("ITM_PK");

            entity.ToTable("GEM$ITEM");

            entity.HasIndex(e => e.ItemPoolId)
                .HasName("ITM_ITMPOOL_IDX");

            entity.HasIndex(e => e.ItemclassId)
                .HasName("ITM_ITMC_IDX");

            entity.HasIndex(e => e.RevenueType)
                .HasName("ITM_REVTYPE_IDX");

            entity.HasIndex(e => new { e.Resort, e.ArticleNumber })
                .HasName("ITM_ARTICLENO_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.BraceletRuleCode })
                .HasName("ITM_BRACELET_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActivityExtSystem)
                .HasColumnName("ACTIVITY_EXT_SYSTEM")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActivityLinkYn)
                .HasColumnName("ACTIVITY_LINK_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActivityLocationCode)
                .HasColumnName("ACTIVITY_LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActivityStatusCode)
                .HasColumnName("ACTIVITY_STATUS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActivityType)
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AllowedOutsideStayYn)
                .HasColumnName("ALLOWED_OUTSIDE_STAY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArticleNumber)
                .HasColumnName("ARTICLE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AvailableFrom)
                .HasColumnName("AVAILABLE_FROM")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AvailableTo)
                .HasColumnName("AVAILABLE_TO")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BraceletRuleCode)
                .HasColumnName("BRACELET_RULE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Cost)
                .HasColumnName("COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CriticalYn)
                .HasColumnName("CRITICAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DailyInventoryYn)
                .HasColumnName("DAILY_INVENTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultDuration)
                .HasColumnName("DEFAULT_DURATION")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DefaultQty)
                .HasColumnName("DEFAULT_QTY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountableYn)
                .HasColumnName("DISCOUNTABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayColor)
                .HasColumnName("DISPLAY_COLOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemPoolId)
                .HasColumnName("ITEM_POOL_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemclassId)
                .HasColumnName("ITEMCLASS_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MandatoryYn)
                .HasColumnName("MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObjectType)
                .HasColumnName("OBJECT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderExternalYn)
                .HasColumnName("ORDER_EXTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PromptFixedChargesYn)
                .HasColumnName("PROMPT_FIXED_CHARGES_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.QtyInStock)
                .HasColumnName("QTY_IN_STOCK")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SellSeparate)
                .HasColumnName("SELL_SEPARATE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShowbeoYn)
                .HasColumnName("SHOWBEO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(GemItemPool)))
				entity.Ignore(e => e.ItemPool);
			else
	            entity.HasOne(d => d.ItemPool)
	                .WithMany(p => p.GemItem)
	                .HasForeignKey(d => d.ItemPoolId)
	                .HasConstraintName("ITM_ITMPOOL_FK");

			if (!types.Contains(typeof(GemItemClass)))
				entity.Ignore(e => e.Itemclass);
			else
	            entity.HasOne(d => d.Itemclass)
	                .WithMany(p => p.GemItem)
	                .HasForeignKey(d => d.ItemclassId)
	                .HasConstraintName("ITM_ITMC_FK");
        
			if (!types.Contains(typeof(GemItemAttributes)))
				entity.Ignore(e => e.GemItemAttributes);

			if (!types.Contains(typeof(GemItemDailyInventory)))
				entity.Ignore(e => e.GemItemDailyInventory);

			if (!types.Contains(typeof(GemItemDepartment)))
				entity.Ignore(e => e.GemItemDepartment);

			if (!types.Contains(typeof(GemItemRates)))
				entity.Ignore(e => e.GemItemRates);

			if (!types.Contains(typeof(GemItemTranslation)))
				entity.Ignore(e => e.GemItemTranslation);

			if (!types.Contains(typeof(GemItemVendor)))
				entity.Ignore(e => e.GemItemVendor);

			if (!types.Contains(typeof(ItemEvtype)))
				entity.Ignore(e => e.ItemEvtype);

			if (!types.Contains(typeof(ItemReservation)))
				entity.Ignore(e => e.ItemReservation);
		});
	}
}
