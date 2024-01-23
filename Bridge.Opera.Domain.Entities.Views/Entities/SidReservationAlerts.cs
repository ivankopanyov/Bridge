namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidReservationAlerts
{
    public decimal ResvAlertId { get; set; }
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public string Area { get; set; }
    public string AlertCode { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string MembershipCardNo { get; set; }
    public string ValueRating { get; set; }
    public string VipStatus { get; set; }
    public string Language { get; set; }
    public decimal? BrandStayCnt { get; set; }
    public decimal? PropertyStayCnt { get; set; }
    public string LastStayLocation { get; set; }
    public DateTime? LastStayDate { get; set; }
    public string Comments { get; set; }
    public string Pref1 { get; set; }
    public string Pref2 { get; set; }
    public string Pref3 { get; set; }
    public string QueryId { get; set; }
    public string ScreenYn { get; set; }
    public string PrinterYn { get; set; }
    public string ReportName { get; set; }
    public string PrinterName { get; set; }
    public DateTime? PropertyStayDate { get; set; }
    public string HasTagsYn { get; set; }
    public string MembershipAlertYn { get; set; }
    public string AlertText { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidReservationAlerts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_RESERVATION_ALERTS");

            entity.Property(e => e.AlertCode)
                .IsRequired()
                .HasColumnName("ALERT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlertText)
                .HasColumnName("ALERT_TEXT")
                .IsUnicode(false);

            entity.Property(e => e.Area)
                .IsRequired()
                .HasColumnName("AREA")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BrandStayCnt)
                .HasColumnName("BRAND_STAY_CNT")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.HasTagsYn)
                .HasColumnName("HAS_TAGS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Language)
                .HasColumnName("LANGUAGE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LastStayDate)
                .HasColumnName("LAST_STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LastStayLocation)
                .HasColumnName("LAST_STAY_LOCATION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MembershipAlertYn)
                .HasColumnName("MEMBERSHIP_ALERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.Pref1)
                .HasColumnName("PREF_1")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Pref2)
                .HasColumnName("PREF_2")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Pref3)
                .HasColumnName("PREF_3")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PrinterName)
                .HasColumnName("PRINTER_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PrinterYn)
                .HasColumnName("PRINTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PropertyStayCnt)
                .HasColumnName("PROPERTY_STAY_CNT")
                .HasColumnType("NUMBER(38)");

            entity.Property(e => e.PropertyStayDate)
                .HasColumnName("PROPERTY_STAY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .IsUnicode(false);

            entity.Property(e => e.ReportName)
                .HasColumnName("REPORT_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvAlertId)
                .HasColumnName("RESV_ALERT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ScreenYn)
                .HasColumnName("SCREEN_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ValueRating)
                .HasColumnName("VALUE_RATING")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.VipStatus)
                .HasColumnName("VIP_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
