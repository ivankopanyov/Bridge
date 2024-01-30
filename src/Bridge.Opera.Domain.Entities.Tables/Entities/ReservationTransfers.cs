namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationTransfers
{
    public string? TransferFromResort { get; set; }
    public decimal? TransferFromResvNameId { get; set; }
    public string? TransferToResort { get; set; }
    public decimal? TransferToResvNameId { get; set; }
    public string? TransferReasonCode { get; set; }
    public DateTime? TransferBusinessDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationTransfers>(entity =>
        {
            entity.HasKey(e => new { e.TransferFromResort, e.TransferFromResvNameId, e.TransferToResort, e.TransferToResvNameId })
                .HasName("RESVTRANS_PK");

            entity.ToTable("RESERVATION_TRANSFERS");

            entity.HasIndex(e => new { e.TransferToResort, e.TransferToResvNameId })
                .HasName("RESVTRANS_TO_RESORT_IDX");

            entity.Property(e => e.TransferFromResort)
                .HasColumnName("TRANSFER_FROM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TransferFromResvNameId)
                .HasColumnName("TRANSFER_FROM_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransferToResort)
                .HasColumnName("TRANSFER_TO_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TransferToResvNameId)
                .HasColumnName("TRANSFER_TO_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransferBusinessDate)
                .HasColumnName("TRANSFER_BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TransferReasonCode)
                .IsRequired()
                .HasColumnName("TRANSFER_REASON_CODE")
                .HasMaxLength(40)
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
