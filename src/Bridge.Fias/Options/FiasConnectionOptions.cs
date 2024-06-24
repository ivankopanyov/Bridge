namespace Bridge.Fias.Options;

public partial class FiasConnectionOptions
{
    private static readonly HashSet<FiasOptions> _reservation = [
        new FiasGuestCheckInOptions
        {
            DateTime = true,
            ProfileNumber = true,
            GuestArrivalDate = true,
            GuestDepartureDate = true,
            GuestFirstName = true,
            GuestGroupNumber = true,
            GuestLanguage = true,
            GuestName = true,
            GuestTitle = true,
            GuestVipStatus = true,
            NoPostStatus = true,
            SwapFlag = true
        },
        new FiasGuestCheckOutOptions
        {
            DateTime = true,
            SwapFlag = true
        },
        new FiasGuestChangeOptions
        {
            DateTime = true,
            ProfileNumber = true,
            GuestArrivalDate = true,
            GuestDepartureDate = true,
            GuestFirstName = true,
            GuestGroupNumber = true,
            GuestLanguage = true,
            GuestName = true,
            GuestTitle = true,
            GuestVipStatus = true,
            NoPostStatus = true,
            OldRoomNumber = true
        }
    ];

    private static readonly HashSet<FiasOptions> _posting = [
        new FiasPostingSimpleOptions
        {
            SalesOutlet = true,
            TotalPostingAmount = true,
            PmsPaymentMethod = true,
            CheckNumber = true,
            Discounts = true,
            Subtotals = true,
            ServiceCharge = true,
            Taxes = true
        },
        new FiasPostingRequestOptions
        {
            PostingInquiry = true,
            MaximumGuests = true,
            SalesOutlet = true,
            UserId = true,
            DateTime = true,
            ReservationNumber = true,
            GuestName = true,
            RoomNumber = true,
            TotalPostingAmount = true,
            CheckNumber = true,
            Covers = true,
            ProfileNumber = true,
            Discounts = true,
            Subtotals = true,
            ServiceCharge = true,
            Taxes = true,
            Tip = true,
            CreditLimitOverrideFlag = true
        },
        new FiasPostingListOptions
        {
            DateTime = true,
            CheckNumber = true,
            GuestArrivalDate = true,
            GuestDepartureDate = true,
            GuestFirstName = true,
            PmsPaymentMethod = true
        },
        new FiasPostingAnswerOptions
        {
            CheckNumber = true
        }
    ];

    public static ISet<FiasOptions> Reservation => _reservation;

    public static ISet<FiasOptions> Posting => _posting;
}
