namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TaskTranslation
{
    public string? Resort { get; set; }
    public DateTime? LastUpdatedDate { get; set; }
    public decimal? LastUpdatedBy { get; set; }
    public decimal? TaskCode { get; set; }
    public string? LanguageCode { get; set; }
    public string? Description { get; set; }
    public string? Notes { get; set; }

    public virtual Tasks Tasks { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskTranslation>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TaskCode, e.LanguageCode })
                .HasName("TTTRAN_PK");

            entity.ToTable("TASK_TRANSLATION");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdatedBy)
                .HasColumnName("LAST_UPDATED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastUpdatedDate)
                .HasColumnName("LAST_UPDATED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.Tasks);
			else
	            entity.HasOne(d => d.Tasks)
	                .WithMany(p => p.TaskTranslation)
	                .HasForeignKey(d => new { d.Resort, d.TaskCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("TTTRAN_TL_FK");
        });
	}
}
