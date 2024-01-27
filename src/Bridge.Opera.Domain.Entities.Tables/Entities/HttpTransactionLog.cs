namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HttpTransactionLog
{
    public decimal Id { get; set; }
    public string InputMsg { get; set; }
    public DateTime RequestDt { get; set; }
    public DateTime? ResponseDt { get; set; }
    public string Request { get; set; }
    public string Response { get; set; }
    public string SessionInfo { get; set; }
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HttpTransactionLog>(entity =>
        {
            entity.ToTable("HTTP_TRANSACTION_LOG");

            entity.HasIndex(e => new { e.Resort, e.RequestDt })
                .HasName("HTTP_TRANSACTION_LOG_IDX2");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("HTTP_TRANS_LOG_IDX");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InputMsg)
                .HasColumnName("INPUT_MSG")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Request)
                .HasColumnName("REQUEST")
                .IsUnicode(false);

            entity.Property(e => e.RequestDt)
                .HasColumnName("REQUEST_DT")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Response)
                .HasColumnName("RESPONSE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResponseDt)
                .HasColumnName("RESPONSE_DT")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SessionInfo)
                .HasColumnName("SESSION_INFO")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
