namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HkDailyTaskEmp
{
    public decimal? TaskSeqNo { get; set; }
    public string? EmpId { get; set; }
    public string? EmpInstructions { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkDailyTaskEmp>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HK_DAILY_TASK_EMP");

            entity.Property(e => e.EmpId)
                .IsRequired()
                .HasColumnName("EMP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmpInstructions)
                .HasColumnName("EMP_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaskSeqNo)
                .HasColumnName("TASK_SEQ_NO")
                .HasColumnType("NUMBER");
        });
	}
}
