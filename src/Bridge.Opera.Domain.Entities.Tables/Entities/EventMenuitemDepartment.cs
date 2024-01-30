namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EventMenuitemDepartment
{
    public decimal? EmdId { get; set; }
    public string? Resort { get; set; }
    public string? DeptId { get; set; }

    public virtual Department Department { get; set; }
    public virtual EventMenuDetails Emd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventMenuitemDepartment>(entity =>
        {
            entity.HasKey(e => new { e.EmdId, e.Resort, e.DeptId })
                .HasName("EMITD_PK");

            entity.ToTable("EVENT$MENUITEM_DEPARTMENT");

            entity.HasIndex(e => new { e.Resort, e.DeptId })
                .HasName("EMITD_DEPT_IDX");

            entity.Property(e => e.EmdId)
                .HasColumnName("EMD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

			if (!types.Contains(typeof(EventMenuDetails)))
				entity.Ignore(e => e.Emd);
			else
	            entity.HasOne(d => d.Emd)
	                .WithMany(p => p.EventMenuitemDepartment)
	                .HasForeignKey(d => d.EmdId)
	                .HasConstraintName("EMITD_EMD_FK");

			if (!types.Contains(typeof(Department)))
				entity.Ignore(e => e.Department);
			else
	            entity.HasOne(d => d.Department)
	                .WithMany(p => p.EventMenuitemDepartment)
	                .HasForeignKey(d => new { d.Resort, d.DeptId })
	                .HasConstraintName("EMITD_DEPARTMENT_FK");
        });
	}
}
