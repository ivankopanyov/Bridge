namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CashierClosures1
{
    public string? Resort { get; set; }
    public decimal? CashierId { get; set; }
    public string? Title { get; set; }
    public decimal? ClosureNo { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? OpenDate { get; set; }
    public string? CloseDate { get; set; }
    public decimal? FromTranActionId { get; set; }
    public decimal? ToTranActionId { get; set; }
    public decimal? ClosedBy { get; set; }
    public decimal? Reprints { get; set; }
    public string? AppUser { get; set; }
    public decimal? TotalCashReceived { get; set; }
    public decimal? TotalPaidouts { get; set; }
    public decimal? TotalCheckReceived { get; set; }
    public decimal? ActualCashDrop { get; set; }
    public decimal? ActualCheckDrop { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CashierClosures1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CASHIER_CLOSURES");

            entity.Property(e => e.ActualCashDrop)
                .HasColumnName("ACTUAL_CASH_DROP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCheckDrop)
                .HasColumnName("ACTUAL_CHECK_DROP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppUser)
                .IsRequired()
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CloseDate)
                .HasColumnName("CLOSE_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ClosedBy)
                .HasColumnName("CLOSED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromTranActionId)
                .HasColumnName("FROM_TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenDate)
                .HasColumnName("OPEN_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Reprints)
                .HasColumnName("REPRINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ToTranActionId)
                .HasColumnName("TO_TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCashReceived)
                .HasColumnName("TOTAL_CASH_RECEIVED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCheckReceived)
                .HasColumnName("TOTAL_CHECK_RECEIVED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPaidouts)
                .HasColumnName("TOTAL_PAIDOUTS")
                .HasColumnType("NUMBER");
        });
	}
}
