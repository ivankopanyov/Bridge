namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortHkEmployeePoints
{
    public DateTime PointsDate { get; set; }
    public string EmpId { get; set; }
    public decimal Points { get; set; }
    public string Resort { get; set; }
    public string EmpName { get; set; }

    public virtual ResortHkEmployees ResortHkEmployees { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortHkEmployeePoints>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_HK_EMPLOYEE_POINTS");

            entity.HasIndex(e => new { e.EmpId, e.Resort })
                .HasName("HK_EMPLOYEE_POINTS_FKI");

            entity.HasIndex(e => new { e.PointsDate, e.EmpId, e.Resort })
                .HasName("HK_EMPLOYEE_POINTS_UK")
                .IsUnique();

            entity.Property(e => e.EmpId)
                .IsRequired()
                .HasColumnName("EMP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmpName)
                .HasColumnName("EMP_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PointsDate)
                .HasColumnName("POINTS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ResortHkEmployees)))
				entity.Ignore(e => e.ResortHkEmployees);
			else
	            entity.HasOne(d => d.ResortHkEmployees)
	                .WithMany()
	                .HasPrincipalKey(p => new { p.EmpId, p.Resort })
	                .HasForeignKey(d => new { d.EmpId, d.Resort })
	                .HasConstraintName("HK_EMPLOYEE_POINTS_FK");
        });
	}
}
