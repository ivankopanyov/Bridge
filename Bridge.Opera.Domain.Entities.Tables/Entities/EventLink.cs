namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventLink
{
    public decimal LinkId { get; set; }
    public decimal EventId { get; set; }

    public virtual GemEvent Event { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventLink>(entity =>
        {
            entity.HasKey(e => new { e.LinkId, e.EventId })
                .HasName("EL_PK");

            entity.ToTable("EVENT$LINK");

            entity.HasIndex(e => e.EventId)
                .HasName("EL_GE_IDX");

            entity.Property(e => e.LinkId)
                .HasColumnName("LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemEvent)))
				entity.Ignore(e => e.Event);
			else
	            entity.HasOne(d => d.Event)
	                .WithMany(p => p.EventLink)
	                .HasForeignKey(d => d.EventId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("EL_GE_FK");
        });
	}
}
