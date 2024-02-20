namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MealVouchersTemp
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? GuestName { get; set; }
    public DateTime? Arrival { get; set; }
    public DateTime? Departure { get; set; }
    public string? RoomNumber { get; set; }
    public decimal? GroupId { get; set; }
    public string? GroupName { get; set; }
    public int? Adults { get; set; }
    public int? Children { get; set; }
    public string? ProductId { get; set; }
    public string? ProductDesc { get; set; }
    public string? PrintSeperateYn { get; set; }
    public string? AddToRateYn { get; set; }
    public string? SeperatelySoldYn { get; set; }
    public string? CalculationRule { get; set; }
    public string? PostingRhythm { get; set; }
    public string? ResvStatus { get; set; }
    public string? FirstName { get; set; }
    public string? GuestTitle { get; set; }
    public string? RoomClass { get; set; }
    public decimal? GuestNameId { get; set; }
    public long? Batchno { get; set; }
    public DateTime? PrintDate { get; set; }
    public string? PrintTime { get; set; }
    public long? SerialNo { get; set; }
    public string? BlockCode { get; set; }
    public DateTime? ValidDate { get; set; }
    public int? Reprints { get; set; }
    public string? ProductSource { get; set; }
    public decimal? NoOfVouchers { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MealVouchersTemp>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MEAL_VOUCHERS_TEMP");

            entity.HasIndex(e => new { e.ValidDate, e.ProductId, e.ResvNameId })
                .HasName("MEAL_VOUCHERS_PK")
                .IsUnique();

            entity.HasIndex(e => new { e.ValidDate, e.ProductId, e.ResvNameId, e.ProductSource })
                .HasName("MEAL_VOUCHERS_UK")
                .IsUnique();

            entity.Property(e => e.AddToRateYn)
                .HasColumnName("ADD_TO_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Adults).HasColumnName("ADULTS");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.Batchno)
                .HasColumnName("BATCHNO")
                .HasColumnType("NUMBER(12)");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalculationRule)
                .HasColumnName("CALCULATION_RULE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Children).HasColumnName("CHILDREN");

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(100)
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

            entity.Property(e => e.NoOfVouchers)
                .HasColumnName("NO_OF_VOUCHERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PostingRhythm)
                .HasColumnName("POSTING_RHYTHM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrintDate)
                .HasColumnName("PRINT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PrintSeperateYn)
                .HasColumnName("PRINT_SEPERATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PrintTime)
                .HasColumnName("PRINT_TIME")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ProductDesc)
                .HasColumnName("PRODUCT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ProductId)
                .IsRequired()
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProductSource)
                .HasColumnName("PRODUCT_SOURCE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Reprints).HasColumnName("REPRINTS");

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

            entity.Property(e => e.RoomClass)
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNumber)
                .HasColumnName("ROOM_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeperatelySoldYn)
                .HasColumnName("SEPERATELY_SOLD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SerialNo)
                .HasColumnName("SERIAL_NO")
                .HasColumnType("NUMBER(11)");

            entity.Property(e => e.ValidDate)
                .HasColumnName("VALID_DATE")
                .HasColumnType("DATE");
        });
	}
}
