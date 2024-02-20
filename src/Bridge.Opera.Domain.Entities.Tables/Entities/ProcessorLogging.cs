namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProcessorLogging
{
    public string? Job { get; set; }
    public DateTime? WhenStarted { get; set; }
    public DateTime? WhenStopped { get; set; }
    public string? InsertUser { get; set; }
    public decimal? Sid { get; set; }
    public string? ModuleInfo { get; set; }
    public string? ClientInfo { get; set; }
    public string? ProgramInfo { get; set; }
    public string? Machine { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProcessorLogging>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PROCESSOR_LOGGING");

            entity.Property(e => e.ClientInfo)
                .HasColumnName("CLIENT_INFO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Job)
                .HasColumnName("JOB")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ModuleInfo)
                .HasColumnName("MODULE_INFO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ProgramInfo)
                .HasColumnName("PROGRAM_INFO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WhenStarted)
                .HasColumnName("WHEN_STARTED")
                .HasColumnType("DATE");

            entity.Property(e => e.WhenStopped)
                .HasColumnName("WHEN_STOPPED")
                .HasColumnType("DATE");
        });
	}
}
