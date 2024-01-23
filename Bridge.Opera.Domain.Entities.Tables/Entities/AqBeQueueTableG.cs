namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AqBeQueueTableG
{
    public Guid Msgid { get; set; }
    public decimal Subscriber { get; set; }
    public string Name { get; set; }
    public decimal Address { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AqBeQueueTableG>(entity =>
        {
            entity.HasKey(e => new { e.Msgid, e.Subscriber, e.Name, e.Address })
                .HasName("SYS_IOT_TOP_142121");

            entity.ToTable("AQ$_BE_QUEUE_TABLE_G");

            entity.Property(e => e.Msgid).HasColumnName("MSGID");

            entity.Property(e => e.Subscriber)
                .HasColumnName("SUBSCRIBER#")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Address)
                .HasColumnName("ADDRESS#")
                .HasColumnType("NUMBER");
        });
	}
}
