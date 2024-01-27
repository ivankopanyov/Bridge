namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExceptionLog
{
    public decimal Sid { get; set; }
    public string Username { get; set; }
    public string Machine { get; set; }
    public string Terminal { get; set; }
    public string Context { get; set; }
    public string ErrorCode { get; set; }
    public string ErrorMessage { get; set; }
    public DateTime TimeOccurred { get; set; }
    public string ErrorType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExceptionLog>(entity =>
        {
            entity.HasKey(e => new { e.Sid, e.TimeOccurred })
                .HasName("PMS_ERROR_LOG_PK");

            entity.ToTable("EXCEPTION_LOG");

            entity.Property(e => e.Sid)
                .HasColumnName("SID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeOccurred)
                .HasColumnName("TIME_OCCURRED")
                .HasColumnType("DATE");

            entity.Property(e => e.Context)
                .HasColumnName("CONTEXT")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ErrorCode)
                .HasColumnName("ERROR_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ErrorType)
                .HasColumnName("ERROR_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Username)
                .HasColumnName("USERNAME")
                .HasMaxLength(30)
                .IsUnicode(false);
        });
	}
}
