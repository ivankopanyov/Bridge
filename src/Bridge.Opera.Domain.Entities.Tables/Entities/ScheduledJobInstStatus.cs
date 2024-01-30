namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScheduledJobInstStatus
{
    public string? JobName { get; set; }
    public decimal? InstanceNo { get; set; }
    public decimal? JobIterator { get; set; }
    public DateTime? LastRunDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScheduledJobInstStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SCHEDULED_JOB_INST_STATUS");

            entity.Property(e => e.InstanceNo)
                .HasColumnName("INSTANCE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobIterator)
                .HasColumnName("JOB_ITERATOR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobName)
                .IsRequired()
                .HasColumnName("JOB_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.LastRunDate)
                .HasColumnName("LAST_RUN_DATE")
                .HasColumnType("DATE");
        });
	}
}
