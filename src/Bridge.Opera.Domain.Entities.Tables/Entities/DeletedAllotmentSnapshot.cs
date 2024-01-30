namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DeletedAllotmentSnapshot
{
    public string? Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? AllotmentCode { get; set; }
    public string? SnapshotType { get; set; }
    public DateTime? AllotmentDate { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public DateTime? ExportDate { get; set; }
    public DateTime? BusinessDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? PaymentMethod { get; set; }
    public string? Bookingmethod { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? Udfc06 { get; set; }
    public string? RmsCurrency { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DeletedAllotmentSnapshot>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DELETED_ALLOTMENT_SNAPSHOT");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate })
                .HasName("DELAS_BUSINESS_DATE_IDX");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Bookingmethod)
                .HasColumnName("BOOKINGMETHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportDate)
                .HasColumnName("EXPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsCurrency)
                .HasColumnName("RMS_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SnapshotType)
                .HasColumnName("SNAPSHOT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);
        });
	}
}
