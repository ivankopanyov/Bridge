namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IntBehubConsumers
{
    public byte? MachineId { get; set; }
    public string? Resort { get; set; }
    public string? ConsumerName { get; set; }
    public byte? TimeLimitSec { get; set; }
    public DateTime? FirstMessageAt { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntBehubConsumers>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INT_BEHUB_CONSUMERS");

            entity.Property(e => e.ConsumerName)
                .HasColumnName("CONSUMER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FirstMessageAt)
                .HasColumnName("FIRST_MESSAGE_AT")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.MachineId)
                .HasColumnName("MACHINE_ID")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TimeLimitSec)
                .HasColumnName("TIME_LIMIT_SEC")
                .HasColumnType("NUMBER(4)");
        });
	}
}
