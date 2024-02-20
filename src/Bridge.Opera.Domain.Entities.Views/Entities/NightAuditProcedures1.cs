namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NightAuditProcedures1
{
    public decimal? NaId { get; set; }
    public DateTime? Date4 { get; set; }
    public DateTime? Date3 { get; set; }
    public DateTime? Date2 { get; set; }
    public DateTime? Date1 { get; set; }
    public string? Frequency { get; set; }
    public string? WhenToExecute { get; set; }
    public string? OutputFile { get; set; }
    public string? BeforeIncomeAuditYn { get; set; }
    public string? ActiveYn { get; set; }
    public string? PrintYn { get; set; }
    public string? FileYn { get; set; }
    public string? ScreenYn { get; set; }
    public string? ReportProcedureFlag { get; set; }
    public string? ListName { get; set; }
    public decimal? NaSequence { get; set; }
    public string? ProcedureName { get; set; }
    public decimal? ModuleId { get; set; }
    public byte? Copies { get; set; }
    public string? MandatoryYn { get; set; }
    public string? SpoolName { get; set; }
    public string? FileFormat { get; set; }
    public string? DeviceDriver { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NightAuditProcedures1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NIGHT_AUDIT_PROCEDURES");

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeforeIncomeAuditYn)
                .HasColumnName("BEFORE_INCOME_AUDIT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Copies)
                .HasColumnName("COPIES")
                .HasColumnType("NUMBER(2)");

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

            entity.Property(e => e.DeviceDriver)
                .HasColumnName("DEVICE_DRIVER")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FileFormat)
                .HasColumnName("FILE_FORMAT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FileYn)
                .HasColumnName("FILE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Frequency)
                .HasColumnName("FREQUENCY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ListName)
                .HasColumnName("LIST_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryYn)
                .HasColumnName("MANDATORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ModuleId)
                .HasColumnName("MODULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NaId)
                .HasColumnName("NA_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.ProcedureName)
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReportProcedureFlag)
                .HasColumnName("REPORT_PROCEDURE_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ScreenYn)
                .HasColumnName("SCREEN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SpoolName)
                .HasColumnName("SPOOL_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.WhenToExecute)
                .HasColumnName("WHEN_TO_EXECUTE")
                .HasMaxLength(1000)
                .IsUnicode(false);
        });
	}
}
