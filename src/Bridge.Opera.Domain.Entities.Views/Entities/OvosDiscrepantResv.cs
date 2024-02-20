namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OvosDiscrepantResv
{
    public decimal? Casenum { get; set; }
    public decimal? ContractId { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? ProfileType { get; set; }
    public string? OwnerRentalHotel { get; set; }
    public string? OwnerFfFlag { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RoomResort { get; set; }
    public string? ResvStatus { get; set; }
    public DateTime? Arrival { get; set; }
    public decimal? Nights { get; set; }
    public DateTime? Departure { get; set; }
    public string? ConfirmationNo { get; set; }
    public string? GuestName { get; set; }
    public string? GuestFirstName { get; set; }
    public decimal? GuestNameId { get; set; }
    public string? RateCode { get; set; }
    public string? Room { get; set; }
    public DateTime? TruncArrival { get; set; }
    public DateTime? TruncDeparture { get; set; }
    public string? OwnerRoomCategory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosDiscrepantResv>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OVOS_DISCREPANT_RESV");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.Casenum)
                .HasColumnName("CASENUM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
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

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.OwnerFfFlag)
                .HasColumnName("OWNER_FF_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OwnerRentalHotel)
                .HasColumnName("OWNER_RENTAL_HOTEL")
                .IsUnicode(false);

            entity.Property(e => e.OwnerRoomCategory)
                .HasColumnName("OWNER_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProfileType)
                .HasColumnName("PROFILE_TYPE")
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

            entity.Property(e => e.RoomResort)
                .IsRequired()
                .HasColumnName("ROOM_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasColumnType("DATE");
        });
	}
}
