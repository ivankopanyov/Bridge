namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortHkEmployees
{
    public string? EmpId { get; set; }
    public string? HkSectionCode { get; set; }
    public string? EmpName { get; set; }
    public string? Floor { get; set; }
    public string? Resort { get; set; }
    public string? Available { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public string? JobCode { get; set; }
    public string? PhoneNo { get; set; }
    public decimal? AppUserId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortHkEmployees>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESORT_HK_EMPLOYEES");

            entity.HasIndex(e => e.AppUserId)
                .HasName("HK_EMPLOYEE_APPUSER_IDX");

            entity.HasIndex(e => new { e.EmpId, e.Resort })
                .HasName("HK_EMPLOYEES_UK")
                .IsUnique();

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Available)
                .HasColumnName("AVAILABLE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmpId)
                .IsRequired()
                .HasColumnName("EMP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmpName)
                .IsRequired()
                .HasColumnName("EMP_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Floor)
                .HasColumnName("FLOOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HkSectionCode)
                .HasColumnName("HK_SECTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.JobCode)
                .HasColumnName("JOB_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNo)
                .HasColumnName("PHONE_NO")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
