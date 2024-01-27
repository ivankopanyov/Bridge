namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CancellationHistoryView
{
    public string CancelNo { get; set; }
    public decimal ResvNameId { get; set; }
    public string Resort { get; set; }
    public string CancelCode { get; set; }
    public string CancelReason { get; set; }
    public decimal? UserId { get; set; }
    public string UserName { get; set; }
    public DateTime? CancelDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CancellationHistoryView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CANCELLATION_HISTORY_VIEW");

            entity.Property(e => e.CancelCode)
                .HasColumnName("CANCEL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CancelDate)
                .HasColumnName("CANCEL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelNo)
                .HasColumnName("CANCEL_NO")
                .IsUnicode(false);

            entity.Property(e => e.CancelReason)
                .HasColumnName("CANCEL_REASON")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserName)
                .HasColumnName("USER_NAME")
                .IsUnicode(false);
        });
	}
}
