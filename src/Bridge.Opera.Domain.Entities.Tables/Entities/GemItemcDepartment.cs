namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemcDepartment
{
    public decimal ItemclassId { get; set; }
    public string Resort { get; set; }
    public string DeptId { get; set; }

    public virtual GemItemClass Itemclass { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemcDepartment>(entity =>
        {
            entity.HasKey(e => new { e.ItemclassId, e.Resort, e.DeptId })
                .HasName("ITMCD_PK");

            entity.ToTable("GEM$ITEMC_DEPARTMENT");

            entity.HasIndex(e => new { e.Resort, e.DeptId })
                .HasName("ITMCD_DEPT_IDX");

            entity.Property(e => e.ItemclassId)
                .HasColumnName("ITEMCLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

			if (!types.Contains(typeof(GemItemClass)))
				entity.Ignore(e => e.Itemclass);
			else
	            entity.HasOne(d => d.Itemclass)
	                .WithMany(p => p.GemItemcDepartment)
	                .HasForeignKey(d => d.ItemclassId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ITMCD_ITMC_FK");
        });
	}
}
