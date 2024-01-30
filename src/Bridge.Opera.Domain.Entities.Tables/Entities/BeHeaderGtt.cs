namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BeHeaderGtt
{
    public DateTime? InsertTs { get; set; }
    public Guid? QueueHandle { get; set; }
    public decimal? StepNo { get; set; }
    public decimal? SequenceOverride { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BeHeaderGtt>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BE_HEADER_GTT");

            entity.Property(e => e.InsertTs)
                .HasColumnName("INSERT_TS")
                .HasColumnType("TIMESTAMP(6)")
                .HasDefaultValueSql("systimestamp ");

            entity.Property(e => e.QueueHandle).HasColumnName("QUEUE_HANDLE");

            entity.Property(e => e.SequenceOverride)
                .HasColumnName("SEQUENCE_OVERRIDE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StepNo)
                .HasColumnName("STEP_NO")
                .HasColumnType("NUMBER");
        });
	}
}
