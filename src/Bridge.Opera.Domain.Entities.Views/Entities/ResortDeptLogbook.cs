namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortDeptLogbook
{
    public string? Resort { get; set; }
    public decimal? LogbookId { get; set; }
    public string? DeptId { get; set; }
    public string? DepartmentName { get; set; }
    public DateTime? LogDate { get; set; }
    public string? LogTime { get; set; }
    public string? LogText { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortDeptLogbook>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_DEPT_LOGBOOK");

            entity.Property(e => e.DepartmentName)
                .HasColumnName("DEPARTMENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LogDate)
                .HasColumnName("LOG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LogText)
                .IsRequired()
                .HasColumnName("LOG_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LogTime)
                .HasColumnName("LOG_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.LogbookId)
                .HasColumnName("LOGBOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
