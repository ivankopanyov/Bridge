namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DeferredPackageTaxes
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? FromResvId { get; set; }
    public decimal? ParentTrxNo { get; set; }
    public decimal? BillPaymentTrxNo { get; set; }
    public decimal? FolioView { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? TrxNoAgainstPackage { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DeferredPackageTaxes>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DEFERRED_PACKAGE_TAXES");

            entity.HasIndex(e => e.ParentTrxNo)
                .HasName("DPTAX_PARENT_TRX_UIDX")
                .IsUnique();

            entity.HasIndex(e => e.ResvNameId)
                .HasName("DPTAX_RESV_IDX");

            entity.HasIndex(e => e.TrxNoAgainstPackage)
                .HasName("DPTAX_TRX_PKG_IDX");

            entity.Property(e => e.BillPaymentTrxNo)
                .HasColumnName("BILL_PAYMENT_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromResvId)
                .HasColumnName("FROM_RESV_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ParentTrxNo)
                .HasColumnName("PARENT_TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxNoAgainstPackage)
                .HasColumnName("TRX_NO_AGAINST_PACKAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
