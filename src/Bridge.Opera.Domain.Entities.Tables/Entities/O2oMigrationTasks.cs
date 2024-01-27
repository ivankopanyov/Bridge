namespace Bridge.Opera.Domain.Entities.Tables;

public partial class O2oMigrationTasks
{
    public string TaskName { get; set; }
    public decimal? TaskId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<O2oMigrationTasks>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("O2O_MIGRATION_TASKS");

            entity.Property(e => e.TaskId)
                .HasColumnName("TASK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskName)
                .HasColumnName("TASK_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
