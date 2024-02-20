namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AppModules
{
    public AppModules()
    {
        AppModuleDependenciesModule = new HashSet<AppModuleDependencies>();
        AppModuleDependenciesRModule = new HashSet<AppModuleDependencies>();
        AppModuleDetails = new HashSet<AppModuleDetails>();
        GdsHostsConfLetters = new HashSet<GdsHostsConfLetters>();
        InverseRModule = new HashSet<AppModules>();
        NightAuditProcedures = new HashSet<NightAuditProcedures>();
        OsrFields = new HashSet<OsrFields>();
        ReservationConfLetter = new HashSet<ReservationConfLetter>();
        ShiftReportsAttachedModule = new HashSet<ShiftReports>();
        ShiftReportsShiftGroup = new HashSet<ShiftReports>();
    }

    public decimal? ModuleId { get; set; }
    public string? ModuleType { get; set; }
    public string? ModuleName { get; set; }
    public string? ModuleDesc { get; set; }
    public string? LanguageCode { get; set; }
    public string? Destination { get; set; }
    public string? IconName { get; set; }
    public string? GraphFileName { get; set; }
    public string? CallParameters { get; set; }
    public decimal? NaSequence { get; set; }
    public string? ScreenYn { get; set; }
    public string? SystemYn { get; set; }
    public string? FileYn { get; set; }
    public string? PrintYn { get; set; }
    public string? ActiveYn { get; set; }
    public string? OutputFile { get; set; }
    public string? WhenToExecute { get; set; }
    public string? Frequency { get; set; }
    public DateTime? Date1 { get; set; }
    public DateTime? Date2 { get; set; }
    public DateTime? Date3 { get; set; }
    public DateTime? Date4 { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? RModuleId { get; set; }
    public string? Resort { get; set; }
    public string? CanBeRunSeparately { get; set; }
    public string? DefaultModuleType { get; set; }
    public string? ReportProcedureYn { get; set; }
    public string? FormToRun { get; set; }
    public decimal? TotalRuns { get; set; }
    public DateTime? LastRun { get; set; }
    public decimal? LastRunUser { get; set; }
    public string? ProtectedYn { get; set; }
    public string? UsedInApp { get; set; }
    public string? MultiPropertyYn { get; set; }
    public string? AllowDeleteYn { get; set; }
    public string? AllowMultipleYn { get; set; }
    public string? UserDefinedYn { get; set; }
    public string? MultiPapersizeYn { get; set; }
    public decimal? Copies { get; set; }
    public string? ChainCode { get; set; }
    public string? StreamPrintingYn { get; set; }
    public string? DataSourceType { get; set; }
    public string? DataSource { get; set; }
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

    public virtual AppModules RModule { get; set; }
    public virtual ICollection<AppModuleDependencies> AppModuleDependenciesModule { get; set; }
    public virtual ICollection<AppModuleDependencies> AppModuleDependenciesRModule { get; set; }
    public virtual ICollection<AppModuleDetails> AppModuleDetails { get; set; }
    public virtual ICollection<GdsHostsConfLetters> GdsHostsConfLetters { get; set; }
    public virtual ICollection<AppModules> InverseRModule { get; set; }
    public virtual ICollection<NightAuditProcedures> NightAuditProcedures { get; set; }
    public virtual ICollection<OsrFields> OsrFields { get; set; }
    public virtual ICollection<ReservationConfLetter> ReservationConfLetter { get; set; }
    public virtual ICollection<ShiftReports> ShiftReportsAttachedModule { get; set; }
    public virtual ICollection<ShiftReports> ShiftReportsShiftGroup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppModules>(entity =>
        {
            entity.HasKey(e => e.ModuleId)
                .HasName("APP_MODULES_PK");

            entity.ToTable("APP$_MODULES");

            entity.HasIndex(e => e.RModuleId)
                .HasName("APP_MODULES_FK_IDX");

            entity.HasIndex(e => new { e.ChainCode, e.ModuleType })
                .HasName("APP_CHAIN_IDX");

            entity.HasIndex(e => new { e.ModuleType, e.Resort })
                .HasName("APP_MODULE_TYPE_IDX");

            entity.HasIndex(e => new { e.Resort, e.ModuleName, e.ModuleDesc, e.RModuleId, e.ChainCode })
                .HasName("APP_MODULES_UK")
                .IsUnique();

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AllowDeleteYn)
                .HasColumnName("ALLOW_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.AllowMultipleYn)
                .HasColumnName("ALLOW_MULTIPLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.CallParameters)
                .HasColumnName("CALL_PARAMETERS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CanBeRunSeparately)
                .HasColumnName("CAN_BE_RUN_SEPARATELY")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Copies)
                .HasColumnName("COPIES")
                .HasColumnType("NUMBER")
                .HasDefaultValueSql("1 ");

            entity.Property(e => e.DataSource)
                .HasColumnName("DATA_SOURCE")
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.DataSourceType)
                .HasColumnName("DATA_SOURCE_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Date1)
                .HasColumnName("DATE1")
                .HasColumnType("DATE");

            entity.Property(e => e.Date2)
                .HasColumnName("DATE2")
                .HasColumnType("DATE");

            entity.Property(e => e.Date3)
                .HasColumnName("DATE3")
                .HasColumnType("DATE");

            entity.Property(e => e.Date4)
                .HasColumnName("DATE4")
                .HasColumnType("DATE");

            entity.Property(e => e.DefaultModuleType)
                .HasColumnName("DEFAULT_MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Destination)
                .HasColumnName("DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FileYn)
                .HasColumnName("FILE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FormToRun)
                .HasColumnName("FORM_TO_RUN")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'B'");

            entity.Property(e => e.GraphFileName)
                .HasColumnName("GRAPH_FILE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.IconName)
                .HasColumnName("ICON_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LastRun)
                .HasColumnName("LAST_RUN")
                .HasColumnType("DATE");

            entity.Property(e => e.LastRunUser)
                .HasColumnName("LAST_RUN_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ModuleDesc)
                .HasColumnName("MODULE_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ModuleType)
                .IsRequired()
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MultiPapersizeYn)
                .HasColumnName("MULTI_PAPERSIZE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.MultiPropertyYn)
                .HasColumnName("MULTI_PROPERTY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NaSequence)
                .HasColumnName("NA_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutputExcelYn)
                .HasColumnName("OUTPUT_EXCEL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OutputFile)
                .HasColumnName("OUTPUT_FILE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrintYn)
                .HasColumnName("PRINT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProtectedYn)
                .HasColumnName("PROTECTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RModuleId)
                .HasColumnName("R_MODULE_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReportProcedureYn)
                .HasColumnName("REPORT_PROCEDURE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ScreenYn)
                .HasColumnName("SCREEN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StreamPrintingYn)
                .HasColumnName("STREAM_PRINTING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SystemYn)
                .HasColumnName("SYSTEM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TotalRuns)
                .HasColumnName("TOTAL_RUNS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UserDefinedYn)
                .HasColumnName("USER_DEFINED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.WatermarkAngle)
                .HasColumnName("WATERMARK_ANGLE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WatermarkColorB)
                .HasColumnName("WATERMARK_COLOR_B")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WatermarkColorG)
                .HasColumnName("WATERMARK_COLOR_G")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WatermarkColorR)
                .HasColumnName("WATERMARK_COLOR_R")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WatermarkFont)
                .HasColumnName("WATERMARK_FONT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WatermarkFontSize)
                .HasColumnName("WATERMARK_FONT_SIZE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WatermarkMode)
                .HasColumnName("WATERMARK_MODE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WatermarkText)
                .HasColumnName("WATERMARK_TEXT")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WatermarkXpos)
                .HasColumnName("WATERMARK_XPOS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WatermarkYpos)
                .HasColumnName("WATERMARK_YPOS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WhenToExecute)
                .HasColumnName("WHEN_TO_EXECUTE")
                .HasMaxLength(1000)
                .IsUnicode(false);

			if (!types.Contains(typeof(AppModules)))
				entity.Ignore(e => e.RModule);
			else
	            entity.HasOne(d => d.RModule)
	                .WithMany(p => p.InverseRModule)
	                .HasForeignKey(d => d.RModuleId)
	                .HasConstraintName("APP_MODULES_FK");
        
			if (!types.Contains(typeof(AppModuleDependencies)))
				entity.Ignore(e => e.AppModuleDependenciesModule);

			if (!types.Contains(typeof(AppModuleDependencies)))
				entity.Ignore(e => e.AppModuleDependenciesRModule);

			if (!types.Contains(typeof(AppModuleDetails)))
				entity.Ignore(e => e.AppModuleDetails);

			if (!types.Contains(typeof(GdsHostsConfLetters)))
				entity.Ignore(e => e.GdsHostsConfLetters);

			if (!types.Contains(typeof(AppModules)))
				entity.Ignore(e => e.InverseRModule);

			if (!types.Contains(typeof(NightAuditProcedures)))
				entity.Ignore(e => e.NightAuditProcedures);

			if (!types.Contains(typeof(OsrFields)))
				entity.Ignore(e => e.OsrFields);

			if (!types.Contains(typeof(ReservationConfLetter)))
				entity.Ignore(e => e.ReservationConfLetter);

			if (!types.Contains(typeof(ShiftReports)))
				entity.Ignore(e => e.ShiftReportsAttachedModule);

			if (!types.Contains(typeof(ShiftReports)))
				entity.Ignore(e => e.ShiftReportsShiftGroup);
		});
	}
}
