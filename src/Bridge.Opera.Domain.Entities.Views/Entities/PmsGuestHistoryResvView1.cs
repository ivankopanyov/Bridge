namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class PmsGuestHistoryResvView1
{
    public string? NameType { get; set; }
    public string? Resort { get; set; }
    public string? FSource { get; set; }
    public string? MarketCode { get; set; }
    public decimal? ResvNo { get; set; }
    public string? FReservationtype { get; set; }
    public string? FResort { get; set; }
    public string? FRate { get; set; }
    public decimal? FRateAmt { get; set; }
    public string? FRoom { get; set; }
    public string? BlockCode { get; set; }
    public string? RoomType { get; set; }
    public decimal? FPrice { get; set; }
    public decimal? FAdults { get; set; }
    public decimal? FChildren { get; set; }
    public decimal? FNoofrooms { get; set; }
    public DateTime? ReserveBeginDate { get; set; }
    public DateTime? FArrival { get; set; }
    public DateTime? FDeparture { get; set; }
    public string? FGuestName { get; set; }
    public decimal? NameId { get; set; }
    public decimal? FGuestId { get; set; }
    public string? FAgent { get; set; }
    public string? FGroup { get; set; }
    public string? FSourcename { get; set; }
    public string? FCompany { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal? RoomRevenue { get; set; }
    public decimal? FbRevenue { get; set; }
    public decimal? OtherRevenue { get; set; }
    public decimal? NoOfRooms { get; set; }
    public DateTime? ActualCheckOutDate { get; set; }
    public string? ResvStatus { get; set; }
    public string? ModifyYn { get; set; }
    public decimal? ResvContactId { get; set; }
    public string? ResvContactName { get; set; }
    public decimal? NonRevenue { get; set; }
    public string? RecType { get; set; }
    public string? CheckedInYn { get; set; }
    public decimal? IsPrimaryFlag { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? FolioNo { get; set; }
    public decimal? BillNo { get; set; }
    public string? FolioType { get; set; }
    public decimal? InvoiceNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsGuestHistoryResvView1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PMS_GUEST_HISTORY_RESV_VIEW1");

            entity.Property(e => e.ActualCheckOutDate)
                .HasColumnName("ACTUAL_CHECK_OUT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillNo)
                .HasColumnName("BILL_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CheckedInYn)
                .HasColumnName("CHECKED_IN_YN")
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

            entity.Property(e => e.FDeparture)
                .HasColumnName("F_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.FGroup)
                .HasColumnName("F_GROUP")
                .IsUnicode(false);

            entity.Property(e => e.FGuestId)
                .HasColumnName("F_GUEST_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.FRateAmt)
                .HasColumnName("F_RATE_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FReservationtype)
                .HasColumnName("F_RESERVATIONTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FResort)
                .HasColumnName("F_RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FRoom)
                .HasColumnName("F_ROOM")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FSource)
                .HasColumnName("F_SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FSourcename)
                .HasColumnName("F_SOURCENAME")
                .IsUnicode(false);

            entity.Property(e => e.FbRevenue)
                .HasColumnName("FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioNo)
                .HasColumnName("FOLIO_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioType)
                .HasColumnName("FOLIO_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvoiceNo)
                .HasColumnName("INVOICE_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IsPrimaryFlag)
                .HasColumnName("IS_PRIMARY_FLAG")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModifyYn)
                .HasColumnName("MODIFY_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.NoOfRooms)
                .HasColumnName("NO_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NonRevenue)
                .HasColumnName("NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OtherRevenue)
                .HasColumnName("OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RecType)
                .HasColumnName("REC_TYPE")
                .HasMaxLength(19)
                .IsUnicode(false);

            entity.Property(e => e.ReserveBeginDate)
                .HasColumnName("RESERVE_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ResvContactId)
                .HasColumnName("RESV_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvContactName)
                .HasColumnName("RESV_CONTACT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ResvNo)
                .HasColumnName("RESV_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomRevenue)
                .HasColumnName("ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
