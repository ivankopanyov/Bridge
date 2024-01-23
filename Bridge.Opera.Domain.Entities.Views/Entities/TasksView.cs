namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TasksView
{
    public string Resort { get; set; }
    public decimal TaskCode { get; set; }
    public string Description { get; set; }
    public string TypeCode { get; set; }
    public string CategoryCode { get; set; }
    public string CategoryDesc { get; set; }
    public decimal? EstTime { get; set; }
    public decimal? InMins { get; set; }
    public string EstUotCode { get; set; }
    public string EstTimeDesc { get; set; }
    public string Frequency { get; set; }
    public string FrequencyDesc { get; set; }
    public string PriorityCode { get; set; }
    public string PriorityDesc { get; set; }
    public string ActiveYn { get; set; }
    public string Notes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TasksView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TASKS_VIEW");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CategoryCode)
                .IsRequired()
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CategoryDesc)
                .IsRequired()
                .HasColumnName("CATEGORY_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EstTime)
                .HasColumnName("EST_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstTimeDesc)
                .IsRequired()
                .HasColumnName("EST_TIME_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EstUotCode)
                .HasColumnName("EST_UOT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FrequencyDesc)
                .HasColumnName("FREQUENCY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.InMins)
                .HasColumnName("IN_MINS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PriorityCode)
                .IsRequired()
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PriorityDesc)
                .IsRequired()
                .HasColumnName("PRIORITY_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TypeCode)
                .IsRequired()
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
