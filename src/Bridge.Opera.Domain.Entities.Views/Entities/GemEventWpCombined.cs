namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemEventWpCombined
{
    public string Resort { get; set; }
    public decimal? BookId { get; set; }
    public string EventId { get; set; }
    public decimal? FirstEventId { get; set; }
    public decimal? CountEventIds { get; set; }
    public string EvType { get; set; }
    public string EvTypeDescription { get; set; }
    public string EvName { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? Attendees { get; set; }
    public string Room { get; set; }
    public string RoomSetup { get; set; }
    public decimal? SetupTime { get; set; }
    public decimal? SetdownTime { get; set; }
    public decimal? PkgId { get; set; }
    public string EvResort { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? SumRateAmount { get; set; }
    public decimal? RateAmount { get; set; }
    public string Ratecode { get; set; }
    public string ResvNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemEventWpCombined>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_EVENT_WP_COMBINED");

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookId)
                .HasColumnName("BOOK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CountEventIds)
                .HasColumnName("COUNT_EVENT_IDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EvName)
                .HasColumnName("EV_NAME")
                .IsUnicode(false);

            entity.Property(e => e.EvResort)
                .HasColumnName("EV_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EvType)
                .HasColumnName("EV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EvTypeDescription)
                .HasColumnName("EV_TYPE_DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EventId)
                .HasColumnName("EVENT_ID")
                .IsUnicode(false);

            entity.Property(e => e.FirstEventId)
                .HasColumnName("FIRST_EVENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ratecode)
                .HasColumnName("RATECODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .IsUnicode(false);

            entity.Property(e => e.RoomSetup)
                .HasColumnName("ROOM_SETUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SetdownTime)
                .HasColumnName("SETDOWN_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SetupTime)
                .HasColumnName("SETUP_TIME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SumRateAmount)
                .HasColumnName("SUM_RATE_AMOUNT")
                .HasColumnType("NUMBER");
        });
	}
}
