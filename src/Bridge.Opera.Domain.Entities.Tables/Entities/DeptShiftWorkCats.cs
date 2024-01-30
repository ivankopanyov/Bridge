namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DeptShiftWorkCats
{
    public string? Resort { get; set; }
    public string? DeptId { get; set; }
    public string? ShiftId { get; set; }
    public string? WorkCategory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DeptShiftWorkCats>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DeptId, e.ShiftId, e.WorkCategory })
                .HasName("DEPT_SHIFT_WORK_CATS_PK");

            entity.ToTable("DEPT_SHIFT_WORK_CATS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShiftId)
                .HasColumnName("SHIFT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WorkCategory)
                .HasColumnName("WORK_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
