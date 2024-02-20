namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Department
{
    public Department()
    {
        DeptLogbook = new HashSet<DeptLogbook>();
        EventItemDepartment = new HashSet<EventItemDepartment>();
        EventMenuitemDepartment = new HashSet<EventMenuitemDepartment>();
        GemItemDepartment = new HashSet<GemItemDepartment>();
        GemMenuitemDepartment = new HashSet<GemMenuitemDepartment>();
        GemMenuitemcDepartment = new HashSet<GemMenuitemcDepartment>();
    }

    public string? Resort { get; set; }
    public string? DeptId { get; set; }
    public string? DeptName { get; set; }
    public string? DeptManagerPager { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? CanDeleteYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string? MessageText { get; set; }
    public string? DeptEmail { get; set; }

    public virtual Resort ResortNavigation { get; set; }
    public virtual ICollection<DeptLogbook> DeptLogbook { get; set; }
    public virtual ICollection<EventItemDepartment> EventItemDepartment { get; set; }
    public virtual ICollection<EventMenuitemDepartment> EventMenuitemDepartment { get; set; }
    public virtual ICollection<GemItemDepartment> GemItemDepartment { get; set; }
    public virtual ICollection<GemMenuitemDepartment> GemMenuitemDepartment { get; set; }
    public virtual ICollection<GemMenuitemcDepartment> GemMenuitemcDepartment { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DeptId })
                .HasName("DEPT_PK");

            entity.ToTable("DEPARTMENT");

            entity.HasIndex(e => e.DeptName)
                .HasName("DEPARTMENT_NAME_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptEmail)
                .HasColumnName("DEPT_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptManagerPager)
                .HasColumnName("DEPT_MANAGER_PAGER")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptName)
                .IsRequired()
                .HasColumnName("DEPT_NAME")
                .HasMaxLength(30)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MessageText)
                .HasColumnName("MESSAGE_TEXT")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.Department)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("DEPARTMENT_RESORT_FK");
        
			if (!types.Contains(typeof(DeptLogbook)))
				entity.Ignore(e => e.DeptLogbook);

			if (!types.Contains(typeof(EventItemDepartment)))
				entity.Ignore(e => e.EventItemDepartment);

			if (!types.Contains(typeof(EventMenuitemDepartment)))
				entity.Ignore(e => e.EventMenuitemDepartment);

			if (!types.Contains(typeof(GemItemDepartment)))
				entity.Ignore(e => e.GemItemDepartment);

			if (!types.Contains(typeof(GemMenuitemDepartment)))
				entity.Ignore(e => e.GemMenuitemDepartment);

			if (!types.Contains(typeof(GemMenuitemcDepartment)))
				entity.Ignore(e => e.GemMenuitemcDepartment);
		});
	}
}
