namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReservationBalance
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? Balance { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationBalance>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESERVATION_BALANCE");

            entity.Property(e => e.Balance)
                .HasColumnName("BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
