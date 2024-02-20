namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmBookedActBaseVw
{
    public decimal? BookedActId { get; set; }
    public DateTime? BeginTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? NameId { get; set; }
    public string? GuestName { get; set; }
    public string? ActCode { get; set; }
    public string? PriceCode { get; set; }
    public decimal? Price { get; set; }
    public decimal? TrxNo { get; set; }
    public string? Status { get; set; }
    public string? OutletCode { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? NoOfPeople { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookedActBaseVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_BOOKED_ACT_BASE_VW");

            entity.Property(e => e.ActCode)
                .IsRequired()
                .HasColumnName("ACT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginTime)
                .HasColumnName("BEGIN_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedActId)
                .HasColumnName("BOOKED_ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndTime)
                .HasColumnName("END_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfPeople)
                .HasColumnName("NO_OF_PEOPLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriceCode)
                .HasColumnName("PRICE_CODE")
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

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
