namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateDailyStatus1
{
    public decimal? UpdateRateSetId { get; set; }
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RateClass { get; set; }
    public string? RateCategory { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public DateTime? RateBeginDate { get; set; }
    public string? SeasonCode { get; set; }
    public decimal? AdultCharge { get; set; }
    public decimal? ChildrenCharge { get; set; }
    public decimal? ChildCharge1 { get; set; }
    public decimal? ChildCharge2 { get; set; }
    public decimal? ChildCharge3 { get; set; }
    public decimal? PackageRateStayOver { get; set; }
    public decimal? PackageChildrenStayOver { get; set; }
    public decimal? PackageAdultStayOver { get; set; }
    public string? CurrencyCode { get; set; }
    public string? MarketCode { get; set; }
    public string? SourceCode { get; set; }
    public string? SMinlos { get; set; }
    public string? SMaxlos { get; set; }
    public string? BookMinAdvance { get; set; }
    public string? SStatus { get; set; }
    public string? AStatus { get; set; }
    public string? DStatus { get; set; }
    public string? BookMaxAdvance { get; set; }
    public string? AMinlos { get; set; }
    public string? AMaxlos { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateDailyStatus1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_DAILY_STATUS$");

            entity.Property(e => e.AMaxlos)
                .HasColumnName("A_MAXLOS")
                .IsUnicode(false);

            entity.Property(e => e.AMinlos)
                .HasColumnName("A_MINLOS")
                .IsUnicode(false);

            entity.Property(e => e.AStatus)
                .HasColumnName("A_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.AdultCharge)
                .HasColumnName("ADULT_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookMaxAdvance)
                .HasColumnName("BOOK_MAX_ADVANCE")
                .IsUnicode(false);

            entity.Property(e => e.BookMinAdvance)
                .HasColumnName("BOOK_MIN_ADVANCE")
                .IsUnicode(false);

            entity.Property(e => e.ChildCharge1)
                .HasColumnName("CHILD_CHARGE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge2)
                .HasColumnName("CHILD_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge3)
                .HasColumnName("CHILD_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenCharge)
                .HasColumnName("CHILDREN_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DStatus)
                .HasColumnName("D_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PackageAdultStayOver)
                .HasColumnName("PACKAGE_ADULT_STAY_OVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageChildrenStayOver)
                .HasColumnName("PACKAGE_CHILDREN_STAY_OVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRateStayOver)
                .HasColumnName("PACKAGE_RATE_STAY_OVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateBeginDate)
                .HasColumnName("RATE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateCategory)
                .IsRequired()
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateClass)
                .IsRequired()
                .HasColumnName("RATE_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SMaxlos)
                .HasColumnName("S_MAXLOS")
                .IsUnicode(false);

            entity.Property(e => e.SMinlos)
                .HasColumnName("S_MINLOS")
                .IsUnicode(false);

            entity.Property(e => e.SStatus)
                .HasColumnName("S_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.SeasonCode)
                .HasColumnName("SEASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateRateSetId)
                .HasColumnName("UPDATE_RATE_SET_ID")
                .HasColumnType("NUMBER");
        });
	}
}
