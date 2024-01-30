namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DeptShiftPagersView
{
    public string? Resort { get; set; }
    public string? DeptId { get; set; }
    public string? ShiftId { get; set; }
    public string? ShiftPager { get; set; }
    public string? WorkCategories { get; set; }
    public string? Areas { get; set; }
    public string? InactiveYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DeptShiftPagersView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DEPT_SHIFT_PAGERS_VIEW");

            entity.Property(e => e.Areas)
                .HasColumnName("AREAS")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShiftId)
                .IsRequired()
                .HasColumnName("SHIFT_ID")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ShiftPager)
                .IsRequired()
                .HasColumnName("SHIFT_PAGER")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WorkCategories)
                .HasColumnName("WORK_CATEGORIES")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
