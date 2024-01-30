namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepDepositDtlView
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public string? ArrivalChar { get; set; }
    public string? PaymentMethod { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public decimal? GuestId { get; set; }
    public string? FullName { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? PreferredRoomType { get; set; }
    public string? ResType { get; set; }
    public string? Departure { get; set; }
    public string? GuestTitle { get; set; }
    public string? GuestMiddleName { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? GroupId { get; set; }
    public string? CompanyName { get; set; }
    public string? TravelAgentName { get; set; }
    public string? GroupName { get; set; }
    public string? RateCode { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string? Room { get; set; }
    public decimal? PaidAmt { get; set; }
    public DateTime? PaidDate { get; set; }
    public decimal? DepositAsked { get; set; }
    public DateTime? MaxPaidDate { get; set; }
    public string? RoomType { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? GuaranteeCodeDesc { get; set; }
    public DateTime? DepositDueDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepDepositDtlView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_DEPOSIT_DTL_VIEW");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalChar)
                .HasColumnName("ARRIVAL_CHAR")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.DepositAsked)
                .HasColumnName("DEPOSIT_ASKED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositDueDate)
                .HasColumnName("DEPOSIT_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
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

            entity.Property(e => e.GuaranteeCodeDesc)
                .HasColumnName("GUARANTEE_CODE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestId)
                .HasColumnName("GUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestMiddleName)
                .HasColumnName("GUEST_MIDDLE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(74)
                .IsUnicode(false);

            entity.Property(e => e.GuestTitle)
                .HasColumnName("GUEST_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MaxPaidDate)
                .HasColumnName("MAX_PAID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidAmt)
                .HasColumnName("PAID_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidDate)
                .HasColumnName("PAID_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PreferredRoomType)
                .HasColumnName("PREFERRED_ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResType)
                .HasColumnName("RES_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
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

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .IsUnicode(false);
        });
	}
}
