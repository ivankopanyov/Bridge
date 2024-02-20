namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BookingStatus
{
    public string? Status { get; set; }
    public string? Description { get; set; }
    public string? DeductInventory { get; set; }
    public string? AllowPickup { get; set; }
    public string? ReturnToInventory { get; set; }
    public string? StatusType { get; set; }
    public string? StartingStatus { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ShowdiaryYn { get; set; }
    public string? Color { get; set; }
    public string? ReasonType { get; set; }
    public string? DefResvType { get; set; }
    public string? CatStatusType { get; set; }
    public string? CatDeductInventory { get; set; }
    public string? LogCateringYn { get; set; }
    public string? LeadStatusYn { get; set; }
    public string? DeductInventoryStatusYn { get; set; }
    public string? OrmsYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOOKING_STATUS");

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

            entity.Property(e => e.DefResvType)
                .HasColumnName("DEF_RESV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadStatusYn)
                .HasColumnName("LEAD_STATUS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LogCateringYn)
                .HasColumnName("LOG_CATERING_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrmsYn)
                .HasColumnName("ORMS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReasonType)
                .HasColumnName("REASON_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReturnToInventory)
                .HasColumnName("RETURN_TO_INVENTORY")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.ShowdiaryYn)
                .HasColumnName("SHOWDIARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StartingStatus)
                .HasColumnName("STARTING_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.StatusType)
                .HasColumnName("STATUS_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
