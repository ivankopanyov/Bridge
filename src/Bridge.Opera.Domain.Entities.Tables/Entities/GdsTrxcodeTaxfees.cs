namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsTrxcodeTaxfees
{
    public string? Resort { get; set; }
    public string? TrxCode { get; set; }
    public string? GdsTaxfeeCode { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ChargeType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsTrxcodeTaxfees>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TrxCode })
                .HasName("GDS_TRXCODE_TAXFEES_PK");

            entity.ToTable("GDS_TRXCODE_TAXFEES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChargeType)
                .HasColumnName("CHARGE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GdsTaxfeeCode)
                .IsRequired()
                .HasColumnName("GDS_TAXFEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
