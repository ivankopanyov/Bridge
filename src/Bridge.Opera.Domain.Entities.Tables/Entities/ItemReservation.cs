namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ItemReservation
{
    public decimal? ItemResvId { get; set; }
    public string? Resort { get; set; }
    public decimal? ItemId { get; set; }
    public string? ReservedBy { get; set; }
    public decimal? ReservedById { get; set; }
    public decimal? ResourceId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public decimal? Quantity { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? DeductInventoryYn { get; set; }

    public virtual GemItem GemItem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ItemReservation>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ItemId, e.ReservedBy, e.ReservedById, e.ResourceId })
                .HasName("ITMRESV_PK");

            entity.ToTable("ITEM$RESERVATION");

            entity.HasIndex(e => new { e.Resort, e.ItemId, e.EndDate })
                .HasName("IR_END_DATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.ItemId, e.BeginDate, e.EndDate })
                .HasName("ITEMRESV_DATES_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReservedBy)
                .HasColumnName("RESERVED_BY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservedById)
                .HasColumnName("RESERVED_BY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResourceId)
                .HasColumnName("RESOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeductInventoryYn)
                .HasColumnName("DEDUCT_INVENTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemResvId)
                .HasColumnName("ITEM_RESV_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);
			else
	            entity.HasOne(d => d.GemItem)
	                .WithMany(p => p.ItemReservation)
	                .HasForeignKey(d => new { d.Resort, d.ItemId })
	                .HasConstraintName("ITMRESV_ITM_FK");
        });
	}
}
