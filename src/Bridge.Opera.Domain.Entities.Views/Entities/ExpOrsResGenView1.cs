namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpOrsResGenView1
{
    public string? Resort { get; set; }
    public decimal? Seqno { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RoomResort { get; set; }
    public string? ComputedResvStatus { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public string? ArrivalTime { get; set; }
    public decimal? Nights { get; set; }
    public DateTime? Departure { get; set; }
    public string? DepartureTime { get; set; }
    public string? PostingAllowedYn { get; set; }
    public string? PrintRateYn { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? GuestName { get; set; }
    public string? Sname { get; set; }
    public decimal? GuestNameId { get; set; }
    public DateTime? ArrivalDateTime { get; set; }
    public DateTime? DepartureDateTime { get; set; }
    public string? CancellationNo { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string? CancellationReasonCode { get; set; }
    public string? CancellationReasonDesc { get; set; }
    public string? WlReasonCode { get; set; }
    public string? WlPriority { get; set; }
    public string? WlReasonDescription { get; set; }
    public DateTime? ActualCheckInDate { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public DateTime? TruncActualCheckOutDate { get; set; }
    public DateTime? OriginalEndDate { get; set; }
    public string? GuaranteeCode { get; set; }
    public decimal? ParentResvNameId { get; set; }
    public string? ExternalReference { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? NameTaxType { get; set; }
    public string? NameTaxDescription { get; set; }
    public string? TaxExemptNo { get; set; }
    public string? FixedRateYn { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public decimal? ShareAmount { get; set; }
    public string? GroupName { get; set; }
    public decimal? GroupId { get; set; }
    public string? SourceName { get; set; }
    public decimal? SourceId { get; set; }
    public string? RateCode { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomCategory { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string? Room { get; set; }
    public decimal? OriginalBaseRate { get; set; }
    public decimal? BaseRateAmount { get; set; }
    public decimal? RoomCost { get; set; }
    public decimal? EffectiveRateAmount { get; set; }
    public string? CurrencyCode { get; set; }
    public string? ExchangePostingType { get; set; }
    public DateTime? ReservationDate { get; set; }
    public DateTime? RdenReservationDate { get; set; }
    public decimal? ShareId { get; set; }
    public string? SysStatus { get; set; }
    public decimal? ResvNo { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string? SguestName { get; set; }
    public string? Channel { get; set; }
    public string? BusinessTitle { get; set; }
    public string? Passport { get; set; }
    public string? Nationality { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? NameType { get; set; }
    public decimal? ResvContactId { get; set; }
    public string? ResvContactName { get; set; }
    public string? RegistrationCardNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpOrsResGenView1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_ORS_RES_GEN_VIEW1");

            entity.Property(e => e.ActualCheckInDate)
                .HasColumnName("ACTUAL_CHECK_IN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalDateTime)
                .HasColumnName("ARRIVAL_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.BaseRateAmount)
                .HasColumnName("BASE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BirthDate)
                .HasColumnName("BIRTH_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessTitle)
                .HasColumnName("BUSINESS_TITLE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationNo)
                .HasColumnName("CANCELLATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CancellationReasonCode)
                .HasColumnName("CANCELLATION_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationReasonDesc)
                .HasColumnName("CANCELLATION_REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureDateTime)
                .HasColumnName("DEPARTURE_DATE_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.EffectiveRateAmount)
                .HasColumnName("EFFECTIVE_RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.FixedRateYn)
                .HasColumnName("FIXED_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTaxDescription)
                .HasColumnName("NAME_TAX_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .HasColumnName("NATIONALITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalBaseRate)
                .HasColumnName("ORIGINAL_BASE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalEndDate)
                .HasColumnName("ORIGINAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ParentResvNameId)
                .HasColumnName("PARENT_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Passport)
                .HasColumnName("PASSPORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PostingAllowedYn)
                .HasColumnName("POSTING_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintRateYn)
                .HasColumnName("PRINT_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RdenReservationDate)
                .HasColumnName("RDEN_RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RegistrationCardNo)
                .HasColumnName("REGISTRATION_CARD_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReservationDate)
                .HasColumnName("RESERVATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvContactId)
                .HasColumnName("RESV_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvContactName)
                .HasColumnName("RESV_CONTACT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNo)
                .HasColumnName("RESV_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
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

            entity.Property(e => e.RoomCost)
                .HasColumnName("ROOM_COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Seqno)
                .HasColumnName("SEQNO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ShareAmount)
                .HasColumnName("SHARE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShareId)
                .HasColumnName("SHARE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sname)
                .IsRequired()
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.SysStatus)
                .HasColumnName("SYS_STATUS")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.TaxExemptNo)
                .HasColumnName("TAX_EXEMPT_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncActualCheckOutDate)
                .HasColumnName("TRUNC_ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WlPriority)
                .HasColumnName("WL_PRIORITY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WlReasonCode)
                .HasColumnName("WL_REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WlReasonDescription)
                .HasColumnName("WL_REASON_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
