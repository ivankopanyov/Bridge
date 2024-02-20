namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaskTranslationV
{
    public string? Resort { get; set; }
    public decimal? TaskCode { get; set; }
    public string? TDescription { get; set; }
    public string? TNotes { get; set; }
    public string? LanguageCode { get; set; }
    public string? Description { get; set; }
    public string? Notes { get; set; }
    public decimal? LastUpdatedBy { get; set; }
    public string? LastUpdatedByName { get; set; }
    public DateTime? LastUpdatedDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskTranslationV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TASK_TRANSLATION_V");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastUpdatedBy)
                .HasColumnName("LAST_UPDATED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastUpdatedByName)
                .HasColumnName("LAST_UPDATED_BY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.LastUpdatedDate)
                .HasColumnName("LAST_UPDATED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Notes)
                .HasColumnName("NOTES")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TDescription)
                .IsRequired()
                .HasColumnName("T_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TNotes)
                .HasColumnName("T_NOTES")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaskCode)
                .HasColumnName("TASK_CODE")
                .HasColumnType("NUMBER");
        });
	}
}
