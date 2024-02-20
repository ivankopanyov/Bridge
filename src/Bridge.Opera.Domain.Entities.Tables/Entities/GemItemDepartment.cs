namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemDepartment
{
    public decimal? ItemId { get; set; }
    public string? Resort { get; set; }
    public string? DeptId { get; set; }
    public string? TraceText { get; set; }

    public virtual Department Department { get; set; }
    public virtual GemItem GemItem { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemDepartment>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.DeptId, e.Resort })
                .HasName("ITMD_PK");

            entity.ToTable("GEM$ITEM_DEPARTMENT");

            entity.HasIndex(e => new { e.Resort, e.DeptId })
                .HasName("ITMD_DEPT_IDX");

            entity.HasIndex(e => new { e.Resort, e.ItemId })
                .HasName("ITMD_ITM_IDX");

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TraceText)
                .HasColumnName("TRACE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

			if (!types.Contains(typeof(Department)))
				entity.Ignore(e => e.Department);
			else
	            entity.HasOne(d => d.Department)
	                .WithMany(p => p.GemItemDepartment)
	                .HasForeignKey(d => new { d.Resort, d.DeptId })
	                .HasConstraintName("ITMD_DEPARTMENT_FK");

			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);
			else
	            entity.HasOne(d => d.GemItem)
	                .WithMany(p => p.GemItemDepartment)
	                .HasForeignKey(d => new { d.Resort, d.ItemId })
	                .HasConstraintName("ITMD_ITM_FK");
        });
	}
}
