namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class JobsRunningView
{
    public decimal? InstId { get; set; }
    public decimal? Sid { get; set; }
    public decimal? Job { get; set; }
    public string? SchemaOwner { get; set; }
    public string? What { get; set; }
    public decimal? Failures { get; set; }
    public DateTime? LastDate { get; set; }
    public string? LastSec { get; set; }
    public DateTime? ThisDate { get; set; }
    public string? ThisSec { get; set; }
    public decimal? Instance { get; set; }
    public string? Owner { get; set; }
    public DateTime? NextDate { get; set; }
    public string? Interval { get; set; }
    public string? Broken { get; set; }
    public decimal? TotalTime { get; set; }
    public string? NlsEnv { get; set; }
    public byte[] MiscEnv { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobsRunningView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("JOBS_RUNNING_VIEW");

            entity.Property(e => e.Broken)
                .HasColumnName("BROKEN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Failures)
                .HasColumnName("FAILURES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InstId)
                .HasColumnName("INST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Instance)
                .HasColumnName("INSTANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Interval)
                .HasColumnName("INTERVAL")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Job)
                .HasColumnName("JOB")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastDate)
                .HasColumnName("LAST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastSec)
                .HasColumnName("LAST_SEC")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.MiscEnv)
                .HasColumnName("MISC_ENV")
                .HasMaxLength(32);

            entity.Property(e => e.NextDate)
                .HasColumnName("NEXT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NlsEnv)
                .HasColumnName("NLS_ENV")
                .IsUnicode(false);

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SchemaOwner)
                .HasColumnName("SCHEMA_OWNER")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ThisDate)
                .HasColumnName("THIS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ThisSec)
                .HasColumnName("THIS_SEC")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.TotalTime)
                .HasColumnName("TOTAL_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.What)
                .HasColumnName("WHAT")
                .IsUnicode(false);
        });
	}
}
