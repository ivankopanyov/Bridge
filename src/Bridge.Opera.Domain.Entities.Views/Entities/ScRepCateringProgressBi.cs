namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScRepCateringProgressBi
{
    public decimal? ReportId { get; set; }
    public string RtRowid { get; set; }
    public string Resort { get; set; }
    public string EvResort { get; set; }
    public decimal? BookId { get; set; }
    public string BookingStatus { get; set; }
    public string IsThisLastYearYn { get; set; }
    public decimal? EventId { get; set; }
    public string EvType { get; set; }
    public string MealType { get; set; }
    public string MarketCode { get; set; }
    public string CateringOnlyYn { get; set; }
    public DateTime? EventDate { get; set; }
    public string CurrentStatus { get; set; }
    public string NewCurrentStatus { get; set; }
    public DateTime? EventStatusChangeDate { get; set; }
    public string RevenueType { get; set; }
    public decimal? RevenueChanges { get; set; }
    public decimal? Attendees { get; set; }
    public decimal? NewDefRevenue { get; set; }
    public decimal? NewDefCovers { get; set; }
    public decimal? SlippageRevenue { get; set; }
    public decimal? SlippageCovers { get; set; }
    public decimal? RevalRevenue { get; set; }
    public decimal? CancelRevenue { get; set; }
    public decimal? CancelCovers { get; set; }
    public decimal? BudgetCovers { get; set; }
    public decimal? RoomNights { get; set; }
    public decimal? RevenueChangesSameTimeLast { get; set; }
    public decimal? AttendeesSameTimeLast { get; set; }
    public decimal? Owner { get; set; }
    public decimal? RmsOwner { get; set; }
    public decimal? CatOwner { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScRepCateringProgressBi>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_REP_CATERING_PROGRESS_BI");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AttendeesSameTimeLast)
                .HasColumnName("ATTENDEES_SAME_TIME_LAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingStatus)
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BudgetCovers)
                .HasColumnName("BUDGET_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelCovers)
                .HasColumnName("CANCEL_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelRevenue)
                .HasColumnName("CANCEL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatOwner)
                .HasColumnName("CAT_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CateringOnlyYn)
                .HasColumnName("CATERING_ONLY_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrentStatus)
                .HasColumnName("CURRENT_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EvResort)
                .HasColumnName("EV_RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EvType)
                .HasColumnName("EV_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EventStatusChangeDate)
                .HasColumnName("EVENT_STATUS_CHANGE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IsThisLastYearYn)
                .HasColumnName("IS_THIS_LAST_YEAR_YN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MealType)
                .HasColumnName("MEAL_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NewCurrentStatus)
                .HasColumnName("NEW_CURRENT_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NewDefCovers)
                .HasColumnName("NEW_DEF_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NewDefRevenue)
                .HasColumnName("NEW_DEF_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportId)
                .HasColumnName("REPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RevalRevenue)
                .HasColumnName("REVAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueChanges)
                .HasColumnName("REVENUE_CHANGES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueChangesSameTimeLast)
                .HasColumnName("REVENUE_CHANGES_SAME_TIME_LAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevenueType)
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwner)
                .HasColumnName("RMS_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RtRowid)
                .HasColumnName("RT_ROWID")
                .HasColumnType("ROWID");

            entity.Property(e => e.SlippageCovers)
                .HasColumnName("SLIPPAGE_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SlippageRevenue)
                .HasColumnName("SLIPPAGE_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
