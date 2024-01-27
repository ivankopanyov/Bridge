namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RateQueryView
{
    public string RateCode { get; set; }
    public string RateCodeShortDesc { get; set; }
    public string RateCodeLongDesc { get; set; }
    public string RoomCategory { get; set; }
    public string Description { get; set; }
    public string RoomTypeLongDesc { get; set; }
    public string Amount { get; set; }
    public string TotalAmount { get; set; }
    public string CurrencyCode { get; set; }
    public string Available { get; set; }
    public string AvailableLevel { get; set; }
    public string PackageYn { get; set; }
    public string RowColor { get; set; }
    public decimal? RateStatus { get; set; }
    public decimal? RateRoomStatus { get; set; }
    public decimal? Status { get; set; }
    public string ExpandedYn { get; set; }
    public string RateChangeYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RateQueryView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RATE_QUERY_VIEW");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasMaxLength(38)
                .IsUnicode(false);

            entity.Property(e => e.Available)
                .HasColumnName("AVAILABLE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AvailableLevel)
                .HasColumnName("AVAILABLE_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ExpandedYn)
                .HasColumnName("EXPANDED_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.PackageYn)
                .HasColumnName("PACKAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateChangeYn)
                .HasColumnName("RATE_CHANGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeLongDesc)
                .HasColumnName("RATE_CODE_LONG_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateCodeShortDesc)
                .HasColumnName("RATE_CODE_SHORT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RateRoomStatus)
                .HasColumnName("RATE_ROOM_STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateStatus)
                .HasColumnName("RATE_STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomTypeLongDesc)
                .HasColumnName("ROOM_TYPE_LONG_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RowColor)
                .HasColumnName("ROW_COLOR")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalAmount)
                .HasColumnName("TOTAL_AMOUNT")
                .HasMaxLength(38)
                .IsUnicode(false);
        });
	}
}
