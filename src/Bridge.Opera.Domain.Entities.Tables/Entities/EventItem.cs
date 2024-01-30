namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventItem
{
    public EventItem()
    {
        EventItemDepartment = new HashSet<EventItemDepartment>();
    }

    public decimal? EventItemId { get; set; }
    public decimal? EventId { get; set; }
    public decimal? ItemId { get; set; }
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? PkgId { get; set; }
    public decimal? EventItemgId { get; set; }
    public decimal? ItmgId { get; set; }
    public decimal? OrderBy { get; set; }
    public string? CustomYn { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? GuaranteedQuantity { get; set; }
    public decimal? BilledQuantity { get; set; }
    public decimal? ActualQuantity { get; set; }
    public decimal? ActIntQuantity { get; set; }
    public decimal? ActExtQuantity { get; set; }
    public decimal? IntQuantity { get; set; }
    public decimal? IntCost { get; set; }
    public decimal? ExtQuantity { get; set; }
    public decimal? ExtCost { get; set; }
    public decimal? ActIntCost { get; set; }
    public decimal? ActExtCost { get; set; }
    public decimal? VendorId { get; set; }
    public string? HourlyYn { get; set; }
    public decimal? Price { get; set; }
    public string? PriceCode { get; set; }
    public decimal? Discount { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? RevenueType { get; set; }
    public decimal? ExpectedRevenue { get; set; }
    public decimal? GuaranteedRevenue { get; set; }
    public decimal? ActualRevenue { get; set; }
    public string? OrderExternalYn { get; set; }
    public string? ItmaName { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public string? ArticleNumber { get; set; }
    public string? ShowbeoYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ItemResort { get; set; }
    public decimal? ItmaId { get; set; }
    public decimal? ItemrateId { get; set; }
    public decimal? ItmcId { get; set; }
    public string? DiscountableYn { get; set; }

    public virtual GemEvent Event { get; set; }
    public virtual EventItemgroup EventItemg { get; set; }
    public virtual GemItemRates Itemrate { get; set; }
    public virtual ICollection<EventItemDepartment> EventItemDepartment { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventItem>(entity =>
        {
            entity.ToTable("EVENT$ITEM");

            entity.HasIndex(e => e.EventId)
                .HasName("EI_GE_IDX");

            entity.HasIndex(e => e.EventItemgId)
                .HasName("EI_EIG_IDX");

            entity.HasIndex(e => e.ItemrateId)
                .HasName("EI_ITMR_FK_IDX");

            entity.HasIndex(e => e.RevenueType)
                .HasName("EI_REVT_IDX");

            entity.HasIndex(e => new { e.ItemResort, e.ItemId })
                .HasName("EI_RESORTITEM_IDX");

            entity.HasIndex(e => new { e.Resort, e.BookId, e.EventId })
                .HasName("EI_BOOK_IDX");

            entity.Property(e => e.EventItemId)
                .HasColumnName("EVENT_ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActExtCost)
                .HasColumnName("ACT_EXT_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActExtQuantity)
                .HasColumnName("ACT_EXT_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActIntCost)
                .HasColumnName("ACT_INT_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActIntQuantity)
                .HasColumnName("ACT_INT_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualQuantity)
                .HasColumnName("ACTUAL_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualRevenue)
                .HasColumnName("ACTUAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArticleNumber)
                .HasColumnName("ARTICLE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BilledQuantity)
                .HasColumnName("BILLED_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CustomYn)
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountableYn)
                .HasColumnName("DISCOUNTABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventItemgId)
                .HasColumnName("EVENT_ITEMG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedRevenue)
                .HasColumnName("EXPECTED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtCost)
                .HasColumnName("EXT_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtQuantity)
                .HasColumnName("EXT_QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaranteedQuantity)
                .HasColumnName("GUARANTEED_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedRevenue)
                .HasColumnName("GUARANTEED_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HourlyYn)
                .HasColumnName("HOURLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IntCost)
                .HasColumnName("INT_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IntQuantity)
                .HasColumnName("INT_QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemResort)
                .HasColumnName("ITEM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemrateId)
                .HasColumnName("ITEMRATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItmaId)
                .HasColumnName("ITMA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItmaName)
                .HasColumnName("ITMA_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItmcId)
                .HasColumnName("ITMC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItmgId)
                .HasColumnName("ITMG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderExternalYn)
                .HasColumnName("ORDER_EXTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VendorId)
                .HasColumnName("VENDOR_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.EventItem)
	                .HasForeignKey(d => d.EventId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EI_GE_FK");

			if (!types.Contains(typeof(EventItemgroup)))
				entity.Ignore(e => e.EventItemg);
			else
	            entity.HasOne(d => d.EventItemg)
	                .WithMany(p => p.EventItem)
	                .HasForeignKey(d => d.EventItemgId)
	                .HasConstraintName("EI_EIG_FK");

			if (!types.Contains(typeof(GemItemRates)))
				entity.Ignore(e => e.Itemrate);
			else
	            entity.HasOne(d => d.Itemrate)
	                .WithMany(p => p.EventItem)
	                .HasForeignKey(d => d.ItemrateId)
	                .HasConstraintName("EI_ITMR_FK");
        
			if (!types.Contains(typeof(EventItemDepartment)))
				entity.Ignore(e => e.EventItemDepartment);
		});
	}
}
