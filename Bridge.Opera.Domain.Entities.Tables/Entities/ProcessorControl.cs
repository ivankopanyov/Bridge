namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProcessorControl
{
    public string Process { get; set; }
    public decimal Thread { get; set; }
    public string EnabledYn { get; set; }
    public string Schema { get; set; }
    public string Command { get; set; }
    public string State { get; set; }
    public string Machine { get; set; }
    public DateTime? CommandDate { get; set; }
    public decimal? CommandUser { get; set; }
    public DateTime? StateDate { get; set; }
    public decimal? Instance { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProcessorControl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROCESSOR_CONTROL");

            entity.HasIndex(e => new { e.Process, e.Thread })
                .HasName("PROCESSOR_CONTROL_IND_UK")
                .IsUnique();

            entity.Property(e => e.Command)
                .IsRequired()
                .HasColumnName("COMMAND")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CommandDate)
                .HasColumnName("COMMAND_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CommandUser)
                .HasColumnName("COMMAND_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EnabledYn)
                .IsRequired()
                .HasColumnName("ENABLED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.Instance)
                .HasColumnName("INSTANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Process)
                .IsRequired()
                .HasColumnName("PROCESS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Schema)
                .IsRequired()
                .HasColumnName("SCHEMA")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StateDate)
                .HasColumnName("STATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Thread)
                .HasColumnName("THREAD")
                .HasColumnType("NUMBER(38)")
                .HasDefaultValueSql("1 ");
        });
	}
}
