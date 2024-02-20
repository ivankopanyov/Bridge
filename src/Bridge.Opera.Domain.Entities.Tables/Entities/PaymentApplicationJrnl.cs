namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PaymentApplicationJrnl
{
    public decimal? PaymentApplicationId { get; set; }
    public decimal? ConsumptionTrx { get; set; }
    public decimal? PaymentTrx { get; set; }
    public decimal? AppliedAmt { get; set; }
    public DateTime? AppliedDate { get; set; }
    public string? JrnlOperation { get; set; }
    public DateTime? JrnlTime { get; set; }
    public string? JrnlDesc { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? CashierId { get; set; }
    public decimal? LastUnappliedCashier { get; set; }
    public decimal? LastUnappliedUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PaymentApplicationJrnl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PAYMENT_APPLICATION_JRNL");

            entity.HasIndex(e => e.JrnlTime)
                .HasName("PAY_JRNLTIME_IDX");

            entity.HasIndex(e => e.PaymentTrx)
                .HasName("PAY_JRNL_PAYTRX_IDX");

            entity.HasIndex(e => new { e.ConsumptionTrx, e.PaymentTrx })
                .HasName("PAY_JRNL_TRX_IDX");

            entity.Property(e => e.AppliedAmt)
                .HasColumnName("APPLIED_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AppliedDate)
                .HasColumnName("APPLIED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConsumptionTrx)
                .HasColumnName("CONSUMPTION_TRX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JrnlDesc)
                .HasColumnName("JRNL_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.JrnlOperation)
                .HasColumnName("JRNL_OPERATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.JrnlTime)
                .HasColumnName("JRNL_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.LastUnappliedCashier)
                .HasColumnName("LAST_UNAPPLIED_CASHIER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastUnappliedUser)
                .HasColumnName("LAST_UNAPPLIED_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentApplicationId)
                .HasColumnName("PAYMENT_APPLICATION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentTrx)
                .HasColumnName("PAYMENT_TRX")
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
