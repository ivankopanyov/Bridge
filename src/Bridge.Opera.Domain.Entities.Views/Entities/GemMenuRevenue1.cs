namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemMenuRevenue1
{
    public decimal? MenuId { get; set; }
    public string? RevType { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? ItemCost { get; set; }
    public decimal? ItemPrice { get; set; }
    public decimal? RevenueSplit { get; set; }
    public string? CustomYn { get; set; }
    public decimal? DemandCost { get; set; }
    public decimal? DemandPrice { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? RevGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuRevenue1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_MENU_REVENUE");

            entity.Property(e => e.CustomYn)
                .HasColumnName("CUSTOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DemandCost)
                .HasColumnName("DEMAND_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DemandPrice)
                .HasColumnName("DEMAND_PRICE")
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

            entity.Property(e => e.MenuId)
                .HasColumnName("MENU_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevType)
                .IsRequired()
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevenueSplit)
                .HasColumnName("REVENUE_SPLIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
