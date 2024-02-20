namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipAlerts
{
    public decimal? ResvAlertId { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? Area { get; set; }
    public string? AlertCode { get; set; }
    public string? Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? MembershipCardNo { get; set; }
    public decimal? QueryId { get; set; }
    public string? ScreenYn { get; set; }
    public string? PrinterYn { get; set; }
    public string? HasTagsYn { get; set; }
    public string? MembershipAlertYn { get; set; }
    public decimal? OrderBy { get; set; }
    public string? AlertText { get; set; }
    public string? SkipGuestOverviewYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipAlerts>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIP_ALERTS");

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

            entity.Property(e => e.MembershipAlertYn)
                .HasColumnName("MEMBERSHIP_ALERT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipCardNo)
                .HasColumnName("MEMBERSHIP_CARD_NO")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrinterYn)
                .HasColumnName("PRINTER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.QueryId)
                .HasColumnName("QUERY_ID")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.SkipGuestOverviewYn)
                .HasColumnName("SKIP_GUEST_OVERVIEW_YN")
                .HasMaxLength(1)
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
