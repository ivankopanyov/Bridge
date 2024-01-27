namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ResortProfileStatDailyView
{
    public string Resort { get; set; }
    public DateTime StatDate { get; set; }
    public decimal? InternalPrefCount { get; set; }
    public decimal? GlobalPrefCount { get; set; }
    public decimal? InternalNotesCount { get; set; }
    public decimal? InteralNotesRejectedCount { get; set; }
    public decimal? GlobalNotesCount { get; set; }
    public decimal? InternalNotesAutoRejCount { get; set; }
    public decimal? InhouseRoomsCount { get; set; }
    public decimal? ArrivalRoomsCount { get; set; }
    public decimal? DepartureRoomsCount { get; set; }
    public decimal? FirstTimeGuestCount { get; set; }
    public decimal? ResvCreatedCount { get; set; }
    public decimal? InternalNotesSCount { get; set; }
    public DateTime? LastTransferedDate { get; set; }
    public string TransferredFlgYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortProfileStatDailyView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("RESORT_PROFILE_STAT_DAILY_VIEW");

            entity.Property(e => e.ArrivalRoomsCount)
                .HasColumnName("ARRIVAL_ROOMS_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepartureRoomsCount)
                .HasColumnName("DEPARTURE_ROOMS_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstTimeGuestCount)
                .HasColumnName("FIRST_TIME_GUEST_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GlobalNotesCount)
                .HasColumnName("GLOBAL_NOTES_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GlobalPrefCount)
                .HasColumnName("GLOBAL_PREF_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InhouseRoomsCount)
                .HasColumnName("INHOUSE_ROOMS_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InteralNotesRejectedCount)
                .HasColumnName("INTERAL_NOTES_REJECTED_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalNotesAutoRejCount)
                .HasColumnName("INTERNAL_NOTES_AUTO_REJ_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalNotesCount)
                .HasColumnName("INTERNAL_NOTES_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalNotesSCount)
                .HasColumnName("INTERNAL_NOTES_S_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InternalPrefCount)
                .HasColumnName("INTERNAL_PREF_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastTransferedDate)
                .HasColumnName("LAST_TRANSFERED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvCreatedCount)
                .HasColumnName("RESV_CREATED_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatDate)
                .HasColumnName("STAT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TransferredFlgYn)
                .HasColumnName("TRANSFERRED_FLG_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
