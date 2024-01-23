namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReqForPublItems
{
    public decimal RfpiRfpId { get; set; }
    public decimal RfpiNo { get; set; }
    public string RfpiPCode { get; set; }
    public decimal? RfpiQty { get; set; }
    public decimal? RfpiItemTba { get; set; }
    public decimal? RfpId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReqForPublItems>(entity =>
        {
            entity.HasKey(e => e.RfpiRfpId)
                .HasName("REQ_FOR_PUBL_ITEMS_PK");

            entity.ToTable("REQ_FOR_PUBL_ITEMS");

            entity.Property(e => e.RfpiRfpId)
                .HasColumnName("RFPI_RFP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RfpId)
                .HasColumnName("RFP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RfpiItemTba)
                .HasColumnName("RFPI_ITEM_TBA")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RfpiNo)
                .HasColumnName("RFPI_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RfpiPCode)
                .IsRequired()
                .HasColumnName("RFPI_P_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RfpiQty)
                .HasColumnName("RFPI_QTY")
                .HasColumnType("NUMBER");
        });
	}
}
