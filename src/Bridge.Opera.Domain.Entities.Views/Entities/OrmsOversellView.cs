namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsOversellView
{
    public string Resort { get; set; }
    public DateTime OversellDate { get; set; }
    public decimal? ActualCancel { get; set; }
    public decimal? ForeCancel { get; set; }
    public decimal? RemainingCancellation { get; set; }
    public decimal? Oversell { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsOversellView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_OVERSELL_VIEW");

            entity.Property(e => e.ActualCancel)
                .HasColumnName("ACTUAL_CANCEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForeCancel)
                .HasColumnName("FORE_CANCEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Oversell)
                .HasColumnName("OVERSELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OversellDate)
                .HasColumnName("OVERSELL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RemainingCancellation)
                .HasColumnName("REMAINING_CANCELLATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
