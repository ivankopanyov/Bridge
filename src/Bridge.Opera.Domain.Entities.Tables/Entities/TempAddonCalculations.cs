namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempAddonCalculations
{
    public string? Description { get; set; }
    public decimal? SessionId { get; set; }
    public decimal? Amount { get; set; }
    public string? TrxCode { get; set; }
    public string? Resort { get; set; }
    public string? InclTaxYn { get; set; }
    public string? PkgTrxYn { get; set; }
    public string? PkgTrxCode { get; set; }
    public string? PackageYn { get; set; }
    public string? PkgCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempAddonCalculations>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_ADDON_CALCULATIONS");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InclTaxYn)
                .HasColumnName("INCL_TAX_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PackageYn)
                .HasColumnName("PACKAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PkgCode)
                .HasColumnName("PKG_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgTrxCode)
                .HasColumnName("PKG_TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgTrxYn)
                .HasColumnName("PKG_TRX_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
