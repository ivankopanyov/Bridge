namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidDepartment
{
    public string? DeptId { get; set; }
    public string? DeptName { get; set; }
    public string? Resort { get; set; }
    public string? DeptManagerPager { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? MessageText { get; set; }
    public decimal? OrderBy { get; set; }
    public string? DeptEmail { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidDepartment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_DEPARTMENT");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DeptEmail)
                .HasColumnName("DEPT_EMAIL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DeptManagerPager)
                .HasColumnName("DEPT_MANAGER_PAGER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DeptName)
                .IsRequired()
                .HasColumnName("DEPT_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MessageText)
                .HasColumnName("MESSAGE_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
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
