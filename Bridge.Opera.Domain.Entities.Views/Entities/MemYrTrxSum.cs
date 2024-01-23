namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MemYrTrxSum
{
    public decimal MembershipId { get; set; }
    public string Year { get; set; }
    public decimal? TotalNights { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalStays { get; set; }
    public decimal? TotalTrx { get; set; }
    public decimal? TotalSpend { get; set; }
    public decimal? TotalCover { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MemYrTrxSum>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEM_YR_TRX_SUM");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCover)
                .HasColumnName("TOTAL_COVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNights)
                .HasColumnName("TOTAL_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalSpend)
                .HasColumnName("TOTAL_SPEND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStays)
                .HasColumnName("TOTAL_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalTrx)
                .HasColumnName("TOTAL_TRX")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasMaxLength(4)
                .IsUnicode(false);
        });
	}
}
