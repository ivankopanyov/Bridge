namespace Bridge.Opera.Domain.Entities.Tables;

public partial class WorkCategories
{
    public WorkCategories()
    {
        EmpWorkCategories = new HashSet<EmpWorkCategories>();
        Tasks = new HashSet<Tasks>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string Resort { get; set; }
    public string CategoryCode { get; set; }
    public string Description { get; set; }
    public string Printer { get; set; }

    public virtual ICollection<EmpWorkCategories> EmpWorkCategories { get; set; }
    public virtual ICollection<Tasks> Tasks { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<WorkCategories>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CategoryCode })
                .HasName("WC_PK");

            entity.ToTable("WORK_CATEGORIES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CategoryCode)
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Printer)
                .HasColumnName("PRINTER")
                .HasMaxLength(40)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(EmpWorkCategories)))
				entity.Ignore(e => e.EmpWorkCategories);

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.Tasks);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
