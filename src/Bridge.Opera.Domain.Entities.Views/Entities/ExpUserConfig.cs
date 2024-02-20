namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUserConfig
{
    public string? RecordType { get; set; }
    public string? SourceSystem { get; set; }
    public string? PropertyCode { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? UserId { get; set; }
    public string? UserPrimaryPhone { get; set; }
    public string? UserPrimaryFax { get; set; }
    public string? UserPrimaryEmail { get; set; }
    public DateTime? ExpiresOn { get; set; }
    public string? EmpStatus { get; set; }
    public DateTime? InsertDateTime { get; set; }
    public string? UserName { get; set; }
    public string? UserTitleDesc { get; set; }
    public string? UserTitleCode { get; set; }
    public string? First { get; set; }
    public string? Last { get; set; }
    public string? Middle { get; set; }
    public string? MaleFemale { get; set; }
    public decimal? InsertUserId { get; set; }
    public DateTime? UpdateDateTime { get; set; }
    public decimal? UpdateUserId { get; set; }
    public string? SrepCode { get; set; }
    public string? DeptCode { get; set; }
    public string? DeptDesc { get; set; }
    public DateTime? DisabledUntil { get; set; }
    public DateTime? DateHired { get; set; }
    public string? InternalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUserConfig>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_USER_CONFIG");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DateHired)
                .HasColumnName("DATE_HIRED")
                .HasColumnType("DATE");

            entity.Property(e => e.DeptCode)
                .HasColumnName("DEPT_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DeptDesc)
                .HasColumnName("DEPT_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DisabledUntil)
                .HasColumnName("DISABLED_UNTIL")
                .HasColumnType("DATE");

            entity.Property(e => e.EmpStatus)
                .HasColumnName("EMP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExpiresOn)
                .HasColumnName("EXPIRES_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDateTime)
                .HasColumnName("INSERT_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUserId)
                .HasColumnName("INSERT_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Last)
                .HasColumnName("LAST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MaleFemale)
                .HasColumnName("MALE_FEMALE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RecordType)
                .HasColumnName("RECORD_TYPE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.SourceSystem)
                .HasColumnName("SOURCE_SYSTEM")
                .HasColumnType("CHAR(5)");

            entity.Property(e => e.SrepCode)
                .HasColumnName("SREP_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDateTime)
                .HasColumnName("UPDATE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUserId)
                .HasColumnName("UPDATE_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasColumnName("USER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UserPrimaryEmail)
                .HasColumnName("USER_PRIMARY_EMAIL")
                .IsUnicode(false);

            entity.Property(e => e.UserPrimaryFax)
                .HasColumnName("USER_PRIMARY_FAX")
                .IsUnicode(false);

            entity.Property(e => e.UserPrimaryPhone)
                .HasColumnName("USER_PRIMARY_PHONE")
                .IsUnicode(false);

            entity.Property(e => e.UserTitleCode)
                .HasColumnName("USER_TITLE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UserTitleDesc)
                .HasColumnName("USER_TITLE_DESC")
                .IsUnicode(false);
        });
	}
}
