namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class FinTranPkgCode
{
    public string? PkgTrxCode { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranPkgCode>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FIN_TRAN_PKG_CODE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PkgTrxCode)
                .HasColumnName("PKG_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
