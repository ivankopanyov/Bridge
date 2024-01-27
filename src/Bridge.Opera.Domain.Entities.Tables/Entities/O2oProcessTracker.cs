namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2oProcessTracker
{
    public decimal ProcessId { get; set; }
    public string O2oMigId { get; set; }
    public string EventName { get; set; }
    public string EventIdChar { get; set; }
    public decimal? EventIdNum { get; set; }
    public string Status { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string Comments { get; set; }
    public string OracleJobId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2oProcessTracker>(entity =>
        {
            entity.HasKey(e => e.ProcessId)
                .HasName("O2O_PROCESS_TRACKER_PK");

            entity.ToTable("O2O_PROCESS_TRACKER");

            entity.HasIndex(e => new { e.O2oMigId, e.EventName, e.EventIdChar })
                .HasName("O2O_PROCESS_TRACKER_IDX1");

            entity.HasIndex(e => new { e.O2oMigId, e.EventName, e.EventIdNum })
                .HasName("O2O_PROCESS_TRACKER_IDX2");

            entity.HasIndex(e => new { e.O2oMigId, e.Status, e.EventName })
                .HasName("O2O_PROCESS_TRACKER_IDX3");

            entity.Property(e => e.ProcessId)
                .HasColumnName("PROCESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventIdChar)
                .HasColumnName("EVENT_ID_CHAR")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.EventIdNum)
                .HasColumnName("EVENT_ID_NUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventName)
                .IsRequired()
                .HasColumnName("EVENT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.O2oMigId)
                .IsRequired()
                .HasColumnName("O2O_MIG_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OracleJobId)
                .HasColumnName("ORACLE_JOB_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");
        });
	}
}
