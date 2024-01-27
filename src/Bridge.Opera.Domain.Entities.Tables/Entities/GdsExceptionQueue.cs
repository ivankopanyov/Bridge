namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsExceptionQueue
{
    public decimal ExceptionId { get; set; }
    public string ExceptionReason { get; set; }
    public string ActualValue { get; set; }
    public string RealValue { get; set; }
    public string GdsTransactionNo { get; set; }
    public string Status { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string Resort { get; set; }
    public string GdsSource { get; set; }
    public string GdsRecordLocator { get; set; }
    public string DetailDescription { get; set; }
    public string GdsMessageNo { get; set; }
    public string BookNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsExceptionQueue>(entity =>
        {
            entity.HasKey(e => e.ExceptionId)
                .HasName("GDS_EXCEPTION_QUEUE_PK");

            entity.ToTable("GDS_EXCEPTION_QUEUE");

            entity.HasIndex(e => e.Resort)
                .HasName("GDS_EXCEPTION_QUEUE_IND1");

            entity.Property(e => e.ExceptionId)
                .HasColumnName("EXCEPTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActualValue)
                .IsRequired()
                .HasColumnName("ACTUAL_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookNo)
                .HasColumnName("BOOK_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DetailDescription)
                .HasColumnName("DETAIL_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExceptionReason)
                .IsRequired()
                .HasColumnName("EXCEPTION_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsMessageNo)
                .HasColumnName("GDS_MESSAGE_NO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GdsRecordLocator)
                .HasColumnName("GDS_RECORD_LOCATOR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GdsSource)
                .HasColumnName("GDS_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsTransactionNo)
                .IsRequired()
                .HasColumnName("GDS_TRANSACTION_NO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RealValue)
                .IsRequired()
                .HasColumnName("REAL_VALUE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
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
