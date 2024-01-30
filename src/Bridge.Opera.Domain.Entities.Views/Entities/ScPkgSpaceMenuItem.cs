namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScPkgSpaceMenuItem
{
    public decimal? PkgEvLink { get; set; }
    public string? Resort { get; set; }
    public decimal? MenuItemId { get; set; }
    public string? Name { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Type { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? ItmaId { get; set; }
    public decimal? ItemrateId { get; set; }
    public decimal? Price { get; set; }
    public decimal? ItemClassOrderBy { get; set; }
    public string? SetupCode { get; set; }
    public string? RateCode { get; set; }
    public string? Room { get; set; }
    public string? ShareableYn { get; set; }
    public string? WebBookableYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPkgSpaceMenuItem>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_PKG_SPACE_MENU_ITEM");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemClassOrderBy)
                .HasColumnName("ITEM_CLASS_ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemrateId)
                .HasColumnName("ITEMRATE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItmaId)
                .HasColumnName("ITMA_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MenuItemId)
                .HasColumnName("MENU_ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PkgEvLink)
                .HasColumnName("PKG_EV_LINK")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetupCode)
                .HasColumnName("SETUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShareableYn)
                .HasColumnName("SHAREABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(5)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WebBookableYn)
                .HasColumnName("WEB_BOOKABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
