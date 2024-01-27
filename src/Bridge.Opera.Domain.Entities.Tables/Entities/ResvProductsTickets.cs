namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResvProductsTickets
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal? ReservationProductId { get; set; }
    public string ProductId { get; set; }
    public string Description { get; set; }
    public string RateCode { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? Price { get; set; }
    public DateTime? ConsumptionDate { get; set; }
    public string PostingRhythm { get; set; }
    public string TicketNumber { get; set; }
    public DateTime? IssueDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvProductsTickets>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESV_PRODUCTS_TICKETS");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.ReservationProductId, e.ProductId })
                .HasName("RESV_PRODUCTS_TICKETS_IDX");

            entity.Property(e => e.ConsumptionDate)
                .HasColumnName("CONSUMPTION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssueDate)
                .HasColumnName("ISSUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProductId)
                .IsRequired()
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationProductId)
                .HasColumnName("RESERVATION_PRODUCT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TicketNumber)
                .HasColumnName("TICKET_NUMBER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany()
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .HasConstraintName("RESVPT_RESVN_FK");
        });
	}
}
