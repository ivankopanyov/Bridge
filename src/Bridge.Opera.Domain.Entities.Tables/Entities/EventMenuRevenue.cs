namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventMenuRevenue
{
    public decimal? EventId { get; set; }
    public decimal? EventMenuId { get; set; }
    public string? RevType { get; set; }
    public string? CustomYn { get; set; }
    public decimal? BookId { get; set; }
    public string? Resort { get; set; }
    public string? RevGroup { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? RevenueSplit { get; set; }
    public decimal? ItemPrice { get; set; }
    public decimal? ItemCost { get; set; }
    public decimal? ExpectedPrice { get; set; }
    public decimal? ExpectedNumber { get; set; }
    public decimal? ExpectedCost { get; set; }
    public decimal? GuaranteedNumber { get; set; }
    public decimal? GuaranteedPrice { get; set; }
    public decimal? GuaranteedCost { get; set; }
    public decimal? ActualNumber { get; set; }
    public decimal? ActualPrice { get; set; }
    public decimal? ActualCost { get; set; }
    public decimal? BilledNumber { get; set; }
    public decimal? BilledPrice { get; set; }
    public decimal? BilledCost { get; set; }
    public decimal? ComplimentaryNumber { get; set; }
    public decimal? ExpExtraRevenue { get; set; }
    public decimal? GuaExtraRevenue { get; set; }
    public decimal? ActExtraRevenue { get; set; }
    public decimal? BilledExtraRevenue { get; set; }
    public decimal? ExpExtraCost { get; set; }
    public decimal? GuaExtraCost { get; set; }
    public decimal? ActExtraCost { get; set; }
    public decimal? BilledExtraCost { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? Discount { get; set; }

    public virtual EventMenu Event { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventMenuRevenue>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BookId, e.EventId, e.EventMenuId, e.RevType, e.CustomYn })
                .HasName("EMR_PK");

            entity.ToTable("EVENT$MENU_REVENUE");

            entity.HasIndex(e => e.RevType)
                .HasName("EMR_REVTYPE_IDX");

            entity.HasIndex(e => new { e.EventMenuId, e.EventId })
                .HasName("EMR_EVM_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventMenuId)
                .HasColumnName("EVENT_MENU_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CustomYn)
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.ActExtraCost)
                .HasColumnName("ACT_EXTRA_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActExtraRevenue)
                .HasColumnName("ACT_EXTRA_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCost)
                .HasColumnName("ACTUAL_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualNumber)
                .HasColumnName("ACTUAL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualPrice)
                .HasColumnName("ACTUAL_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledCost)
                .HasColumnName("BILLED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledExtraCost)
                .HasColumnName("BILLED_EXTRA_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledExtraRevenue)
                .HasColumnName("BILLED_EXTRA_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledNumber)
                .HasColumnName("BILLED_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BilledPrice)
                .HasColumnName("BILLED_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComplimentaryNumber)
                .HasColumnName("COMPLIMENTARY_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpExtraCost)
                .HasColumnName("EXP_EXTRA_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpExtraRevenue)
                .HasColumnName("EXP_EXTRA_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedCost)
                .HasColumnName("EXPECTED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedNumber)
                .HasColumnName("EXPECTED_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExpectedPrice)
                .HasColumnName("EXPECTED_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaExtraCost)
                .HasColumnName("GUA_EXTRA_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaExtraRevenue)
                .HasColumnName("GUA_EXTRA_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedCost)
                .HasColumnName("GUARANTEED_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedNumber)
                .HasColumnName("GUARANTEED_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteedPrice)
                .HasColumnName("GUARANTEED_PRICE")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
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

			if (!types.Contains(typeof(EventMenu)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.EventMenuRevenue)
	                .HasForeignKey(d => new { d.EventMenuId, d.EventId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EMR_EVM_FK");
        });
	}
}
