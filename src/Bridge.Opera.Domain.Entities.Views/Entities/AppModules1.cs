namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AppModules1
{
    public string? WhenToExecute { get; set; }
    public DateTime? Date3 { get; set; }
    public decimal? ModuleId { get; set; }
    public string? ModuleType { get; set; }
    public string? ModuleName { get; set; }
    public string? ModuleDesc { get; set; }
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
    public string? Frequency { get; set; }
    public DateTime? Date1 { get; set; }
    public DateTime? Date2 { get; set; }
    public DateTime? Date4 { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? RModuleId { get; set; }
    public string? ReportProcedureYn { get; set; }
    public string? LanguageCode { get; set; }
    public string? FormToRun { get; set; }
    public string? UserDefinedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AppModules1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("APP_MODULES");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CallParameters)
                .HasColumnName("CALL_PARAMETERS")
                .HasMaxLength(2000)
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
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(1)
                .IsUnicode(false);

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

            entity.Property(e => e.NaSequence)
                .HasColumnName("NA_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutputFile)
                .HasColumnName("OUTPUT_FILE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PrintYn)
                .HasColumnName("PRINT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RModuleId)
                .HasColumnName("R_MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportProcedureYn)
                .HasColumnName("REPORT_PROCEDURE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ScreenYn)
                .HasColumnName("SCREEN_YN")
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

            entity.Property(e => e.UserDefinedYn)
                .HasColumnName("USER_DEFINED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WhenToExecute)
                .HasColumnName("WHEN_TO_EXECUTE")
                .HasMaxLength(1000)
                .IsUnicode(false);
        });
	}
}
