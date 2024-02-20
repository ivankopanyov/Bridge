namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsTrxcodeTaxfeesView
{
    public string? Resort { get; set; }
    public string? TrxCode { get; set; }
    public string? OperaTrxDescription { get; set; }
    public string? GdsTaxfeeCode { get; set; }
    public string? ChargeType { get; set; }
    public string? GdsTrxDescription { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsTrxcodeTaxfeesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_TRXCODE_TAXFEES_VIEW");

            entity.Property(e => e.ChargeType)
                .HasColumnName("CHARGE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GdsTaxfeeCode)
                .IsRequired()
                .HasColumnName("GDS_TAXFEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsTrxDescription)
                .HasColumnName("GDS_TRX_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaTrxDescription)
                .HasColumnName("OPERA_TRX_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxCode)
                .IsRequired()
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
