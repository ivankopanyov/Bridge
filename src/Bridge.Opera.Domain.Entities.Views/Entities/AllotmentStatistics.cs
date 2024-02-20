namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AllotmentStatistics
{
    public string? Resort { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public decimal? DefiniteRooms { get; set; }
    public decimal? TentativeRooms { get; set; }
    public decimal? AvailableRooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AllotmentStatistics>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ALLOTMENT_STATISTICS");

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AvailableRooms)
                .HasColumnName("AVAILABLE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DefiniteRooms)
                .HasColumnName("DEFINITE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TentativeRooms)
                .HasColumnName("TENTATIVE_ROOMS")
                .HasColumnType("NUMBER");
        });
	}
}
