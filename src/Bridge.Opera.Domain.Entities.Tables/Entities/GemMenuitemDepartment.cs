namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemMenuitemDepartment
{
    public decimal? MitId { get; set; }
    public string? Resort { get; set; }
    public string? DeptId { get; set; }

    public virtual Department Department { get; set; }
    public virtual GemMenuitem GemMenuitem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuitemDepartment>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.MitId, e.DeptId })
                .HasName("MITD_PK");

            entity.ToTable("GEM$MENUITEM_DEPARTMENT");

            entity.HasIndex(e => new { e.DeptId, e.Resort })
                .HasName("MITD_DEPT_IDX");

            entity.HasIndex(e => new { e.Resort, e.DeptId })
                .HasName("MIT_DEPT_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

			if (!types.Contains(typeof(Department)))
				entity.Ignore(e => e.Department);
			else
	            entity.HasOne(d => d.Department)
	                .WithMany(p => p.GemMenuitemDepartment)
	                .HasForeignKey(d => new { d.Resort, d.DeptId })
	                .HasConstraintName("MITD_DEPARTMENT_FK");

			if (!types.Contains(typeof(GemMenuitem)))
				entity.Ignore(e => e.GemMenuitem);
			else
	            entity.HasOne(d => d.GemMenuitem)
	                .WithMany(p => p.GemMenuitemDepartment)
	                .HasForeignKey(d => new { d.Resort, d.MitId })
	                .HasConstraintName("MITD_MIT_FK");
        });
	}
}
