namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DphCheckoutInfo
{
    public string PropertyCode { get; set; }
    public string DelphiInternalId { get; set; }
    public string ReservationId { get; set; }
    public string MasterAccountCode { get; set; }
    public string AccountCode { get; set; }
    public string AccountName { get; set; }
    public string MasterAgencyCode { get; set; }
    public string AgencyCode { get; set; }
    public string AgencyName { get; set; }
    public string TruncArrival { get; set; }
    public string TruncDeparture { get; set; }
    public string RoomType { get; set; }
    public string NoOfRoomsPickup { get; set; }
    public string NoOfGuests { get; set; }
    public string SingleRoomsPickup { get; set; }
    public string DoubleRoomsPickup { get; set; }
    public string TripleRoomsPickup { get; set; }
    public string QuadRoomsPickup { get; set; }
    public string GuestRoomRevenue { get; set; }
    public string NonGuestRoomRevenue { get; set; }
    public string GuestId { get; set; }
    public string GuestName { get; set; }
    public string GuestAddress1 { get; set; }
    public string GuestAddress2 { get; set; }
    public string GuestCity { get; set; }
    public string GuestState { get; set; }
    public string GuestPostalCode { get; set; }
    public string GuestCountry { get; set; }
    public string GuestPaymentMethod { get; set; }
    public string GuestCreditCard { get; set; }
    public string GuestCreditCardNum { get; set; }
    public string GuestCreditCardExp { get; set; }
    public string GuestPackageCode { get; set; }
    public string GuestMealCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DphCheckoutInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DPH_CHECKOUT_INFO");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.AccountName)
                .HasColumnName("ACCOUNT_NAME")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.AgencyCode)
                .HasColumnName("AGENCY_CODE")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.AgencyName)
                .HasColumnName("AGENCY_NAME")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.DelphiInternalId)
                .HasColumnName("DELPHI_INTERNAL_ID")
                .HasMaxLength(54)
                .IsUnicode(false);

            entity.Property(e => e.DoubleRoomsPickup)
                .HasColumnName("DOUBLE_ROOMS_PICKUP")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddress1)
                .HasColumnName("GUEST_ADDRESS1")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.GuestAddress2)
                .HasColumnName("GUEST_ADDRESS2")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.GuestCity)
                .HasColumnName("GUEST_CITY")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.GuestCountry)
                .HasColumnName("GUEST_COUNTRY")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.GuestCreditCard)
                .HasColumnName("GUEST_CREDIT_CARD")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.GuestCreditCardExp)
                .HasColumnName("GUEST_CREDIT_CARD_EXP")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.GuestCreditCardNum)
                .HasColumnName("GUEST_CREDIT_CARD_NUM")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.GuestId)
                .HasColumnName("GUEST_ID")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.GuestMealCode)
                .HasColumnName("GUEST_MEAL_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.GuestPackageCode)
                .HasColumnName("GUEST_PACKAGE_CODE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.GuestPaymentMethod)
                .HasColumnName("GUEST_PAYMENT_METHOD")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.GuestPostalCode)
                .HasColumnName("GUEST_POSTAL_CODE")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.GuestRoomRevenue)
                .HasColumnName("GUEST_ROOM_REVENUE")
                .HasMaxLength(39)
                .IsUnicode(false);

            entity.Property(e => e.GuestState)
                .HasColumnName("GUEST_STATE")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.MasterAccountCode)
                .HasColumnName("MASTER_ACCOUNT_CODE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.MasterAgencyCode)
                .HasColumnName("MASTER_AGENCY_CODE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.NoOfGuests)
                .HasColumnName("NO_OF_GUESTS")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.NoOfRoomsPickup)
                .HasColumnName("NO_OF_ROOMS_PICKUP")
                .HasMaxLength(21)
                .IsUnicode(false);

            entity.Property(e => e.NonGuestRoomRevenue)
                .HasColumnName("NON_GUEST_ROOM_REVENUE")
                .HasMaxLength(39)
                .IsUnicode(false);

            entity.Property(e => e.PropertyCode)
                .HasColumnName("PROPERTY_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.QuadRoomsPickup)
                .HasColumnName("QUAD_ROOMS_PICKUP")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.ReservationId)
                .HasColumnName("RESERVATION_ID")
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.SingleRoomsPickup)
                .HasColumnName("SINGLE_ROOMS_PICKUP")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.TripleRoomsPickup)
                .HasColumnName("TRIPLE_ROOMS_PICKUP")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrival)
                .HasColumnName("TRUNC_ARRIVAL")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.TruncDeparture)
                .HasColumnName("TRUNC_DEPARTURE")
                .HasMaxLength(8)
                .IsUnicode(false);
        });
	}
}
