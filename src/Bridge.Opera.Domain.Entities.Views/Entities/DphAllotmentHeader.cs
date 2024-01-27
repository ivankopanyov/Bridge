namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DphAllotmentHeader
{
    public string PropertyCode { get; set; }
    public string DelphiInternalId { get; set; }
    public string ResvervationId { get; set; }
    public string BookingName { get; set; }
    public string ArrivalDate { get; set; }
    public string DepartureDate { get; set; }
    public string BookingStatus { get; set; }
    public string MeetingType { get; set; }
    public string Status { get; set; }
    public string RoomBlockFlag { get; set; }
    public string ReleasedFlag { get; set; }
    public string CutoffDate { get; set; }
    public string DateDefinite { get; set; }
    public string BookedBy { get; set; }
    public string GuestroomSource { get; set; }
    public string CateringSource { get; set; }
    public string ServiceManager { get; set; }
    public string OutsideLead { get; set; }
    public string HousingBy { get; set; }
    public string RateType { get; set; }
    public string BillingRoom { get; set; }
    public string BillingCateredFb { get; set; }
    public string ControlFlag { get; set; }
    public string BillingLounge { get; set; }
    public string BillingIncidentals { get; set; }
    public string BookingComments { get; set; }
    public string GeographicCode { get; set; }
    public string ContractName { get; set; }
    public string ContractType { get; set; }
    public string NoOfNites { get; set; }
    public string CutoffType { get; set; }
    public string CutoffDays { get; set; }
    public string StatusTraceDate { get; set; }
    public string Dummy1 { get; set; }
    public string AccountInfo { get; set; }
    public string AgentInfo { get; set; }
    public string BookingInfo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DphAllotmentHeader>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DPH_ALLOTMENT_HEADER");

            entity.Property(e => e.AccountInfo)
                .HasColumnName("ACCOUNT_INFO")
                .HasMaxLength(1143)
                .IsUnicode(false);

            entity.Property(e => e.AgentInfo)
                .HasColumnName("AGENT_INFO")
                .HasMaxLength(1143)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.BillingCateredFb)
                .HasColumnName("BILLING_CATERED_FB")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BillingIncidentals)
                .HasColumnName("BILLING_INCIDENTALS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BillingLounge)
                .HasColumnName("BILLING_LOUNGE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BillingRoom)
                .HasColumnName("BILLING_ROOM")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BookedBy)
                .HasColumnName("BOOKED_BY")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.BookingComments)
                .HasColumnName("BOOKING_COMMENTS")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.BookingInfo)
                .HasColumnName("BOOKING_INFO")
                .HasMaxLength(903)
                .IsUnicode(false);

            entity.Property(e => e.BookingName)
                .HasColumnName("BOOKING_NAME")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.CateringSource)
                .HasColumnName("CATERING_SOURCE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ContractName)
                .HasColumnName("CONTRACT_NAME")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.ContractType)
                .HasColumnName("CONTRACT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ControlFlag)
                .HasColumnName("CONTROL_FLAG")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.CutoffDate)
                .HasColumnName("CUTOFF_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.CutoffDays)
                .HasColumnName("CUTOFF_DAYS")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.CutoffType)
                .HasColumnName("CUTOFF_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DateDefinite)
                .HasColumnName("DATE_DEFINITE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.DelphiInternalId)
                .HasColumnName("DELPHI_INTERNAL_ID")
                .HasMaxLength(54)
                .IsUnicode(false);

            entity.Property(e => e.DepartureDate)
                .HasColumnName("DEPARTURE_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Dummy1)
                .HasColumnName("DUMMY1")
                .HasMaxLength(76)
                .IsUnicode(false);

            entity.Property(e => e.GeographicCode)
                .HasColumnName("GEOGRAPHIC_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.GuestroomSource)
                .HasColumnName("GUESTROOM_SOURCE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.HousingBy)
                .HasColumnName("HOUSING_BY")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.MeetingType)
                .HasColumnName("MEETING_TYPE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.NoOfNites)
                .HasColumnName("NO_OF_NITES")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.OutsideLead)
                .HasColumnName("OUTSIDE_LEAD")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.RateType)
                .HasColumnName("RATE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReleasedFlag)
                .HasColumnName("RELEASED_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResvervationId)
                .HasColumnName("RESVERVATION_ID")
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.Property(e => e.RoomBlockFlag)
                .HasColumnName("ROOM_BLOCK_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ServiceManager)
                .HasColumnName("SERVICE_MANAGER")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.StatusTraceDate)
                .HasColumnName("STATUS_TRACE_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);
        });
	}
}
