namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ItemHold
{
    public decimal ItemHoldId { get; set; }
    public string Resort { get; set; }
    public decimal ItemId { get; set; }
    public string HeldByType { get; set; }
    public string HeldById { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public decimal Quantity { get; set; }
    public DateTime InsertTs { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime? UpdateTs { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ItemHold>(entity =>
        {
            entity.ToTable("ITEM$HOLD");

            entity.HasIndex(e => new { e.Resort, e.ItemId })
                .HasName("ITMH_RES_ITEM_IDX");

            entity.HasIndex(e => new { e.HeldByType, e.HeldById, e.Resort })
                .HasName("ITEM_HOLD_IDX2");

            entity.HasIndex(e => new { e.Resort, e.HeldByType, e.HeldById })
                .HasName("ITMH_RES_HELD_IDX");

            entity.Property(e => e.ItemHoldId)
                .HasColumnName("ITEM_HOLD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HeldById)
                .IsRequired()
                .HasColumnName("HELD_BY_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HeldByType)
                .IsRequired()
                .HasColumnName("HELD_BY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertTs)
                .HasColumnName("INSERT_TS")
                .HasColumnType("TIMESTAMP(6)")
                .HasDefaultValueSql("SYSTIMESTAMP ");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateTs)
                .HasColumnName("UPDATE_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
