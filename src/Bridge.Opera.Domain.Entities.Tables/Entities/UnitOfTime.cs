namespace Bridge.Opera.Domain.Entities.Tables;

public partial class UnitOfTime
{
    public UnitOfTime()
    {
        LaborUsed = new HashSet<LaborUsed>();
        Taskitems = new HashSet<Taskitems>();
        TasksRes = new HashSet<Tasks>();
        TasksUnitOfTime = new HashSet<Tasks>();
        WorkOrders = new HashSet<WorkOrders>();
    }

    public string? UotCode { get; set; }
    public string? Description { get; set; }
    public string? Resort { get; set; }
    public decimal? InDays { get; set; }
    public decimal? InHours { get; set; }
    public decimal? InMinutes { get; set; }
    public decimal? DurationInMinutes { get; set; }

    public virtual ICollection<LaborUsed> LaborUsed { get; set; }
    public virtual ICollection<Taskitems> Taskitems { get; set; }
    public virtual ICollection<Tasks> TasksRes { get; set; }
    public virtual ICollection<Tasks> TasksUnitOfTime { get; set; }
    public virtual ICollection<WorkOrders> WorkOrders { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UnitOfTime>(entity =>
        {
            entity.HasKey(e => new { e.UotCode, e.Resort })
                .HasName("UOT_PK");

            entity.ToTable("UNIT_OF_TIME");

            entity.HasIndex(e => new { e.Resort, e.UotCode })
                .HasName("UOT_RESORTCODE");

            entity.Property(e => e.UotCode)
                .HasColumnName("UOT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DurationInMinutes)
                .HasColumnName("DURATION_IN_MINUTES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InDays)
                .HasColumnName("IN_DAYS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InHours)
                .HasColumnName("IN_HOURS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InMinutes)
                .HasColumnName("IN_MINUTES")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(LaborUsed)))
				entity.Ignore(e => e.LaborUsed);

			if (!types.Contains(typeof(Taskitems)))
				entity.Ignore(e => e.Taskitems);

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.TasksRes);

			if (!types.Contains(typeof(Tasks)))
				entity.Ignore(e => e.TasksUnitOfTime);

			if (!types.Contains(typeof(WorkOrders)))
				entity.Ignore(e => e.WorkOrders);
		});
	}
}
