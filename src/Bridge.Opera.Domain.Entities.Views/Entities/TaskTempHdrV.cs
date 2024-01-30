namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaskTempHdrV
{
    public decimal? TemplateId { get; set; }
    public string? TemplateName { get; set; }
    public string? Resort { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UpdateUserName { get; set; }
    public string? InsertUserName { get; set; }
    public decimal? TaskCount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskTempHdrV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TASK_TEMP_HDR_V");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertUserName)
                .HasColumnName("INSERT_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaskCount)
                .HasColumnName("TASK_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TemplateId)
                .HasColumnName("TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TemplateName)
                .IsRequired()
                .HasColumnName("TEMPLATE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateUserName)
                .HasColumnName("UPDATE_USER_NAME")
                .IsUnicode(false);
        });
	}
}
