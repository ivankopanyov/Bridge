namespace Bridge.EventBus.Shared;

public class ReservationUpdateInfo
{
    public string GenericNo { get; set; }

    public string Status { get; set; }

    public DateTime ArrivalDate { get; set; }

    public DateTime DepartureDate { get; set; }

    //public string CustomFieldValues = 

    public string GuestGenericNo { get; set; }

    public string Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? Sex { get; set; }

    public string BirthDateStr { get; set; }

    public DateTime? BirthDate { get; set; }

    //public string Notes = 

    public DateTime? TruncBeginDate { get; set; }

    public DateTime? TruncEndDate { get; set; }

    //public string DocumentTypeName =

    //public string DocumentNumber = 

    public string? DocumentSeries { get; set; }

    public string? DepartmentCode { get; set; }

    public DateTime? IssueDate { get; set; }

    //public string ExpirationDate = 

    //public string RegistrationDate = 

    public string? IssuerInfo { get; set; }

    public DateTime? BusinnesDate { get; set; }

    public string? DocumentTypeCode { get; set; }

    public string? DocumentNumber { get; set; }

    public TimelineInfo CurrentTimeline { get; set; }

    public ISet<TimelineInfo> Timelines { get; set; }

    public AddressInfo? Address { get; set; }

    public ISet<PhoneInfo> Phones { get; set; }
}
