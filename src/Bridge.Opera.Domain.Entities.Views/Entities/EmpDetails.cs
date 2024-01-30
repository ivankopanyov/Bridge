namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EmpDetails
{
    public decimal? NameId { get; set; }
    public string? Resort { get; set; }
    public string? DeptId { get; set; }
    public string? EmpStatus { get; set; }
    public string? MaleFemale { get; set; }
    public decimal? UserPbxId { get; set; }
    public DateTime? DateHired { get; set; }
    public string? WorkPermitNo { get; set; }
    public DateTime? WorkPermitExpdate { get; set; }
    public decimal? HoursPerWeek { get; set; }
    public string? RateType { get; set; }
    public string? HireType { get; set; }
    public string? SalaryInterval { get; set; }
    public string? RehireYn { get; set; }
    public string? EmpExtension { get; set; }
    public string? TermReason { get; set; }
    public DateTime? TerminatedDate { get; set; }
    public string? InactiveReasonCode { get; set; }
    public DateTime? InactiveFrom { get; set; }
    public DateTime? InactiveTo { get; set; }
    public decimal? HourlyRate { get; set; }
    public decimal? WeeklySalary { get; set; }
    public decimal? OtMultiplier { get; set; }
    public decimal? WeekMin { get; set; }
    public decimal? WeekMax { get; set; }
    public decimal? MondayMin { get; set; }
    public decimal? MondayMax { get; set; }
    public decimal? TuesdayMin { get; set; }
    public decimal? TuesdayMax { get; set; }
    public decimal? WednesdayMin { get; set; }
    public decimal? WednesdayMax { get; set; }
    public decimal? ThursdayMin { get; set; }
    public decimal? ThursdayMax { get; set; }
    public decimal? FridayMin { get; set; }
    public decimal? FridayMax { get; set; }
    public decimal? SaturdayMin { get; set; }
    public decimal? SaturdayMax { get; set; }
    public decimal? SundayMin { get; set; }
    public decimal? SundayMax { get; set; }
    public string? Comments { get; set; }
    public string? EmpPager { get; set; }
    public decimal? LaptopId { get; set; }
    public string? LeadAddress { get; set; }
    public string? LeadComm { get; set; }
    public string? LeadAddressDet { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EmpDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EMP_DETAILS");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DateHired)
                .HasColumnName("DATE_HIRED")
                .HasColumnType("DATE");

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EmpExtension)
                .HasColumnName("EMP_EXTENSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmpPager)
                .HasColumnName("EMP_PAGER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EmpStatus)
                .HasColumnName("EMP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FridayMax)
                .HasColumnName("FRIDAY_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FridayMin)
                .HasColumnName("FRIDAY_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HireType)
                .HasColumnName("HIRE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HourlyRate)
                .HasColumnName("HOURLY_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HoursPerWeek)
                .HasColumnName("HOURS_PER_WEEK")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.LaptopId)
                .HasColumnName("LAPTOP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadAddress)
                .HasColumnName("LEAD_ADDRESS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LeadAddressDet)
                .HasColumnName("LEAD_ADDRESS_DET")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.LeadComm)
                .HasColumnName("LEAD_COMM")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.MaleFemale)
                .HasColumnName("MALE_FEMALE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MondayMax)
                .HasColumnName("MONDAY_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MondayMin)
                .HasColumnName("MONDAY_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtMultiplier)
                .HasColumnName("OT_MULTIPLIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateType)
                .HasColumnName("RATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RehireYn)
                .HasColumnName("REHIRE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SalaryInterval)
                .HasColumnName("SALARY_INTERVAL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SaturdayMax)
                .HasColumnName("SATURDAY_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SaturdayMin)
                .HasColumnName("SATURDAY_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SundayMax)
                .HasColumnName("SUNDAY_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SundayMin)
                .HasColumnName("SUNDAY_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TermReason)
                .HasColumnName("TERM_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TerminatedDate)
                .HasColumnName("TERMINATED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ThursdayMax)
                .HasColumnName("THURSDAY_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ThursdayMin)
                .HasColumnName("THURSDAY_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TuesdayMax)
                .HasColumnName("TUESDAY_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TuesdayMin)
                .HasColumnName("TUESDAY_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserPbxId)
                .HasColumnName("USER_PBX_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WednesdayMax)
                .HasColumnName("WEDNESDAY_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WednesdayMin)
                .HasColumnName("WEDNESDAY_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WeekMax)
                .HasColumnName("WEEK_MAX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WeekMin)
                .HasColumnName("WEEK_MIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WeeklySalary)
                .HasColumnName("WEEKLY_SALARY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WorkPermitExpdate)
                .HasColumnName("WORK_PERMIT_EXPDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.WorkPermitNo)
                .HasColumnName("WORK_PERMIT_NO")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
