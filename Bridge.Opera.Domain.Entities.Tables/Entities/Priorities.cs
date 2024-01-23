namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Priorities
{
    public Priorities()
    {
        Locations = new HashSet<Locations>();
        Tasks = new HashSet<Tasks>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string Resort { get; set; }
    public string PriorityCode { get; set; }
    public string Description { get; set; }
    public decimal PrioritySeqNumber { get; set; }
    public string ColorCode { get; set; }
    public string ColorCodeDescription { get; set; }

    public virtual ICollection<Locations> Locations { get; set; }
    public virtual ICollection<Tasks> Tasks { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Priorities>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.PriorityCode })
                .HasName("PRI_PK");

            entity.ToTable("PRIORITIES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PriorityCode)
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ColorCode)
                .HasColumnName("COLOR_CODE")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ColorCodeDescription)
                .HasColumnName("COLOR_CODE_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrioritySeqNumber)
                .HasColumnName("PRIORITY_SEQ_NUMBER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(Locations)))
				entity.Ignore(e => e.Locations);

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.Tasks);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
