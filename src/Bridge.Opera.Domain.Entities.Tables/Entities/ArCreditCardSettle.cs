namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ArCreditCardSettle
{
    public string? Resort { get; set; }
    public decimal? TrxNo { get; set; }
    public decimal? InvoiceNo { get; set; }

    public virtual FinancialTransactions TrxNoNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ArCreditCardSettle>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AR_CREDIT_CARD_SETTLE");

            entity.HasIndex(e => e.TrxNo)
                .HasName("AR_CREDIT_TRX_NO_IND");

            entity.HasIndex(e => new { e.Resort, e.InvoiceNo })
                .HasName("INVOICE_NO_IND");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(FinancialTransactions)))
				entity.Ignore(e => e.TrxNoNavigation);
			else
	            entity.HasOne(d => d.TrxNoNavigation)
	                .WithMany()
	                .HasForeignKey(d => d.TrxNo)
	                .HasConstraintName("ACCS_FINT_FK2");
        });
	}
}
