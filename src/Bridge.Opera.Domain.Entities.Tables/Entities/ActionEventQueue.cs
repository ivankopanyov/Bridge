namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ActionEventQueue
{
    public decimal? KeyId { get; set; }
    public string? ActionType { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ActionEventQueue>(entity =>
        {
            entity.HasKey(e => new { e.KeyId, e.ActionType })
                .HasName("ACTION_EVENT_QUEUE_PK");

            entity.ToTable("ACTION_EVENT_QUEUE");

            entity.Property(e => e.KeyId)
                .HasColumnName("KEY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
