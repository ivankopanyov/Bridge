namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DeptShiftPagers
{
    public string Resort { get; set; }
    public string DeptId { get; set; }
    public string ShiftId { get; set; }
    public string ShiftPager { get; set; }
    public string InactiveYn { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DeptShiftPagers>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.DeptId, e.ShiftId })
                .HasName("DEPT_SHIFT_PAGERS_PK");

            entity.ToTable("DEPT_SHIFT_PAGERS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ShiftId)
                .HasColumnName("SHIFT_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShiftPager)
                .IsRequired()
                .HasColumnName("SHIFT_PAGER")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
