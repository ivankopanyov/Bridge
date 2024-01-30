namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BookBilling
{
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public decimal? OrderBy { get; set; }
    public string? BillType { get; set; }
    public string? BillCode { get; set; }
    public string? RoutingCode { get; set; }
    public string? RoutingNbr { get; set; }
    public string? Comments { get; set; }
    public decimal? LaptopChange { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookBilling>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BookId, e.OrderBy })
                .HasName("BBILL_PK");

            entity.ToTable("BOOK$BILLING");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillCode)
                .HasColumnName("BILL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BillType)
                .HasColumnName("BILL_TYPE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingCode)
                .HasColumnName("ROUTING_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RoutingNbr)
                .HasColumnName("ROUTING_NBR")
                .HasMaxLength(100)
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
