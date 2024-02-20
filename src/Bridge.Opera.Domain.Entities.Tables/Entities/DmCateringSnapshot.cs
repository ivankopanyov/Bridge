namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DmCateringSnapshot
{
    public string? Resort { get; set; }
    public decimal? BookId { get; set; }
    public DateTime? StatusChangeDate { get; set; }
    public string? CurrentCatStatus { get; set; }
    public string? PriorCatStatus { get; set; }
    public string? RevenueType { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? Attendees { get; set; }
    public string? PkgRevenueYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? DmProcessed { get; set; }
    public string? DmProcessedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DmCateringSnapshot>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.BookId, e.StatusChangeDate, e.CurrentCatStatus, e.RevenueType, e.PkgRevenueYn })
                .HasName("DM_CATSNAP_PK");

            entity.ToTable("DM_CATERING_SNAPSHOT");

            entity.HasIndex(e => new { e.DmProcessedYn, e.Resort, e.InsertDate })
                .HasName("DM_CATSNAP_PROCESSED_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatusChangeDate)
                .HasColumnName("STATUS_CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrentCatStatus)
                .HasColumnName("CURRENT_CAT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType)
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PkgRevenueYn)
                .HasColumnName("PKG_REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DmProcessed)
                .HasColumnName("DM_PROCESSED")
                .HasColumnType("DATE");

            entity.Property(e => e.DmProcessedYn)
                .HasColumnName("DM_PROCESSED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PriorCatStatus)
                .HasColumnName("PRIOR_CAT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
