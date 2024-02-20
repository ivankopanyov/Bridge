namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PmsFutureReservationView1
{
    public string? NameType { get; set; }
    public decimal? ResvNo { get; set; }
    public string? FReservationtype { get; set; }
    public string? FResort { get; set; }
    public string? FRate { get; set; }
    public string? FRoom { get; set; }
    public string? BlockCode { get; set; }
    public string? RoomType { get; set; }
    public decimal? FPrice { get; set; }
    public decimal? FAdults { get; set; }
    public decimal? FChildren { get; set; }
    public decimal? FNoofrooms { get; set; }
    public DateTime? FArrival { get; set; }
    public DateTime? FDeparture { get; set; }
    public string? FGuestName { get; set; }
    public decimal? NameId { get; set; }
    public string? FAgent { get; set; }
    public string? FGroup { get; set; }
    public string? FSourcename { get; set; }
    public string? FCompany { get; set; }
    public string? FRemarks { get; set; }
    public string? FContactName { get; set; }
    public string? ResvStatus { get; set; }
    public string? ComputedResvStatus { get; set; }
    public string? MarketCode { get; set; }
    public string? OriginOfBooking { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsFutureReservationView1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PMS_FUTURE_RESERVATION_VIEW1");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FAdults)
                .HasColumnName("F_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FAgent)
                .HasColumnName("F_AGENT")
                .IsUnicode(false);

            entity.Property(e => e.FArrival)
                .HasColumnName("F_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.FChildren)
                .HasColumnName("F_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCompany)
                .HasColumnName("F_COMPANY")
                .IsUnicode(false);

            entity.Property(e => e.FContactName)
                .HasColumnName("F_CONTACT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.FDeparture)
                .HasColumnName("F_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.FGroup)
                .HasColumnName("F_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.FGuestName)
                .HasColumnName("F_GUEST_NAME")
                .IsUnicode(false);

            entity.Property(e => e.FNoofrooms)
                .HasColumnName("F_NOOFROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FPrice)
                .HasColumnName("F_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FRate)
                .HasColumnName("F_RATE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FRemarks)
                .HasColumnName("F_REMARKS")
                .IsUnicode(false);

            entity.Property(e => e.FReservationtype)
                .HasColumnName("F_RESERVATIONTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FResort)
                .HasColumnName("F_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FRoom)
                .HasColumnName("F_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FSourcename)
                .HasColumnName("F_SOURCENAME")
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.OriginOfBooking)
                .HasColumnName("ORIGIN_OF_BOOKING")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNo)
                .HasColumnName("RESV_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .IsUnicode(false);
        });
	}
}
