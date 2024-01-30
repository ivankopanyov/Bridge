namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TaRgvView
{
    public string? Resort { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? Room { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public decimal? NoOfRooms { get; set; }
    public string? ComputedResvStatus { get; set; }
    public string? ResvStatus { get; set; }
    public string? TravelAgentName { get; set; }
    public string? SourceName { get; set; }
    public string? CompanyName { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? SourceId { get; set; }
    public decimal? CompanyId { get; set; }
    public decimal? TravelAgentId { get; set; }
    public decimal? GroupId { get; set; }
    public decimal? CommissionPaid { get; set; }
    public string? PartyCode { get; set; }
    public decimal? RoomRevenue { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public string? HistoryYn { get; set; }
    public string? SguestName { get; set; }
    public string? SfirstGuestName { get; set; }
    public string? XfirstName { get; set; }
    public string? XlastName { get; set; }
    public string? SxfirstName { get; set; }
    public string? Sxname { get; set; }
    public string? RateCode { get; set; }
    public string? ExternalReference { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? PaidYn { get; set; }
    public string? TravelAgentPaidYn { get; set; }
    public string? SourcePaidYn { get; set; }
    public string? FullName { get; set; }
    public string? XfullName { get; set; }
    public string? SharedYn { get; set; }
    public decimal? InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TaRgvView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TA_RGV_VIEW");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.CommissionPaid)
                .HasColumnName("COMMISSION_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExternalReference)
                .HasColumnName("EXTERNAL_REFERENCE")
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .HasMaxLength(162)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestFirstName)
                .HasColumnName("GUEST_FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HistoryYn)
                .HasColumnName("HISTORY_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaidYn)
                .HasColumnName("PAID_YN")
                .IsUnicode(false);

            entity.Property(e => e.PartyCode)
                .HasColumnName("PARTY_CODE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SfirstGuestName)
                .HasColumnName("SFIRST_GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SguestName)
                .HasColumnName("SGUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SharedYn)
                .HasColumnName("SHARED_YN")
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
                .IsUnicode(false);

            entity.Property(e => e.SourcePaidYn)
                .HasColumnName("SOURCE_PAID_YN")
                .IsUnicode(false);

            entity.Property(e => e.SxfirstName)
                .HasColumnName("SXFIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Sxname)
                .HasColumnName("SXNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentPaidYn)
                .HasColumnName("TRAVEL_AGENT_PAID_YN")
                .IsUnicode(false);

            entity.Property(e => e.XfirstName)
                .HasColumnName("XFIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XfullName)
                .HasColumnName("XFULL_NAME")
                .HasMaxLength(82)
                .IsUnicode(false);

            entity.Property(e => e.XlastName)
                .HasColumnName("XLAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
