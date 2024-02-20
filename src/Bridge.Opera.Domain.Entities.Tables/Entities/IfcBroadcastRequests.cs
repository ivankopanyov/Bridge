namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcBroadcastRequests
{
    public string? Resort { get; set; }
    public string? RequestId { get; set; }
    public decimal? IfcCtrlId { get; set; }
    public string? RequestAction { get; set; }
    public string? Username { get; set; }
    public decimal? SessionId { get; set; }
    public DateTime? ExpiryTime { get; set; }
    public string? RequestInfo { get; set; }
    public string? TimeoutYn { get; set; }
    public string? Wsnum { get; set; }
    public string? Keycoder { get; set; }
    public string? Guestnum { get; set; }
    public string? Roomnum { get; set; }
    public string? Sequencenum { get; set; }
    public string? Parameters { get; set; }
    public string? ReceiptInfo { get; set; }
    public decimal? KeyNumber { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcBroadcastRequests>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RequestId })
                .HasName("IFCBCREQ_PK");

            entity.ToTable("IFC_BROADCAST_REQUESTS");

            entity.HasIndex(e => new { e.Resort, e.ExpiryTime })
                .HasName("IFCBCREQ_RESEXP_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExpiryTime)
                .HasColumnName("EXPIRY_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Guestnum)
                .HasColumnName("GUESTNUM")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.IfcCtrlId)
                .HasColumnName("IFC_CTRL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyNumber)
                .HasColumnName("KEY_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Keycoder)
                .HasColumnName("KEYCODER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Parameters)
                .HasColumnName("PARAMETERS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ReceiptInfo)
                .HasColumnName("RECEIPT_INFO")
                .IsUnicode(false);

            entity.Property(e => e.RequestAction)
                .HasColumnName("REQUEST_ACTION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RequestInfo)
                .HasColumnName("REQUEST_INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Roomnum)
                .HasColumnName("ROOMNUM")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.Sequencenum)
                .HasColumnName("SEQUENCENUM")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TimeoutYn)
                .HasColumnName("TIMEOUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Username)
                .IsRequired()
                .HasColumnName("USERNAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Wsnum)
                .HasColumnName("WSNUM")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
