namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EmpAvexceptionV
{
    public decimal? NameId { get; set; }
    public string? Last { get; set; }
    public string? First { get; set; }
    public string? FullName { get; set; }
    public string? Resort { get; set; }
    public string? DeptId { get; set; }
    public string? DeptName { get; set; }
    public DateTime? AbsentFrom { get; set; }
    public DateTime? ReturnOn { get; set; }
    public string? ReasonCode { get; set; }
    public string? ReasonDesc { get; set; }
    public decimal? UserPbxId { get; set; }
    public DateTime? InactiveFrom { get; set; }
    public DateTime? InactiveTo { get; set; }
    public string? InactiveReasonCode { get; set; }
    public string? Comments { get; set; }
    public string? EmpStatus { get; set; }
    public string? JobCode { get; set; }
    public string? Position { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmpAvexceptionV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EMP_AVEXCEPTION_V");

            entity.Property(e => e.AbsentFrom)
                .HasColumnName("ABSENT_FROM")
                .HasColumnType("DATE");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DeptName)
                .HasColumnName("DEPT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.EmpStatus)
                .HasColumnName("EMP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.InactiveFrom)
                .HasColumnName("INACTIVE_FROM")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveReasonCode)
                .HasColumnName("INACTIVE_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveTo)
                .HasColumnName("INACTIVE_TO")
                .HasColumnType("DATE");

            entity.Property(e => e.JobCode)
                .HasColumnName("JOB_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Position)
                .HasColumnName("POSITION")
                .IsUnicode(false);

            entity.Property(e => e.ReasonCode)
                .IsRequired()
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReasonDesc)
                .HasColumnName("REASON_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReturnOn)
                .HasColumnName("RETURN_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.UserPbxId)
                .HasColumnName("USER_PBX_ID")
                .HasColumnType("NUMBER");
        });
	}
}
