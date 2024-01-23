namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScheduleTemplates
{
    public ScheduleTemplates()
    {
        EmpAvail = new HashSet<EmpAvail>();
    }

    public decimal TemplateId { get; set; }
    public string TemplateName { get; set; }
    public string Resort { get; set; }

    public virtual ICollection<EmpAvail> EmpAvail { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScheduleTemplates>(entity =>
        {
            entity.HasKey(e => new { e.TemplateId, e.Resort })
                .HasName("ST_PK");

            entity.ToTable("SCHEDULE_TEMPLATES");

            entity.Property(e => e.TemplateId)
                .HasColumnName("TEMPLATE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateName)
                .IsRequired()
                .HasColumnName("TEMPLATE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(EmpAvail)))
				entity.Ignore(e => e.EmpAvail);
		});
	}
}
