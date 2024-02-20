namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CompRequestsView
{
    public string? Resort { get; set; }
    public string? ReservationResort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? Room { get; set; }
    public string? GuestName { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? MembershipNumber { get; set; }
    public string? Vip { get; set; }
    public string? ShortResvStatus { get; set; }
    public string? ActionedBy { get; set; }
    public string? Comments { get; set; }
    public decimal? AuthorizerId { get; set; }
    public string? DeclinedYn { get; set; }
    public decimal? DeclinedBy { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string? ArrivalTime { get; set; }
    public string? DepartureTime { get; set; }
    public string? RoutingType { get; set; }
    public string? RoutingDecode { get; set; }
    public string? ResvStatus { get; set; }
    public decimal? FolioView { get; set; }
    public decimal? ToResvNameId { get; set; }
    public string? RoutingDesc { get; set; }
    public string? CompVoucherNo { get; set; }
    public string? RequestedBy { get; set; }
    public string? CompTypeCode { get; set; }
    public string? ComputedResvStatus { get; set; }
    public decimal? NameId { get; set; }
    public string? GuaranteeCode { get; set; }
    public string? DispResvStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CompRequestsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("COMP_REQUESTS_VIEW");

            entity.Property(e => e.ActionedBy)
                .HasColumnName("ACTIONED_BY")
                .IsUnicode(false);

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CompTypeCode)
                .HasColumnName("COMP_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompVoucherNo)
                .HasColumnName("COMP_VOUCHER_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DeclinedBy)
                .HasColumnName("DECLINED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeclinedYn)
                .HasColumnName("DECLINED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.DepartureTime)
                .HasColumnName("DEPARTURE_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.DispResvStatus)
                .HasColumnName("DISP_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.MembershipNumber)
                .HasColumnName("MEMBERSHIP_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestedBy)
                .HasColumnName("REQUESTED_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReservationResort)
                .IsRequired()
                .HasColumnName("RESERVATION_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
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

            entity.Property(e => e.RoutingDecode)
                .HasColumnName("ROUTING_DECODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.RoutingDesc)
                .HasColumnName("ROUTING_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RoutingType)
                .HasColumnName("ROUTING_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ShortResvStatus)
                .HasColumnName("SHORT_RESV_STATUS")
                .IsUnicode(false);

            entity.Property(e => e.ToResvNameId)
                .HasColumnName("TO_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
