namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortPrintQueues
{
    public string Resort { get; set; }
    public string QueueName { get; set; }
    public decimal? BillNumber { get; set; }
    public decimal? IncrementValue { get; set; }
    public string PaymentType { get; set; }
    public string InactiveYn { get; set; }
    public string KeyValue { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortPrintQueues>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_PRINT_QUEUES");

            entity.Property(e => e.BillNumber)
                .HasColumnName("BILL_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IncrementValue)
                .HasColumnName("INCREMENT_VALUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.KeyValue)
                .IsRequired()
                .HasColumnName("KEY_VALUE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.QueueName)
                .HasColumnName("QUEUE_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
