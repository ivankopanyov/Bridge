namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NaLogHeader
{
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? JobName { get; set; }
    public short Iteration { get; set; }
    public decimal? SysJobId { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public decimal? RunByUserId { get; set; }
    public string? Status { get; set; }
    public decimal? ModuleId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NaLogHeader>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NA_LOG_HEADER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Iteration).HasColumnName("ITERATION");

            entity.Property(e => e.JobName)
                .IsRequired()
                .HasColumnName("JOB_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RunByUserId)
                .HasColumnName("RUN_BY_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartTime)
                .HasColumnName("START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SysJobId)
                .HasColumnName("SYS_JOB_ID")
                .HasColumnType("NUMBER");
        });
	}
}
