namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEdwTrx
{
    public decimal? ExportId { get; set; }
    public string? EdwType { get; set; }
    public string? PmsVersion { get; set; }
    public DateTime? ConsideredDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? PmsConfirmationNo { get; set; }
    public string? ExternalReferenceNo { get; set; }
    public DateTime? TrxDate { get; set; }
    public DateTime? CreationDate { get; set; }
    public string? BucketCode { get; set; }
    public string? RoomType { get; set; }
    public decimal? Quantity { get; set; }
    public string? RoomNo { get; set; }
    public decimal? Amount { get; set; }
    public string? CurrencyCode { get; set; }
    public string? OrigRateCode { get; set; }
    public string? LastRateCode { get; set; }
    public string? AwardNumber { get; set; }
    public string? AllotmentCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEdwTrx>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EDW_TRX");

            entity.Property(e => e.AllotmentCode)
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AwardNumber)
                .HasColumnName("AWARD_NUMBER")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BucketCode)
                .HasColumnName("BUCKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConsideredDate)
                .HasColumnName("CONSIDERED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreationDate)
                .HasColumnName("CREATION_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EdwType)
                .HasColumnName("EDW_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExternalReferenceNo)
                .HasColumnName("EXTERNAL_REFERENCE_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.LastRateCode)
                .HasColumnName("LAST_RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrigRateCode)
                .HasColumnName("ORIG_RATE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PmsConfirmationNo)
                .HasColumnName("PMS_CONFIRMATION_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PmsVersion)
                .HasColumnName("PMS_VERSION")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();
        });
	}
}
