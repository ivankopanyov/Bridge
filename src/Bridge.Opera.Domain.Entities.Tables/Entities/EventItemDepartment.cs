namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventItemDepartment
{
    public string Resort { get; set; }
    public decimal EventItemId { get; set; }
    public string DeptId { get; set; }

    public virtual Department Department { get; set; }
    public virtual EventItem EventItem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventItemDepartment>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.EventItemId, e.DeptId })
                .HasName("EID_PK");

            entity.ToTable("EVENT$ITEM_DEPARTMENT");

            entity.HasIndex(e => e.EventItemId)
                .HasName("EID_EI_IDX");

            entity.HasIndex(e => new { e.Resort, e.DeptId })
                .HasName("EID_DEPARTMENT_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventItemId)
                .HasColumnName("EVENT_ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(EventItem)))
				entity.Ignore(e => e.EventItem);
			else
	            entity.HasOne(d => d.EventItem)
	                .WithMany(p => p.EventItemDepartment)
	                .HasForeignKey(d => d.EventItemId)
	                .HasConstraintName("EID_EI_FK");

			if (!types.Contains(typeof(Department)))
				entity.Ignore(e => e.Department);
			else
	            entity.HasOne(d => d.Department)
	                .WithMany(p => p.EventItemDepartment)
	                .HasForeignKey(d => new { d.Resort, d.DeptId })
	                .HasConstraintName("EID_DEPARTMENT_FK");
        });
	}
}
