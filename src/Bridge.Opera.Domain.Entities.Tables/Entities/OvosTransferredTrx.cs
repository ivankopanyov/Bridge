namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosTransferredTrx
{
    public string Resort { get; set; }
    public decimal TrxNo { get; set; }
    public decimal TransferCount { get; set; }
    public decimal AccountCode { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosTransferredTrx>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TrxNo, e.TransferCount })
                .HasName("OTT_PK");

            entity.ToTable("OVOS_TRANSFERRED_TRX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransferCount)
                .HasColumnName("TRANSFER_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");
        });
	}
}
