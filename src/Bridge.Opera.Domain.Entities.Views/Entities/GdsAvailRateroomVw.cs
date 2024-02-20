namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsAvailRateroomVw
{
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? RoomCategory { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public string? RateDescription { get; set; }
    public decimal? Lengthofstay { get; set; }
    public string? RateFrequency { get; set; }
    public string? Ratecurrencycode { get; set; }
    public string? CommissionCode { get; set; }
    public string? CommissionYn { get; set; }
    public string? TransactionCode { get; set; }
    public string? RateCategory { get; set; }
    public string? TrxTaxYn { get; set; }
    public DateTime? BeginBookingDate { get; set; }
    public DateTime? EndBookingDate { get; set; }
    public decimal? Maxoccupancy { get; set; }
    public string? RoomDescription { get; set; }
    public decimal? AdultCharge { get; set; }
    public decimal? ChildrenCharge { get; set; }
    public decimal? PackageRateStayOver { get; set; }
    public decimal? PackageChildrenStayOver { get; set; }
    public decimal? PackageAdultStayOver { get; set; }
    public decimal? Amount1 { get; set; }
    public decimal? Amount2 { get; set; }
    public decimal? Amount3 { get; set; }
    public decimal? Amount4 { get; set; }
    public decimal? Amount5 { get; set; }
    public decimal? ChildCharge1 { get; set; }
    public decimal? ChildCharge2 { get; set; }
    public decimal? ChildCharge3 { get; set; }
    public decimal? ChildOwnCharge1 { get; set; }
    public decimal? ChildOwnCharge2 { get; set; }
    public decimal? ChildOwnCharge3 { get; set; }
    public decimal? ChildOwnCharge4 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAvailRateroomVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_AVAIL_RATEROOM_VW");

            entity.Property(e => e.AdultCharge)
                .HasColumnName("ADULT_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount1)
                .HasColumnName("AMOUNT_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount2)
                .HasColumnName("AMOUNT_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount3)
                .HasColumnName("AMOUNT_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount4)
                .HasColumnName("AMOUNT_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Amount5)
                .HasColumnName("AMOUNT_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginBookingDate)
                .HasColumnName("BEGIN_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChildCharge1)
                .HasColumnName("CHILD_CHARGE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge2)
                .HasColumnName("CHILD_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildCharge3)
                .HasColumnName("CHILD_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge1)
                .HasColumnName("CHILD_OWN_CHARGE_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge2)
                .HasColumnName("CHILD_OWN_CHARGE_2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge3)
                .HasColumnName("CHILD_OWN_CHARGE_3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildOwnCharge4)
                .HasColumnName("CHILD_OWN_CHARGE_4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenCharge)
                .HasColumnName("CHILDREN_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CommissionCode)
                .HasColumnName("COMMISSION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommissionYn)
                .HasColumnName("COMMISSION_YN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndBookingDate)
                .HasColumnName("END_BOOKING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Lengthofstay)
                .HasColumnName("LENGTHOFSTAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Maxoccupancy)
                .HasColumnName("MAXOCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageAdultStayOver)
                .HasColumnName("PACKAGE_ADULT_STAY_OVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageChildrenStayOver)
                .HasColumnName("PACKAGE_CHILDREN_STAY_OVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PackageRateStayOver)
                .HasColumnName("PACKAGE_RATE_STAY_OVER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .IsRequired()
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateDescription)
                .HasColumnName("RATE_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateFrequency)
                .HasColumnName("RATE_FREQUENCY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Ratecurrencycode)
                .HasColumnName("RATECURRENCYCODE")
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

            entity.Property(e => e.RoomDescription)
                .HasColumnName("ROOM_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TransactionCode)
                .HasColumnName("TRANSACTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxTaxYn)
                .HasColumnName("TRX_TAX_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
