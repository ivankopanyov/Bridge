namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TaskTemplateDetails
{
    public string Resort { get; set; }
    public decimal TemplateId { get; set; }
    public decimal TaskCode { get; set; }

    public virtual Tasks Tasks { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskTemplateDetails>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TemplateId, e.TaskCode })
                .HasName("TTD_PK");

            entity.ToTable("TASK_TEMPLATE_DETAILS");

            entity.HasIndex(e => new { e.Resort, e.TaskCode })
                .HasName("TTD_TL_FKI");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateId)
                .HasColumnName("TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.Tasks);
			else
	            entity.HasOne(d => d.Tasks)
	                .WithMany(p => p.TaskTemplateDetails)
	                .HasForeignKey(d => new { d.Resort, d.TaskCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TTD_TL_FK");
        });
	}
}
