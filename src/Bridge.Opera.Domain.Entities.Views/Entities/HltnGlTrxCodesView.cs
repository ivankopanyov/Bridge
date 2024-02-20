namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HltnGlTrxCodesView
{
    public string? ItemId { get; set; }
    public string? AllowDrillDownYn { get; set; }
    public string? TrxCode { get; set; }
    public string? AccountCode { get; set; }
    public string? CurrencyCode { get; set; }
    public string? StatCode { get; set; }
    public string? TrxDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HltnGlTrxCodesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HLTN_GL_TRX_CODES_VIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.AllowDrillDownYn)
                .HasColumnName("ALLOW_DRILL_DOWN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StatCode)
                .HasColumnName("STAT_CODE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TrxDescription)
                .HasColumnName("TRX_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
