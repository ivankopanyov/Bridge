namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemMenuitemcDepartment
{
    public decimal? MicId { get; set; }
    public string? Resort { get; set; }
    public string? DeptId { get; set; }

    public virtual Department Department { get; set; }
    public virtual GemMenuitemClass Mic { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuitemcDepartment>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.MicId, e.DeptId })
                .HasName("MITMCD_PK");

            entity.ToTable("GEM$MENUITEMC_DEPARTMENT");

            entity.HasIndex(e => e.MicId)
                .HasName("MITMCD_MITMC_FKI");

            entity.HasIndex(e => new { e.Resort, e.DeptId })
                .HasName("MITMCD_DEPT_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MicId)
                .HasColumnName("MIC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemMenuitemClass)))
				entity.Ignore(e => e.Mic);
			else
	            entity.HasOne(d => d.Mic)
	                .WithMany(p => p.GemMenuitemcDepartment)
	                .HasForeignKey(d => d.MicId)
	                .HasConstraintName("MITMCD_MITMC_FK");

			if (!types.Contains(typeof(Department)))
				entity.Ignore(e => e.Department);
			else
	            entity.HasOne(d => d.Department)
	                .WithMany(p => p.GemMenuitemcDepartment)
	                .HasForeignKey(d => new { d.Resort, d.DeptId })
	                .HasConstraintName("MITMCD_DEPT_FK");
        });
	}
}
