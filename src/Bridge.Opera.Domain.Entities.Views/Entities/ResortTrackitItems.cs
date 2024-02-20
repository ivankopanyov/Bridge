namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortTrackitItems
{
    public string? Resort { get; set; }
    public decimal? TrackitId { get; set; }
    public string? TiGroup { get; set; }
    public string? TicketNo { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? Location { get; set; }
    public string? Action { get; set; }
    public string? TrackitType { get; set; }
    public string? Status { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public string? Room { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public DateTime? BusinessDateCreated { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public string? InsertUserName { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? UpdateUserName { get; set; }
    public DateTime? BusinessDateResolved { get; set; }
    public decimal? ResolvedUser { get; set; }
    public string? Description { get; set; }
    public DateTime? FollowUp { get; set; }
    public string? LocationDesc { get; set; }
    public string? ActionDesc { get; set; }
    public string? TypeDesc { get; set; }
    public decimal? Quantity { get; set; }
    public string? ReferenceNo { get; set; }
    public decimal? Msgid { get; set; }
    public string? ExternalId { get; set; }
    public DateTime? LastUpdate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortTrackitItems>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_TRACKIT_ITEMS");

            entity.Property(e => e.Action)
                .HasColumnName("ACTION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActionDesc)
                .HasColumnName("ACTION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.BusinessDateCreated)
                .HasColumnName("BUSINESS_DATE_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDateResolved)
                .HasColumnName("BUSINESS_DATE_RESOLVED")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ExternalId)
                .HasColumnName("EXTERNAL_ID")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FollowUp)
                .HasColumnName("FOLLOW_UP")
                .HasColumnType("DATE");

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertUserName)
                .HasColumnName("INSERT_USER_NAME")
                .IsUnicode(false);

            entity.Property(e => e.LastUpdate)
                .HasColumnName("LAST_UPDATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Location)
                .HasColumnName("LOCATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LocationDesc)
                .HasColumnName("LOCATION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Msgid)
                .HasColumnName("MSGID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quantity)
                .HasColumnName("QUANTITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReferenceNo)
                .HasColumnName("REFERENCE_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedUser)
                .HasColumnName("RESOLVED_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
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

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TiGroup)
                .IsRequired()
                .HasColumnName("TI_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TicketNo)
                .HasColumnName("TICKET_NO")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TrackitId)
                .HasColumnName("TRACKIT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrackitType)
                .HasColumnName("TRACKIT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.TypeDesc)
                .HasColumnName("TYPE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateUserName)
                .HasColumnName("UPDATE_USER_NAME")
                .IsUnicode(false);
        });
	}
}
