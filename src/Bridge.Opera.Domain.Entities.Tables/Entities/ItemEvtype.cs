namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ItemEvtype
{
    public string Resort { get; set; }
    public decimal ItemId { get; set; }
    public string EventType { get; set; }

    public virtual GemItem GemItem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ItemEvtype>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ItemId, e.EventType })
                .HasName("ITM_EVT_PK");

            entity.ToTable("ITEM$EVTYPE");

            entity.HasIndex(e => e.EventType)
                .HasName("ITM_EVT_EVTYPE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);
			else
	            entity.HasOne(d => d.GemItem)
	                .WithMany(p => p.ItemEvtype)
	                .HasForeignKey(d => new { d.Resort, d.ItemId })
	                .HasConstraintName("ITM_EVT_ITM_FK");
        });
	}
}
