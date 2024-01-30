namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PaymentApplication
{
    public decimal? PaymentApplicationId { get; set; }
    public decimal? ConsumptionTrx { get; set; }
    public decimal? PaymentTrx { get; set; }
    public decimal? AppliedAmt { get; set; }
    public DateTime? AppliedDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? CashierId { get; set; }

    public virtual FinancialTransactions ConsumptionTrxNavigation { get; set; }
    public virtual FinancialTransactions PaymentTrxNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PaymentApplication>(entity =>
        {
            entity.ToTable("PAYMENT_APPLICATION");

            entity.HasIndex(e => e.AppliedDate)
                .HasName("PAY_APPLYDATE_IDX");

            entity.HasIndex(e => e.PaymentTrx)
                .HasName("PAY_TRX_NO");

            entity.HasIndex(e => new { e.ConsumptionTrx, e.PaymentTrx })
                .HasName("PAY_TRX_I");

            entity.Property(e => e.PaymentApplicationId)
                .HasColumnName("PAYMENT_APPLICATION_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppliedAmt)
                .HasColumnName("APPLIED_AMT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AppliedDate)
                .HasColumnName("APPLIED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CashierId)
                .HasColumnName("CASHIER_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsumptionTrx)
                .HasColumnName("CONSUMPTION_TRX")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentTrx)
                .HasColumnName("PAYMENT_TRX")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(FinancialTransactions)))
				entity.Ignore(e => e.ConsumptionTrxNavigation);
			else
	            entity.HasOne(d => d.ConsumptionTrxNavigation)
	                .WithMany(p => p.PaymentApplicationConsumptionTrxNavigation)
	                .HasForeignKey(d => d.ConsumptionTrx)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("CON_FINTRX_FK");

			if (!types.Contains(typeof(FinancialTransactions)))
				entity.Ignore(e => e.PaymentTrxNavigation);
			else
	            entity.HasOne(d => d.PaymentTrxNavigation)
	                .WithMany(p => p.PaymentApplicationPaymentTrxNavigation)
	                .HasForeignKey(d => d.PaymentTrx)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PAY_FINTRX_FK");
        });
	}
}
