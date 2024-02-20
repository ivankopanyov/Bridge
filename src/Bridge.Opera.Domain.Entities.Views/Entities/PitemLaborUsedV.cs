namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PitemLaborUsedV
{
    public string? PlantItemCode { get; set; }
    public string? PlantItemName { get; set; }
    public decimal? WoNumber { get; set; }
    public string? TypeCode { get; set; }
    public decimal? CompletedBy { get; set; }
    public string? Resort { get; set; }
    public string? UserName { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string? DurationWorked { get; set; }
    public string? LaborCostCurrency { get; set; }
    public decimal? LaborCost { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PitemLaborUsedV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PITEM_LABOR_USED_V");

            entity.Property(e => e.CompletedBy)
                .HasColumnName("COMPLETED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompletedDate)
                .HasColumnName("COMPLETED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DurationWorked)
                .HasColumnName("DURATION_WORKED")
                .IsUnicode(false);

            entity.Property(e => e.LaborCost)
                .HasColumnName("LABOR_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaborCostCurrency)
                .HasColumnName("LABOR_COST_CURRENCY")
                .IsUnicode(false);

            entity.Property(e => e.PlantItemCode)
                .IsRequired()
                .HasColumnName("PLANT_ITEM_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PlantItemName)
                .IsRequired()
                .HasColumnName("PLANT_ITEM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeCode)
                .IsRequired()
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.WoNumber)
                .HasColumnName("WO_NUMBER")
                .HasColumnType("NUMBER");
        });
	}
}
