namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepInvForecastTmpview
{
    public decimal? ReportId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? DataLevel { get; set; }
    public DateTime? InventoryDate { get; set; }
    public decimal? AvailableQty { get; set; }
    public decimal? ReservedQty { get; set; }
    public string ItemCode { get; set; }
    public string ItemName { get; set; }
    public string Room { get; set; }
    public string RoomCategoryLabel { get; set; }
    public string ConfirmationNo { get; set; }
    public string DisplayName { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string ResStatus { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string RateCode { get; set; }
    public string Products { get; set; }
    public string AllotmentCode { get; set; }
    public string ItemPoolCode { get; set; }
    public string ItemPoolDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepInvForecastTmpview>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_INV_FORECAST_TMPVIEW");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AvailableQty)
                .HasColumnName("AVAILABLE_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DataLevel)
                .HasColumnName("DATA_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InventoryDate)
                .HasColumnName("INVENTORY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ItemCode)
                .HasColumnName("ITEM_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ItemPoolCode)
                .HasColumnName("ITEM_POOL_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ItemPoolDescription)
                .HasColumnName("ITEM_POOL_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Products)
                .HasColumnName("PRODUCTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResStatus)
                .HasColumnName("RES_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ReservedQty)
                .HasColumnName("RESERVED_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");
        });
	}
}
