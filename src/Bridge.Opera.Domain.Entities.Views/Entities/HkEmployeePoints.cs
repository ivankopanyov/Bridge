namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HkEmployeePoints
{
    public DateTime? PointsDate { get; set; }
    public string? EmpId { get; set; }
    public decimal? Points { get; set; }
    public string? EmpName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HkEmployeePoints>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HK_EMPLOYEE_POINTS");

            entity.Property(e => e.EmpId)
                .IsRequired()
                .HasColumnName("EMP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmpName)
                .HasColumnName("EMP_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointsDate)
                .HasColumnName("POINTS_DATE")
                .HasColumnType("DATE");
        });
	}
}
