namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResvMealVouchers
{
    public string Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string GuestName { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string RoomNumber { get; set; }
    public string BlockCode { get; set; }
    public string GroupName { get; set; }
    public decimal? Adults { get; set; }
    public decimal? Children { get; set; }
    public string ProductId { get; set; }
    public string ProductDesc { get; set; }
    public string PrintSeperateYn { get; set; }
    public string AddToRateYn { get; set; }
    public string CalculationRule { get; set; }
    public string PostingRhythm { get; set; }
    public string ResvStatus { get; set; }
    public string FirstName { get; set; }
    public string GuestTitle { get; set; }
    public string RoomClass { get; set; }
    public decimal? GuestNameId { get; set; }
    public string RoomCategory { get; set; }
    public string RateCode { get; set; }
    public decimal? AllotmentHeaderId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResvMealVouchers>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESV_MEAL_VOUCHERS");

            entity.Property(e => e.AddToRateYn)
                .HasColumnName("ADD_TO_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CalculationRule)
                .HasColumnName("CALCULATION_RULE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Children)
                .HasColumnName("CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GuestNameId)
                .HasColumnName("GUEST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GuestTitle)
                .HasColumnName("GUEST_TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrintSeperateYn)
                .HasColumnName("PRINT_SEPERATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProductDesc)
                .HasColumnName("PRODUCT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
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
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
