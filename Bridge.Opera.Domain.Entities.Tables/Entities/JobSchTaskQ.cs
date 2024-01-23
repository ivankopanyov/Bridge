namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobSchTaskQ
{
    public string QCode { get; set; }
    public string TaskCode { get; set; }
    public decimal ExecutionSeq { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string CanDeleteYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchTaskQ>(entity =>
        {
            entity.HasKey(e => new { e.QCode, e.TaskCode })
                .HasName("JOB_SCH_Q_PK");

            entity.ToTable("JOB_SCH_TASK_Q");

            entity.HasIndex(e => new { e.QCode, e.ExecutionSeq })
                .HasName("JOB_SCH_Q_UK01")
                .IsUnique();

            entity.Property(e => e.QCode)
                .HasColumnName("Q_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExecutionSeq)
                .HasColumnName("EXECUTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
