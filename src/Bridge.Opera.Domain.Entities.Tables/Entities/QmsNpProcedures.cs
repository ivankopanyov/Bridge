namespace Bridge.Opera.Domain.Entities.Tables;

public partial class QmsNpProcedures
{
    public string? Resort { get; set; }
    public string? Status { get; set; }
    public decimal? ProcedureSeq { get; set; }
    public string? ProcedureName { get; set; }
    public string? ProcedureDescription { get; set; }
    public DateTime? CreatedDate { get; set; }
    public decimal? CreatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public decimal? UpdatedBy { get; set; }
    public string? ExecuteToday { get; set; }
    public DateTime? ExecutedDate { get; set; }
    public decimal? ExecutedBy { get; set; }
    public string? ToBeLogged { get; set; }
    public string? LogFile { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QmsNpProcedures>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("QMS_NP_PROCEDURES");

            entity.Property(e => e.CreatedBy)
                .HasColumnName("CREATED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CreatedDate)
                .HasColumnName("CREATED_DATE")
                .HasColumnType("DATE")
                .HasDefaultValueSql("sysdate ");

            entity.Property(e => e.ExecuteToday)
                .HasColumnName("EXECUTE_TODAY")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.ExecutedBy)
                .HasColumnName("EXECUTED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExecutedDate)
                .HasColumnName("EXECUTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LogFile)
                .HasColumnName("LOG_FILE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProcedureDescription)
                .HasColumnName("PROCEDURE_DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProcedureName)
                .IsRequired()
                .HasColumnName("PROCEDURE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ProcedureSeq)
                .HasColumnName("PROCEDURE_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ToBeLogged)
                .HasColumnName("TO_BE_LOGGED")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdatedDate)
                .HasColumnName("UPDATED_DATE")
                .HasColumnType("DATE");
        });
	}
}
