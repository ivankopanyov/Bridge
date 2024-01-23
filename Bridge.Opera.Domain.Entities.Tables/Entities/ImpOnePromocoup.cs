namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ImpOnePromocoup
{
    public decimal BatchId { get; set; }
    public decimal SeqNo { get; set; }
    public DateTime? ImportDate { get; set; }
    public string ImportStatus { get; set; }
    public string ImportMsg { get; set; }
    public string CouponCode { get; set; }
    public string Resort { get; set; }
    public string PromotionCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ImpOnePromocoup>(entity =>
        {
            entity.HasKey(e => new { e.BatchId, e.SeqNo })
                .HasName("IOP_PK");

            entity.ToTable("IMP_ONE_PROMOCOUP");

            entity.HasIndex(e => new { e.ImportStatus, e.BatchId })
                .HasName("IMP_ONE_PRMCP_IDX1");

            entity.Property(e => e.BatchId)
                .HasColumnName("BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CouponCode)
                .HasColumnName("COUPON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ImportMsg)
                .HasColumnName("IMPORT_MSG")
                .IsUnicode(false);

            entity.Property(e => e.ImportStatus)
                .HasColumnName("IMPORT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
