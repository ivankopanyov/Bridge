namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BillingSummaryView
{
    public decimal? ResvNameId { get; set; }
    public string ArrangeTrxCode { get; set; }
    public decimal? Amount { get; set; }
    public string GuestCompFlag { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BillingSummaryView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BILLING_SUMMARY_VIEW");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrangeTrxCode)
                .HasColumnName("ARRANGE_TRX_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GuestCompFlag)
                .HasColumnName("GUEST_COMP_FLAG")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
