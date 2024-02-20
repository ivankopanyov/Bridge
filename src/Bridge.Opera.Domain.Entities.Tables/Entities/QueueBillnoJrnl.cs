namespace Bridge.Opera.Domain.Entities.Tables;

public partial class QueueBillnoJrnl
{
    public string? QueueName { get; set; }
    public string? PrinterName { get; set; }
    public decimal? LastStartBillno { get; set; }
    public decimal? LastGeneratedBillno { get; set; }
    public string? NewBillno { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<QueueBillnoJrnl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("QUEUE_BILLNO_JRNL");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastGeneratedBillno)
                .HasColumnName("LAST_GENERATED_BILLNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastStartBillno)
                .HasColumnName("LAST_START_BILLNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewBillno)
                .HasColumnName("NEW_BILLNO")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.PrinterName)
                .IsRequired()
                .HasColumnName("PRINTER_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.QueueName)
                .IsRequired()
                .HasColumnName("QUEUE_NAME")
                .HasMaxLength(2000)
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
