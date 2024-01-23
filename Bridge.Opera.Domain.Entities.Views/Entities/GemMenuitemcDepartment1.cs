namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemMenuitemcDepartment1
{
    public decimal MicId { get; set; }
    public string Resort { get; set; }
    public string DeptId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuitemcDepartment1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_MENUITEMC_DEPARTMENT");

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.MicId)
                .HasColumnName("MIC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
