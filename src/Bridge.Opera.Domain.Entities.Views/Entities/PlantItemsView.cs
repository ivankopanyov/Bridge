namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PlantItemsView
{
    public string Resort { get; set; }
    public string PlantItemCode { get; set; }
    public string PlantItemName { get; set; }
    public string TypeCode { get; set; }
    public string LocationCode { get; set; }
    public string Room { get; set; }
    public decimal? ActualYtd { get; set; }
    public decimal? BudgetYtd { get; set; }
    public string ExternalInfo { get; set; }
    public string PmRequiredYn { get; set; }
    public DateTime? LastMaintDate { get; set; }
    public DateTime? NextMaintDueDate { get; set; }
    public decimal? LastMaintTask { get; set; }
    public decimal? NextMaintTask { get; set; }
    public string TypeDesc { get; set; }
    public string LocationDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PlantItemsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PLANT_ITEMS_VIEW");

            entity.Property(e => e.ActualYtd)
                .HasColumnName("ACTUAL_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetYtd)
                .HasColumnName("BUDGET_YTD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExternalInfo)
                .HasColumnName("EXTERNAL_INFO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LastMaintDate)
                .HasColumnName("LAST_MAINT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastMaintTask)
                .HasColumnName("LAST_MAINT_TASK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LocationCode)
                .HasColumnName("LOCATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocationDesc)
                .HasColumnName("LOCATION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.NextMaintDueDate)
                .HasColumnName("NEXT_MAINT_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NextMaintTask)
                .HasColumnName("NEXT_MAINT_TASK")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PlantItemCode)
                .IsRequired()
                .HasColumnName("PLANT_ITEM_CODE")
                .HasMaxLength(40)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PlantItemName)
                .IsRequired()
                .HasColumnName("PLANT_ITEM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PmRequiredYn)
                .HasColumnName("PM_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeCode)
                .IsRequired()
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeDesc)
                .HasColumnName("TYPE_DESC")
                .IsUnicode(false);
        });
	}
}
