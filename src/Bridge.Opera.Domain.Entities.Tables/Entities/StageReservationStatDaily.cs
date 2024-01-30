namespace Bridge.Opera.Domain.Entities.Tables;

public partial class StageReservationStatDaily
{
    public decimal? StageRecordId { get; set; }
    public string? InterfaceId { get; set; }
    public DateTime? ImportDate { get; set; }
    public string? StageStatus { get; set; }
    public string? StageSuspenseReason { get; set; }
    public string? Resort { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal? NameId { get; set; }
    public string? RateCode { get; set; }
    public string? SourceCode { get; set; }
    public string? MarketCode { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? AgentId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? SourceProfId { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? TruncBeginDate { get; set; }
    public DateTime? TruncEndDate { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? PhysicalQuantity { get; set; }
    public string? DueOutYn { get; set; }
    public string? RoomResvStatus { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? RoomAdults { get; set; }
    public decimal? RoomChildren { get; set; }
    public decimal? PrimaryYn { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FoodRevenue { get; set; }
    public decimal? PackageRoomRevenue { get; set; }
    public decimal? PackageFoodRevenue { get; set; }
    public decimal? TotalRoomTax { get; set; }
    public decimal? TotalFoodTax { get; set; }
    public decimal? TotalPackageRevenue { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? TotalTax { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? OriginalEndDate { get; set; }
    public string? WalkinYn { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? RoomClass { get; set; }
    public string? VipStatus { get; set; }
    public DateTime? CancellationDate { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Room { get; set; }
    public decimal? ContactId { get; set; }
    public string? RateCategory { get; set; }
    public string? MarketMainGroup { get; set; }
    public string? SourceMainGroup { get; set; }
    public string? Channel { get; set; }
    public string? Country { get; set; }
    public string? RegionCode { get; set; }
    public string? Nationality { get; set; }
    public string? PsuedoRoomYn { get; set; }
    public decimal? AdultsTaxFree { get; set; }
    public decimal? ChildrenTaxFree { get; set; }
    public decimal? StayRooms { get; set; }
    public decimal? StayPersons { get; set; }
    public decimal? StayAdults { get; set; }
    public decimal? StayChildren { get; set; }
    public decimal? ArrRooms { get; set; }
    public decimal? ArrPersons { get; set; }
    public decimal? DepRooms { get; set; }
    public decimal? DepPersons { get; set; }
    public decimal? DayUseRooms { get; set; }
    public decimal? DayUsePersons { get; set; }
    public decimal? CancelledRooms { get; set; }
    public decimal? CancelledPersons { get; set; }
    public decimal? NoShowRooms { get; set; }
    public decimal? NoShowPersons { get; set; }
    public decimal? SingleOccupancy { get; set; }
    public decimal? MultipleOccupancy { get; set; }
    public decimal? Cribs { get; set; }
    public decimal? ExtraBeds { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? PackageOtherRevenue { get; set; }
    public decimal? TotalOtherTax { get; set; }
    public string? CountryMainGroup { get; set; }
    public string? State { get; set; }
    public string? FiscalRegionCode { get; set; }
    public decimal? NonRevenue { get; set; }
    public decimal? PackageNonRevenue { get; set; }
    public decimal? TotalNonRevenueTax { get; set; }
    public decimal? PrRoomRevenue { get; set; }
    public decimal? PrFoodRevenue { get; set; }
    public decimal? PrPackageRoomRevenue { get; set; }
    public decimal? PrPackageFoodRevenue { get; set; }
    public decimal? PrTotalRoomTax { get; set; }
    public decimal? PrTotalFoodTax { get; set; }
    public decimal? PrTotalPackageRevenue { get; set; }
    public decimal? PrTotalRevenue { get; set; }
    public decimal? PrTotalTax { get; set; }
    public decimal? PrOtherRevenue { get; set; }
    public decimal? PrPackageOtherRevenue { get; set; }
    public decimal? PrTotalOtherTax { get; set; }
    public decimal? PrNonRevenue { get; set; }
    public decimal? PrPackageNonRevenue { get; set; }
    public decimal? PrTotalNonRevenueTax { get; set; }
    public decimal? Nights { get; set; }
    public decimal? NoOfStays { get; set; }
    public decimal? ReservationNights { get; set; }
    public decimal? ReservationArrivals { get; set; }
    public decimal? ReservationNoOfStays { get; set; }
    public decimal? DayUseReservations { get; set; }
    public decimal? CancelledReservations { get; set; }
    public decimal? NoShowReservations { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? District { get; set; }
    public decimal? CashRoomNts { get; set; }
    public decimal? CompRoomNts { get; set; }
    public decimal? CashRoomRevenue { get; set; }
    public decimal? CompRoomRevenue { get; set; }
    public string? PromotionCode { get; set; }
    public decimal? Children1 { get; set; }
    public decimal? Children2 { get; set; }
    public decimal? Children3 { get; set; }
    public decimal? Children4 { get; set; }
    public decimal? Children5 { get; set; }
    public string? FfMembershipNo { get; set; }
    public string? FfMembershipType { get; set; }
    public string? FgMembershipType { get; set; }
    public string? FgMembershipNo { get; set; }
    public string? BookedRoomCategory { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? ParentCompanyId { get; set; }
    public string? HouseUseYn { get; set; }
    public string? ComplimentaryYn { get; set; }
    public decimal? BiResvNameId { get; set; }
    public string? ContactYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<StageReservationStatDaily>(entity =>
        {
            entity.HasKey(e => e.StageRecordId)
                .HasName("STAGE_RES_STAT_DAILY_PK");

            entity.ToTable("STAGE_RESERVATION_STAT_DAILY");

            entity.HasIndex(e => new { e.ImportDate, e.Resort })
                .HasName("STAGE_RES_STAT_DAILY_IND1");

            entity.HasIndex(e => new { e.BiResvNameId, e.BusinessDate, e.Resort })
                .HasName("STAGE_RES_STAT_DAILY_BI");

            entity.HasIndex(e => new { e.BusinessDate, e.Resort, e.ImportDate })
                .HasName("STAGE_RES_STAT_DAILY_IND2");

            entity.HasIndex(e => new { e.ResvNameId, e.Resort, e.BusinessDate })
                .HasName("STAGE_RES_STAT_DAILY_IND3");

            entity.Property(e => e.StageRecordId)
                .HasColumnName("STAGE_RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdultsTaxFree)
                .HasColumnName("ADULTS_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentId)
                .HasColumnName("AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrPersons)
                .HasColumnName("ARR_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ArrRooms)
                .HasColumnName("ARR_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BiResvNameId)
                .HasColumnName("BI_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookedRoomCategory)
                .HasColumnName("BOOKED_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancelledPersons)
                .HasColumnName("CANCELLED_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledReservations)
                .HasColumnName("CANCELLED_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelledRooms)
                .HasColumnName("CANCELLED_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashRoomNts)
                .HasColumnName("CASH_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CashRoomRevenue)
                .HasColumnName("CASH_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children1)
                .HasColumnName("CHILDREN1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children2)
                .HasColumnName("CHILDREN2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children3)
                .HasColumnName("CHILDREN3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children4)
                .HasColumnName("CHILDREN4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Children5)
                .HasColumnName("CHILDREN5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChildrenTaxFree)
                .HasColumnName("CHILDREN_TAX_FREE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompRoomNts)
                .HasColumnName("COMP_ROOM_NTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompRoomRevenue)
                .HasColumnName("COMP_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComplimentaryYn)
                .HasColumnName("COMPLIMENTARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ContactId)
                .HasColumnName("CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactYn)
                .HasColumnName("CONTACT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryMainGroup)
                .HasColumnName("COUNTRY_MAIN_GROUP")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Cribs)
                .HasColumnName("CRIBS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUsePersons)
                .HasColumnName("DAY_USE_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseReservations)
                .HasColumnName("DAY_USE_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DayUseRooms)
                .HasColumnName("DAY_USE_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepPersons)
                .HasColumnName("DEP_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepRooms)
                .HasColumnName("DEP_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.District)
                .HasColumnName("DISTRICT")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.DueOutYn)
                .HasColumnName("DUE_OUT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExtraBeds)
                .HasColumnName("EXTRA_BEDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FfMembershipNo)
                .HasColumnName("FF_MEMBERSHIP_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FfMembershipType)
                .HasColumnName("FF_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FgMembershipNo)
                .HasColumnName("FG_MEMBERSHIP_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FgMembershipType)
                .HasColumnName("FG_MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FiscalRegionCode)
                .HasColumnName("FISCAL_REGION_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FoodRevenue)
                .HasColumnName("FOOD_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HouseUseYn)
                .HasColumnName("HOUSE_USE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ImportDate)
                .HasColumnName("IMPORT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InterfaceId)
                .IsRequired()
                .HasColumnName("INTERFACE_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketMainGroup)
                .HasColumnName("MARKET_MAIN_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MultipleOccupancy)
                .HasColumnName("MULTIPLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfStays)
                .HasColumnName("NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowPersons)
                .HasColumnName("NO_SHOW_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowReservations)
                .HasColumnName("NO_SHOW_RESERVATIONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRooms)
                .HasColumnName("NO_SHOW_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.OriginalEndDate)
                .HasColumnName("ORIGINAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageFoodRevenue)
                .HasColumnName("PACKAGE_FOOD_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageNonRevenue)
                .HasColumnName("PACKAGE_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageOtherRevenue)
                .HasColumnName("PACKAGE_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PackageRoomRevenue)
                .HasColumnName("PACKAGE_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.ParentCompanyId)
                .HasColumnName("PARENT_COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhysicalQuantity)
                .HasColumnName("PHYSICAL_QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrFoodRevenue)
                .HasColumnName("PR_FOOD_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrNonRevenue)
                .HasColumnName("PR_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrOtherRevenue)
                .HasColumnName("PR_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrPackageFoodRevenue)
                .HasColumnName("PR_PACKAGE_FOOD_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrPackageNonRevenue)
                .HasColumnName("PR_PACKAGE_NON_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrPackageOtherRevenue)
                .HasColumnName("PR_PACKAGE_OTHER_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrPackageRoomRevenue)
                .HasColumnName("PR_PACKAGE_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrRoomRevenue)
                .HasColumnName("PR_ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrTotalFoodTax)
                .HasColumnName("PR_TOTAL_FOOD_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrTotalNonRevenueTax)
                .HasColumnName("PR_TOTAL_NON_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrTotalOtherTax)
                .HasColumnName("PR_TOTAL_OTHER_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrTotalPackageRevenue)
                .HasColumnName("PR_TOTAL_PACKAGE_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrTotalRevenue)
                .HasColumnName("PR_TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrTotalRoomTax)
                .HasColumnName("PR_TOTAL_ROOM_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrTotalTax)
                .HasColumnName("PR_TOTAL_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PromotionCode)
                .HasColumnName("PROMOTION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PsuedoRoomYn)
                .HasColumnName("PSUEDO_ROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReservationArrivals)
                .HasColumnName("RESERVATION_ARRIVALS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReservationNights)
                .HasColumnName("RESERVATION_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReservationNoOfStays)
                .HasColumnName("RESERVATION_NO_OF_STAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomAdults)
                .HasColumnName("ROOM_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomChildren)
                .HasColumnName("ROOM_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomResvStatus)
                .HasColumnName("ROOM_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.SingleOccupancy)
                .HasColumnName("SINGLE_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceMainGroup)
                .HasColumnName("SOURCE_MAIN_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceProfId)
                .HasColumnName("SOURCE_PROF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StageStatus)
                .HasColumnName("STAGE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StageSuspenseReason)
                .HasColumnName("STAGE_SUSPENSE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StayAdults)
                .HasColumnName("STAY_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayChildren)
                .HasColumnName("STAY_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayPersons)
                .HasColumnName("STAY_PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StayRooms)
                .HasColumnName("STAY_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalFoodTax)
                .HasColumnName("TOTAL_FOOD_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalNonRevenueTax)
                .HasColumnName("TOTAL_NON_REVENUE_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalOtherTax)
                .HasColumnName("TOTAL_OTHER_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalPackageRevenue)
                .HasColumnName("TOTAL_PACKAGE_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalRoomTax)
                .HasColumnName("TOTAL_ROOM_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TotalTax)
                .HasColumnName("TOTAL_TAX")
                .HasColumnType("NUMBER(38,12)");

            entity.Property(e => e.TruncBeginDate)
                .HasColumnName("TRUNC_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEndDate)
                .HasColumnName("TRUNC_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WalkinYn)
                .HasColumnName("WALKIN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
