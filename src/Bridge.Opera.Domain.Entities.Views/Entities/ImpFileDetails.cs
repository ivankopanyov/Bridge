namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ImpFileDetails
{
    public string? Resort { get; set; }
    public string? ImpFileType { get; set; }
    public string? ImpDesc { get; set; }
    public string? ImpFileCode { get; set; }
    public string? ImpCntrlName { get; set; }
    public string? ImpPreProcess { get; set; }
    public string? ImpProcess { get; set; }
    public string? InactiveYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? ConfigMode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ImpFileDetails>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IMP_FILE_DETAILS");

            entity.Property(e => e.ConfigMode)
                .HasColumnName("CONFIG_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ImpCntrlName)
                .HasColumnName("IMP_CNTRL_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ImpDesc)
                .HasColumnName("IMP_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ImpFileCode)
                .IsRequired()
                .HasColumnName("IMP_FILE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ImpFileType)
                .IsRequired()
                .HasColumnName("IMP_FILE_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ImpPreProcess)
                .HasColumnName("IMP_PRE_PROCESS")
                .IsUnicode(false);

            entity.Property(e => e.ImpProcess)
                .HasColumnName("IMP_PROCESS")
                .IsUnicode(false);

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
