namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventMenuRevenue1
{
    public decimal BookId { get; set; }
    public string CustomYn { get; set; }
    public decimal EventId { get; set; }
    public decimal EventMenuId { get; set; }
    public decimal? OrderBy { get; set; }
    public string Resort { get; set; }
    public string RevGroup { get; set; }
    public string RevType { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? ExpectedNumber { get; set; }
    public decimal? GuaranteedNumber { get; set; }
    public decimal? ActualNumber { get; set; }
    public decimal? ExpExtraRevenue { get; set; }
    public decimal? GuaExtraRevenue { get; set; }
    public decimal? ActExtraRevenue { get; set; }
    public decimal? RevenueSplit { get; set; }
    public decimal? BilledNumber { get; set; }
    public decimal? ComplimentaryNumber { get; set; }
    public decimal? BilledExtraRevenue { get; set; }
    public decimal? ExpectedCost { get; set; }
    public decimal? ExpectedPrice { get; set; }
    public decimal? GuaranteedCost { get; set; }
    public decimal? GuaranteedPrice { get; set; }
    public decimal? ActualCost { get; set; }
    public decimal? ActualPrice { get; set; }
    public decimal? BilledCost { get; set; }
    public decimal? BilledPrice { get; set; }
    public decimal? ExpExtraCost { get; set; }
    public decimal? GuaExtraCost { get; set; }
    public decimal? ActExtraCost { get; set; }
    public decimal? BilledExtraCost { get; set; }
    public decimal? Discount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventMenuRevenue1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_MENU_REVENUE");

            entity.Property(e => e.ActExtraCost)
                .HasColumnName("ACT_EXTRA_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActExtraRevenue)
                .HasColumnName("ACT_EXTRA_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActualCost)
                .HasColumnName("ACTUAL_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActualNumber)
                .HasColumnName("ACTUAL_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActualPrice)
                .HasColumnName("ACTUAL_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BilledCost)
                .HasColumnName("BILLED_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BilledExtraCost)
                .HasColumnName("BILLED_EXTRA_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BilledExtraRevenue)
                .HasColumnName("BILLED_EXTRA_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BilledNumber)
                .HasColumnName("BILLED_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BilledPrice)
                .HasColumnName("BILLED_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ComplimentaryNumber)
                .HasColumnName("COMPLIMENTARY_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CustomYn)
                .IsRequired()
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventMenuId)
                .HasColumnName("EVENT_MENU_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpExtraCost)
                .HasColumnName("EXP_EXTRA_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpExtraRevenue)
                .HasColumnName("EXP_EXTRA_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpectedCost)
                .HasColumnName("EXPECTED_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpectedNumber)
                .HasColumnName("EXPECTED_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpectedPrice)
                .HasColumnName("EXPECTED_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaExtraCost)
                .HasColumnName("GUA_EXTRA_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaExtraRevenue)
                .HasColumnName("GUA_EXTRA_REVENUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaranteedCost)
                .HasColumnName("GUARANTEED_COST")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaranteedNumber)
                .HasColumnName("GUARANTEED_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuaranteedPrice)
                .HasColumnName("GUARANTEED_PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueSplit)
                .HasColumnName("REVENUE_SPLIT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
