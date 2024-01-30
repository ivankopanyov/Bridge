namespace Bridge.Opera.Domain.Entities.Tables;

public partial class JobSchTaskTemplates
{
    public string? TaskCode { get; set; }
    public string? TaskType { get; set; }
    public string? TaskDescription { get; set; }
    public string? TaskActionText { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? ListCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<JobSchTaskTemplates>(entity =>
        {
            entity.HasKey(e => e.TaskCode)
                .HasName("JOB_SCH_TSK_TEMP_PK");

            entity.ToTable("JOB_SCH_TASK_TEMPLATES");

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ListCode)
                .HasColumnName("LIST_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TaskActionText)
                .HasColumnName("TASK_ACTION_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.TaskDescription)
                .HasColumnName("TASK_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.TaskType)
                .IsRequired()
                .HasColumnName("TASK_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
