namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RwServerQueue
{
    public string JobType { get; set; }
    public decimal? JobId { get; set; }
    public string JobName { get; set; }
    public decimal? StatusCode { get; set; }
    public string StatusMessage { get; set; }
    public string CommandLine { get; set; }
    public string Owner { get; set; }
    public string Destype { get; set; }
    public string Desname { get; set; }
    public string Server { get; set; }
    public DateTime? Queued { get; set; }
    public DateTime? Started { get; set; }
    public DateTime? Finished { get; set; }
    public DateTime? LastRun { get; set; }
    public DateTime? NextRun { get; set; }
    public string Frmsid { get; set; }
    public decimal? RepeatInterval { get; set; }
    public decimal? RepeatPattern { get; set; }
    public string CacheKey { get; set; }
    public decimal? CacheHit { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RwServerQueue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RW_SERVER_QUEUE");

            entity.Property(e => e.CacheHit)
                .HasColumnName("CACHE_HIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CacheKey)
                .HasColumnName("CACHE_KEY")
                .IsUnicode(false);

            entity.Property(e => e.CommandLine)
                .HasColumnName("COMMAND_LINE")
                .IsUnicode(false);

            entity.Property(e => e.Desname)
                .HasColumnName("DESNAME")
                .IsUnicode(false);

            entity.Property(e => e.Destype)
                .HasColumnName("DESTYPE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Finished)
                .HasColumnName("FINISHED")
                .HasColumnType("DATE");

            entity.Property(e => e.Frmsid)
                .HasColumnName("FRMSID")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.JobId)
                .HasColumnName("JOB_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobName)
                .HasColumnName("JOB_NAME")
                .IsUnicode(false);

            entity.Property(e => e.JobType)
                .HasColumnName("JOB_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.LastRun)
                .HasColumnName("LAST_RUN")
                .HasColumnType("DATE");

            entity.Property(e => e.NextRun)
                .HasColumnName("NEXT_RUN")
                .HasColumnType("DATE");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Queued)
                .HasColumnName("QUEUED")
                .HasColumnType("DATE");

            entity.Property(e => e.RepeatInterval)
                .HasColumnName("REPEAT_INTERVAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatPattern)
                .HasColumnName("REPEAT_PATTERN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Server)
                .HasColumnName("SERVER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Started)
                .HasColumnName("STARTED")
                .HasColumnType("DATE");

            entity.Property(e => e.StatusCode)
                .HasColumnName("STATUS_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusMessage)
                .HasColumnName("STATUS_MESSAGE")
                .IsUnicode(false);
        });
	}
}
