namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemItemcWithInactive
{
    public decimal? ItemclassId { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }
    public string? Resort { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? UsedInApp { get; set; }
    public string? DiscountableYn { get; set; }
    public string? ItemclassCode { get; set; }
    public string? WebBookingYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemcWithInactive>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_ITEMC_WITH_INACTIVE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.DiscountableYn)
                .HasColumnName("DISCOUNTABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ItemclassCode)
                .HasColumnName("ITEMCLASS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ItemclassId)
                .HasColumnName("ITEMCLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
