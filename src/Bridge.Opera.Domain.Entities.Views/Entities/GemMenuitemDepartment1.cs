namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemMenuitemDepartment1
{
    public decimal? MitId { get; set; }
    public string? Resort { get; set; }
    public string? DeptId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuitemDepartment1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_MENUITEM_DEPARTMENT");

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
