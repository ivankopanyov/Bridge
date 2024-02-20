namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AqBeQueueTableS1
{
    public string? Queue { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public decimal? Protocol { get; set; }
    public string? Transformation { get; set; }
    public string? QueueToQueue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AqBeQueueTableS1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AQ$BE_QUEUE_TABLE_S");

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Protocol)
                .HasColumnName("PROTOCOL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Queue)
                .IsRequired()
                .HasColumnName("QUEUE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.QueueToQueue)
                .HasColumnName("QUEUE_TO_QUEUE")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Transformation)
                .HasColumnName("TRANSFORMATION")
                .HasMaxLength(65)
                .IsUnicode(false);
        });
	}
}
