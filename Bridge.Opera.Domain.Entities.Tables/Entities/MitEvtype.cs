namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MitEvtype
{
    public string Resort { get; set; }
    public decimal MitId { get; set; }
    public string EventType { get; set; }

    public virtual GemMenuitem GemMenuitem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MitEvtype>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MIT$EVTYPE");

            entity.HasIndex(e => e.EventType)
                .HasName("MIT_EVTYPE_IDX");

            entity.HasIndex(e => new { e.Resort, e.MitId, e.EventType })
                .HasName("MIT_EV_UK")
                .IsUnique();

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(GemMenuitem)))
				entity.Ignore(e => e.GemMenuitem);
			else
	            entity.HasOne(d => d.GemMenuitem)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.MitId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MIT_EV_MIT_FK");
        });
	}
}
