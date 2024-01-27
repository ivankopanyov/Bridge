namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CompanyGroup
{
    public decimal? NameXrefId { get; set; }
    public string CompanyGroupId { get; set; }
    public decimal? CompanyGroupSeq { get; set; }
    public string NameType { get; set; }
    public string CompanyGroupName { get; set; }
    public string Sname { get; set; }
    public string CompanyGroupParentSeq { get; set; }
    public string ParentNameType { get; set; }
    public string CompanyGroupParentName { get; set; }
    public string ParentSname { get; set; }
    public string ResortRegistered { get; set; }
    public decimal? AppUserId { get; set; }
    public string AppUser { get; set; }
    public string DeptId { get; set; }
    public string BookerPermission { get; set; }
    public string BookerPermissionDisplay { get; set; }
    public string PublicRatesPermissionYn { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CompanyGroup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COMPANY_GROUP");

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookerPermission)
                .HasColumnName("BOOKER_PERMISSION")
                .IsUnicode(false);

            entity.Property(e => e.BookerPermissionDisplay)
                .HasColumnName("BOOKER_PERMISSION_DISPLAY")
                .IsUnicode(false);

            entity.Property(e => e.CompanyGroupId)
                .HasColumnName("COMPANY_GROUP_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompanyGroupName)
                .HasColumnName("COMPANY_GROUP_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.CompanyGroupParentName)
                .HasColumnName("COMPANY_GROUP_PARENT_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.CompanyGroupParentSeq)
                .HasColumnName("COMPANY_GROUP_PARENT_SEQ")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompanyGroupSeq)
                .HasColumnName("COMPANY_GROUP_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeptId)
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
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

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameXrefId)
                .HasColumnName("NAME_XREF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentNameType)
                .HasColumnName("PARENT_NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParentSname)
                .HasColumnName("PARENT_SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PublicRatesPermissionYn)
                .HasColumnName("PUBLIC_RATES_PERMISSION_YN")
                .IsUnicode(false);

            entity.Property(e => e.ResortRegistered)
                .HasColumnName("RESORT_REGISTERED")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .HasColumnName("SNAME")
                .HasMaxLength(80)
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
