namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemMenuitemClass1
{
    public decimal MicId { get; set; }
    public string MicName { get; set; }
    public string BeverageClass { get; set; }
    public string Resort { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string WebBookingYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuitemClass1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_MENUITEM_CLASS");

            entity.Property(e => e.BeverageClass)
                .HasColumnName("BEVERAGE_CLASS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MicId)
                .HasColumnName("MIC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MicName)
                .HasColumnName("MIC_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
