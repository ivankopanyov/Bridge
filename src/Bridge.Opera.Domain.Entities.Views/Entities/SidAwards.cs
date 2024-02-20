namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidAwards
{
    public decimal? AwardSeqId { get; set; }
    public string? Resort { get; set; }
    public string? AwardCode { get; set; }
    public string? Mpcode { get; set; }
    public string? AwardDesc { get; set; }
    public decimal? AwardQty { get; set; }
    public decimal? AwardMiles { get; set; }
    public string? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? NumberRequiredType { get; set; }
    public string? DefaultYn { get; set; }
    public string? HotelCategory { get; set; }
    public string? IsGift { get; set; }
    public string? IsPackage { get; set; }
    public string? IsUpgrade { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidAwards>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_AWARDS");

            entity.Property(e => e.AwardCode)
                .IsRequired()
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardDesc)
                .HasColumnName("AWARD_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AwardMiles)
                .HasColumnName("AWARD_MILES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardQty)
                .HasColumnName("AWARD_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardSeqId)
                .HasColumnName("AWARD_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasMaxLength(33)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.HotelCategory)
                .HasColumnName("HOTEL_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.IsGift)
                .HasColumnName("IS_GIFT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IsPackage)
                .HasColumnName("IS_PACKAGE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IsUpgrade)
                .HasColumnName("IS_UPGRADE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Mpcode)
                .HasColumnName("MPCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NumberRequiredType)
                .HasColumnName("NUMBER_REQUIRED_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
