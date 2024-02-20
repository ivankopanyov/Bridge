namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsGraphOversell
{
    public decimal? Id { get; set; }
    public string? SeriesCode { get; set; }
    public DateTime? OversellDate { get; set; }
    public decimal? Rooms { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsGraphOversell>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_GRAPH_OVERSELL");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OversellDate)
                .HasColumnName("OVERSELL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Rooms)
                .HasColumnName("ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeriesCode)
                .HasColumnName("SERIES_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
