namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsPingMessage
{
    public string EchoToken { get; set; }
    public string Status { get; set; }
    public string ErrorText { get; set; }
    public decimal? RetryCount { get; set; }
    public string ErrorCode { get; set; }
    public string SubCode { get; set; }
    public string OldEchoToken { get; set; }
    public string ResendYn { get; set; }
    public DateTime InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsPingMessage>(entity =>
        {
            entity.HasKey(e => e.EchoToken)
                .HasName("GDS_PING_MESSAGE_PK");

            entity.ToTable("GDS_PING_MESSAGE");

            entity.Property(e => e.EchoToken)
                .HasColumnName("ECHO_TOKEN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorCode)
                .HasColumnName("ERROR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorText)
                .HasColumnName("ERROR_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OldEchoToken)
                .HasColumnName("OLD_ECHO_TOKEN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResendYn)
                .HasColumnName("RESEND_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SubCode)
                .HasColumnName("SUB_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
