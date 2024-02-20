namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TaskTypes
{
    public TaskTypes()
    {
        Tasks = new HashSet<Tasks>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string? TypeCode { get; set; }
    public string? Description { get; set; }
    public string? Resort { get; set; }

    public virtual ICollection<Tasks> Tasks { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskTypes>(entity =>
        {
            entity.HasKey(e => new { e.TypeCode, e.Resort })
                .HasName("TASK_TYPES_PK");

            entity.ToTable("TASK_TYPES");

            entity.Property(e => e.TypeCode)
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.Tasks);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
