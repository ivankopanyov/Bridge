namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCatStatusDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? Status { get; set; }
    public string? Description { get; set; }
    public string? DeductInventory { get; set; }
    public string? AllowPickup { get; set; }
    public string? ReturnToInventory { get; set; }
    public string? StatusType { get; set; }
    public string? StartingStatus { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Color { get; set; }
    public string? CatStatusType { get; set; }
    public string? CatDeductInventory { get; set; }
    public string? LeadStatusYn { get; set; }
    public string? DeductInventoryStatusYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCatStatusDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_CAT_STATUS_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllowPickup)
                .HasColumnName("ALLOW_PICKUP")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CatDeductInventory)
                .HasColumnName("CAT_DEDUCT_INVENTORY")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CatStatusType)
                .HasColumnName("CAT_STATUS_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Color)
                .HasColumnName("COLOR")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeductInventory)
                .HasColumnName("DEDUCT_INVENTORY")
                .IsUnicode(false);

            entity.Property(e => e.DeductInventoryStatusYn)
                .HasColumnName("DEDUCT_INVENTORY_STATUS_YN")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.LeadStatusYn)
                .HasColumnName("LEAD_STATUS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReturnToInventory)
                .HasColumnName("RETURN_TO_INVENTORY")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.StartingStatus)
                .HasColumnName("STARTING_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .IsUnicode(false);

            entity.Property(e => e.StatusType)
                .HasColumnName("STATUS_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
