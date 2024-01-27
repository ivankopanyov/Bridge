namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExternalReportsView
{
    public decimal ModuleId { get; set; }
    public string ModuleName { get; set; }
    public string ModuleDesc { get; set; }
    public string LanguageCode { get; set; }
    public decimal GroupModuleId { get; set; }
    public string GroupDesc { get; set; }
    public string ActiveYn { get; set; }
    public string ReportType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExternalReportsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXTERNAL_REPORTS_VIEW");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupDesc)
                .HasColumnName("GROUP_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.GroupModuleId)
                .HasColumnName("GROUP_MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModuleDesc)
                .HasColumnName("MODULE_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReportType)
                .HasColumnName("REPORT_TYPE")
                .IsUnicode(false);
        });
	}
}
