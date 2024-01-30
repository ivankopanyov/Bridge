namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MencEvtype
{
    public decimal? MencId { get; set; }
    public string? EventType { get; set; }

    public virtual GemMenuClass Menc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MencEvtype>(entity =>
        {
            entity.HasKey(e => new { e.MencId, e.EventType })
                .HasName("MENC_EV_PK");

            entity.ToTable("MENC$EVTYPE");

            entity.HasIndex(e => e.EventType)
                .HasName("MENC_EVTYPE_IDX");

            entity.Property(e => e.MencId)
                .HasColumnName("MENC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventType)
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemMenuClass)))
				entity.Ignore(e => e.Menc);
			else
	            entity.HasOne(d => d.Menc)
	                .WithMany(p => p.MencEvtype)
	                .HasForeignKey(d => d.MencId)
	                .HasConstraintName("MENC_EV_MENC_FK");
        });
	}
}
