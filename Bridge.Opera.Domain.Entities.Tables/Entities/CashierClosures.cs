namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CashierClosures
{
    public string Resort { get; set; }
    public decimal CashierId { get; set; }
    public decimal ClosureNo { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? OpenDate { get; set; }
    public DateTime? CloseDate { get; set; }
    public decimal? FromTranActionId { get; set; }
    public decimal? ToTranActionId { get; set; }
    public decimal? ClosedBy { get; set; }
    public decimal? Reprints { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? TotalCashReceived { get; set; }
    public decimal? TotalCheckReceived { get; set; }
    public decimal? TotalPaidouts { get; set; }
    public decimal? ActualCashDrop { get; set; }
    public decimal? ActualCheckDrop { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CashierClosures>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.CashierId, e.ClosureNo })
                .HasName("CASHIER_CLOSE_PK");

            entity.ToTable("CASHIER$_CLOSURES");

            entity.HasIndex(e => new { e.CashierId, e.BusinessDate })
                .HasName("CASHIER_CLOSE_ID_BUSDATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate, e.ClosureNo })
                .HasName("CASHIER_CLOSE_BUSDATE_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ClosureNo)
                .HasColumnName("CLOSURE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCashDrop)
                .HasColumnName("ACTUAL_CASH_DROP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualCheckDrop)
                .HasColumnName("ACTUAL_CHECK_DROP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CloseDate)
                .HasColumnName("CLOSE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ClosedBy)
                .HasColumnName("CLOSED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromTranActionId)
                .HasColumnName("FROM_TRAN_ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpenDate)
                .HasColumnName("OPEN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Reprints)
                .HasColumnName("REPRINTS")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
