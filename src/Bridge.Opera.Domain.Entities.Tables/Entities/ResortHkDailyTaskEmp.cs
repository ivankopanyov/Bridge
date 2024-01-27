namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortHkDailyTaskEmp
{
    public decimal TaskSeqNo { get; set; }
    public string EmpId { get; set; }
    public string Resort { get; set; }
    public string EmpInstructions { get; set; }

    public virtual ResortHkEmployees ResortHkEmployees { get; set; }
    public virtual ResortHkDailyTask TaskSeqNoNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortHkDailyTaskEmp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_HK_DAILY_TASK_EMP");

            entity.HasIndex(e => new { e.EmpId, e.Resort })
                .HasName("HK_DAILY_TASK_EMP_IDX");

            entity.HasIndex(e => new { e.TaskSeqNo, e.EmpId, e.Resort })
                .HasName("HK_DAILY_TASK_EMP_UK")
                .IsUnique();

            entity.Property(e => e.EmpId)
                .IsRequired()
                .HasColumnName("EMP_ID")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmpInstructions)
                .HasColumnName("EMP_INSTRUCTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TaskSeqNo)
                .HasColumnName("TASK_SEQ_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ResortHkDailyTask)))
				entity.Ignore(e => e.TaskSeqNoNavigation);
			else
	            entity.HasOne(d => d.TaskSeqNoNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.TaskSeqNo)
	                .HasConstraintName("HK_DAILY_TASK_EMP_SEQ_FK");

			if (!types.Contains(typeof(ResortHkEmployees)))
				entity.Ignore(e => e.ResortHkEmployees);
			else
	            entity.HasOne(d => d.ResortHkEmployees)
	                .WithMany()
	                .HasPrincipalKey(p => new { p.EmpId, p.Resort })
	                .HasForeignKey(d => new { d.EmpId, d.Resort })
	                .HasConstraintName("HK_DAILY_TASK_EMP_FK");
        });
	}
}
