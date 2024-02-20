namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AppModulesView
{
    public decimal? ModuleId { get; set; }
    public string? ModuleName { get; set; }
    public string? ModuleDesc { get; set; }
    public string? ModuleType { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? InsertUser { get; set; }
    public string? InsertDate { get; set; }
    public string? RelModName { get; set; }
    public string? AnyParameters { get; set; }
    public string? CanBeRunSeparately { get; set; }
    public string? ReportProcedureYn { get; set; }
    public string? LanguageCode { get; set; }
    public string? FormToRun { get; set; }
    public string? Destination { get; set; }
    public string? ProtectedYn { get; set; }
    public string? UsedInApp { get; set; }
    public string? UserDefinedYn { get; set; }
    public string? GroupInApp { get; set; }
    public decimal? Copies { get; set; }
    public decimal? GroupModuleId { get; set; }
    public string? GroupDesc { get; set; }
    public string? DefaultModuleType { get; set; }
    public string? DataSourceType { get; set; }
    public string? DataSource { get; set; }
    public string? ActiveYn { get; set; }
    public string? SystemYn { get; set; }
    public string? WatermarkMode { get; set; }
    public string? WatermarkText { get; set; }
    public decimal? WatermarkXpos { get; set; }
    public decimal? WatermarkYpos { get; set; }
    public decimal? WatermarkAngle { get; set; }
    public decimal? WatermarkColorR { get; set; }
    public decimal? WatermarkColorG { get; set; }
    public decimal? WatermarkColorB { get; set; }
    public string? WatermarkFont { get; set; }
    public decimal? WatermarkFontSize { get; set; }
    public string? OutputExcelYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppModulesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("APP_MODULES_VIEW");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AnyParameters)
                .HasColumnName("ANY_PARAMETERS")
                .IsUnicode(false);

            entity.Property(e => e.CanBeRunSeparately)
                .HasColumnName("CAN_BE_RUN_SEPARATELY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Copies)
                .HasColumnName("COPIES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DataSource)
                .HasColumnName("DATA_SOURCE")
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.DataSourceType)
                .HasColumnName("DATA_SOURCE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DefaultModuleType)
                .HasColumnName("DEFAULT_MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FormToRun)
                .HasColumnName("FORM_TO_RUN")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GroupDesc)
                .HasColumnName("GROUP_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.GroupInApp)
                .HasColumnName("GROUP_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GroupModuleId)
                .HasColumnName("GROUP_MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .IsUnicode(false);

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

            entity.Property(e => e.ModuleType)
                .IsRequired()
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OutputExcelYn)
                .HasColumnName("OUTPUT_EXCEL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProtectedYn)
                .HasColumnName("PROTECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RelModName)
                .IsRequired()
                .HasColumnName("REL_MOD_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReportProcedureYn)
                .HasColumnName("REPORT_PROCEDURE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SystemYn)
                .HasColumnName("SYSTEM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UserDefinedYn)
                .HasColumnName("USER_DEFINED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WatermarkAngle)
                .HasColumnName("WATERMARK_ANGLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkColorB)
                .HasColumnName("WATERMARK_COLOR_B")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkColorG)
                .HasColumnName("WATERMARK_COLOR_G")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkColorR)
                .HasColumnName("WATERMARK_COLOR_R")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkFont)
                .HasColumnName("WATERMARK_FONT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WatermarkFontSize)
                .HasColumnName("WATERMARK_FONT_SIZE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkMode)
                .HasColumnName("WATERMARK_MODE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WatermarkText)
                .HasColumnName("WATERMARK_TEXT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.WatermarkXpos)
                .HasColumnName("WATERMARK_XPOS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WatermarkYpos)
                .HasColumnName("WATERMARK_YPOS")
                .HasColumnType("NUMBER");
        });
	}
}
