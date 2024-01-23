namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CcTransactionLog1
{
    public decimal SeqNo { get; set; }
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal NameId { get; set; }
    public decimal? ArNumber { get; set; }
    public DateTime TrxDate { get; set; }
    public decimal? CreditCardId { get; set; }
    public string AuthSettle { get; set; }
    public string CcAction { get; set; }
    public string CalledFrom { get; set; }
    public string IfcReturnStatus { get; set; }
    public string OperaProcessedYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertTs { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateTs { get; set; }
    public string PaymentMethod { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CcTransactionLog1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CC_TRANSACTION_LOG");

            entity.Property(e => e.ArNumber)
                .HasColumnName("AR_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthSettle)
                .HasColumnName("AUTH_SETTLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalledFrom)
                .HasColumnName("CALLED_FROM")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.CcAction)
                .HasColumnName("CC_ACTION")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IfcReturnStatus)
                .HasColumnName("IFC_RETURN_STATUS")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.InsertTs)
                .HasColumnName("INSERT_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaProcessedYn)
                .HasColumnName("OPERA_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateTs)
                .HasColumnName("UPDATE_TS")
                .HasColumnType("TIMESTAMP(6)");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
