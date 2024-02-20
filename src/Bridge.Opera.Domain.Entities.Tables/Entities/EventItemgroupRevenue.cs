namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventItemgroupRevenue
{
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? EventId { get; set; }
    public decimal? EventItemgId { get; set; }
    public string? CustomYn { get; set; }
    public decimal? ItemCost { get; set; }
    public decimal? ItemPrice { get; set; }
    public decimal? RevenueSplit { get; set; }
    public decimal? Discount { get; set; }
    public string? RevGroup { get; set; }
    public string? RevType { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? ItemgroupId { get; set; }
    public string? HourlyYn { get; set; }
    public decimal? EventExpected { get; set; }
    public decimal? EventGuaranteed { get; set; }
    public decimal? EventActual { get; set; }
    public DateTime? EventStart { get; set; }
    public DateTime? EventEnd { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual EventItemgroup EventItemg { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventItemgroupRevenue>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EVENT$ITEMGROUP_REVENUE");

            entity.HasIndex(e => e.EventItemgId)
                .HasName("EVITMGREV_ITEMG_IDX");

            entity.HasIndex(e => new { e.Resort, e.BookId, e.EventId, e.EventItemgId, e.RevType })
                .HasName("EVITMGREV_UK")
                .IsUnique();

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CustomYn)
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventActual)
                .HasColumnName("EVENT_ACTUAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventEnd)
                .HasColumnName("EVENT_END")
                .HasColumnType("DATE");

            entity.Property(e => e.EventExpected)
                .HasColumnName("EVENT_EXPECTED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventGuaranteed)
                .HasColumnName("EVENT_GUARANTEED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventItemgId)
                .HasColumnName("EVENT_ITEMG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventStart)
                .HasColumnName("EVENT_START")
                .HasColumnType("DATE");

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

            entity.Property(e => e.ItemCost)
                .HasColumnName("ITEM_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemPrice)
                .HasColumnName("ITEM_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemgroupId)
                .HasColumnName("ITEMGROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevGroup)
                .IsRequired()
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueSplit)
                .HasColumnName("REVENUE_SPLIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(EventItemgroup)))
				entity.Ignore(e => e.EventItemg);
			else
	            entity.HasOne(d => d.EventItemg)
	                .WithMany()
	                .HasForeignKey(d => d.EventItemgId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EVITMGREV_EVP_FK");
        });
	}
}
