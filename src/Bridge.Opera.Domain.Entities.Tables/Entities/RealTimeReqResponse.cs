namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RealTimeReqResponse
{
    public decimal? RequestId { get; set; }
    public string? Resort { get; set; }
    public string? InterfaceId { get; set; }
    public string? Request { get; set; }
    public string? Response { get; set; }
    public DateTime? RequestDate { get; set; }
    public decimal? UserId { get; set; }
    public string? Status { get; set; }
    public string? DatabaseId { get; set; }
    public string? ServiceCode { get; set; }
    public string? WsUrl { get; set; }
    public string? WsFunction { get; set; }
    public string? ErrorMessage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RealTimeReqResponse>(entity =>
        {
            entity.HasKey(e => e.RequestId)
                .HasName("RTE_PK");

            entity.ToTable("REAL_TIME_REQ_RESPONSE");

            entity.HasIndex(e => new { e.DatabaseId, e.ServiceCode })
                .HasName("REAL_TIME_REQ_IDX1");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMessage)
                .HasColumnName("ERROR_MESSAGE")
                .IsUnicode(false);

            entity.Property(e => e.InterfaceId)
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Request)
                .HasColumnName("REQUEST")
                .HasColumnType("CLOB");

            entity.Property(e => e.RequestDate)
                .HasColumnName("REQUEST_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Response)
                .HasColumnName("RESPONSE")
                .HasColumnType("CLOB");

            entity.Property(e => e.ServiceCode)
                .HasColumnName("SERVICE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WsFunction)
                .HasColumnName("WS_FUNCTION")
                .IsUnicode(false);

            entity.Property(e => e.WsUrl)
                .HasColumnName("WS_URL")
                .IsUnicode(false);
        });
	}
}
