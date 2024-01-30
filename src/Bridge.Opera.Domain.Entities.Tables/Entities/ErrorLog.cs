namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ErrorLog
{
    public string? Resort { get; set; }
    public DateTime? RunDate { get; set; }
    public string? ProgramName { get; set; }
    public string? ErrorCode { get; set; }
    public string? ErrorText { get; set; }
    public string? Remarks { get; set; }
    public decimal? InsertUser { get; set; }
    public string? Action { get; set; }
    public string? FromResort { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ERROR_LOG");

            entity.HasIndex(e => new { e.RunDate, e.Resort })
                .HasName("ERROR_LOG_IDX");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ErrorCode)
                .HasColumnName("ERROR_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ErrorText)
                .HasColumnName("ERROR_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FromResort)
                .HasColumnName("FROM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProgramName)
                .HasColumnName("PROGRAM_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RunDate)
                .HasColumnName("RUN_DATE")
                .HasColumnType("DATE");
        });
	}
}
