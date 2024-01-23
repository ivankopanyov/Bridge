namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MicEvtype
{
    public decimal MicId { get; set; }
    public string EventType { get; set; }

    public virtual GemMenuitemClass Mic { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MicEvtype>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MIC$EVTYPE");

            entity.HasIndex(e => e.EventType)
                .HasName("MIC_EVTYPE_IDX");

            entity.HasIndex(e => new { e.MicId, e.EventType })
                .HasName("MIC_EV_UK")
                .IsUnique();

            entity.Property(e => e.EventType)
                .IsRequired()
                .HasColumnName("EVENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MicId)
                .HasColumnName("MIC_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GemMenuitemClass)))
				entity.Ignore(e => e.Mic);
			else
	            entity.HasOne(d => d.Mic)
	                .WithMany()
	                .HasForeignKey(d => d.MicId)
	                .HasConstraintName("MIC_EV_MIC_FK");
        });
	}
}
