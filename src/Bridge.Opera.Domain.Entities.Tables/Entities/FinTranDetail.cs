namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FinTranDetail
{
    public decimal FinTranDetailId { get; set; }
    public string Resort { get; set; }
    public decimal TrxNo { get; set; }
    public string LanguageCode { get; set; }
    public string TrxDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FinTranDetail>(entity =>
        {
            entity.ToTable("FIN_TRAN_DETAIL");

            entity.HasIndex(e => e.LanguageCode)
                .HasName("FIN_TRAN_DTL_LANG_FK_I");

            entity.HasIndex(e => new { e.Resort, e.TrxNo, e.LanguageCode })
                .HasName("FTDT_TRX_IDX");

            entity.Property(e => e.FinTranDetailId)
                .HasColumnName("FIN_TRAN_DETAIL_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasColumnName("LANGUAGE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDescription)
                .IsRequired()
                .HasColumnName("TRX_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");
        });
	}
}
