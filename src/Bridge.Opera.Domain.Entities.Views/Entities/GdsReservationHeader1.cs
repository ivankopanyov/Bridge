namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GdsReservationHeader1
{
    public string ConfirmationNo { get; set; }
    public decimal ResvNameId { get; set; }
    public string ResvStatus { get; set; }
    public string GuaranteeType { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string CancelNumber { get; set; }
    public decimal Nights { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string Resort { get; set; }
    public string BookingSource { get; set; }
    public string GdsRecordLocator { get; set; }
    public string GuestName { get; set; }
    public string ReferenceConfirmationNo { get; set; }
    public string SgaCode { get; set; }
    public string PseudoCode { get; set; }
    public string CompanyGroupId { get; set; }
    public decimal? CreditCardId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsReservationHeader1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GDS_RESERVATION_HEADER");

            entity.Property(e => e.ArrivalDate)
                .HasColumnName("ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingSource)
                .IsRequired()
                .HasColumnName("BOOKING_SOURCE")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.CancelNumber)
                .HasColumnName("CANCEL_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CompanyGroupId)
                .HasColumnName("COMPANY_GROUP_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .IsRequired()
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardId)
                .HasColumnName("CREDIT_CARD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GdsRecordLocator)
                .HasColumnName("GDS_RECORD_LOCATOR")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeType)
                .HasColumnName("GUARANTEE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .IsRequired()
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Nights)
                .HasColumnName("NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PseudoCode)
                .HasColumnName("PSEUDO_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ReferenceConfirmationNo)
                .HasColumnName("REFERENCE_CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SgaCode)
                .HasColumnName("SGA_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
