namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpOvosFeeData
{
    public string? Room { get; set; }
    public string? TrxCode { get; set; }
    public decimal? Amount { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpOvosFeeData>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_OVOS_FEE_DATA");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
