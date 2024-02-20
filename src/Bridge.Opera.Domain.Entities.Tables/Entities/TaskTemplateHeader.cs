namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TaskTemplateHeader
{
    public string? Resort { get; set; }
    public decimal? TemplateId { get; set; }
    public string? TemplateName { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaskTemplateHeader>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TemplateId })
                .HasName("TT_PK");

            entity.ToTable("TASK_TEMPLATE_HEADER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateId)
                .HasColumnName("TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
        });
	}
}
