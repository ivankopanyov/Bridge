namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ItemcEvtype
{
    public decimal? ItemclassId { get; set; }
    public string? EventType { get; set; }

    public virtual GemItemClass Itemclass { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ItemcEvtype>(entity =>
        {
            entity.HasKey(e => new { e.ItemclassId, e.EventType })
                .HasName("ITEMC_EVT_PK");

            entity.ToTable("ITEMC$EVTYPE");

            entity.HasIndex(e => e.EventType)
                .HasName("ITEMC_EVT_EVTYPE_IDX");

            entity.Property(e => e.ItemclassId)
                .HasColumnName("ITEMCLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemItemClass)))
				entity.Ignore(e => e.Itemclass);
			else
	            entity.HasOne(d => d.Itemclass)
	                .WithMany(p => p.ItemcEvtype)
	                .HasForeignKey(d => d.ItemclassId)
	                .HasConstraintName("ITEMC_EVT_ITMC_FK");
        });
	}
}
