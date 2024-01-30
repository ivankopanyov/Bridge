namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofStatistics
{
    public string? Resort { get; set; }
    public string? Code { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Description { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? GrossAmount { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? SingleOccRoom { get; set; }
    public decimal? MultiOccRoom { get; set; }
    public decimal? RoomAvail { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_STATISTICS");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GrossAmount)
                .HasColumnName("GROSS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MultiOccRoom)
                .HasColumnName("MULTI_OCC_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NetAmount)
                .HasColumnName("NET_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomAvail)
                .HasColumnName("ROOM_AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SingleOccRoom)
                .HasColumnName("SINGLE_OCC_ROOM")
                .HasColumnType("NUMBER");
        });
	}
}
