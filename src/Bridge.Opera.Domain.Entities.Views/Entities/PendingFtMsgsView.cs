namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PendingFtMsgsView
{
    public string? Resort { get; set; }
    public decimal? MessageId { get; set; }
    public decimal? TrxNo { get; set; }
    public string? ApprovalCode { get; set; }
    public string? ApprovalStatus { get; set; }
    public string? MessageText { get; set; }
    public string? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PendingFtMsgsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PENDING_FT_MSGS_VIEW");

            entity.Property(e => e.ApprovalCode)
                .HasColumnName("APPROVAL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ApprovalStatus)
                .HasColumnName("APPROVAL_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.MessageId)
                .HasColumnName("MESSAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MessageText)
                .HasColumnName("MESSAGE_TEXT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
