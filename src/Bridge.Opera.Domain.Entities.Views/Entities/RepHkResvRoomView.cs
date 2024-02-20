namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepHkResvRoomView
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? ComputedResvStatus { get; set; }
    public string? ResvStatus { get; set; }
    public decimal? SeqNo { get; set; }
    public string? Arrival { get; set; }
    public string? ArrivalTime { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Departure { get; set; }
    public string? FullName { get; set; }
    public string? GuestName { get; set; }
    public string? Comments { get; set; }
    public string? RoomCategory { get; set; }
    public string? RoomCategoryLabel { get; set; }
    public string? RoomNo { get; set; }
    public string? Room { get; set; }
    public decimal? CompanyId { get; set; }
    public string? CompanyName { get; set; }
    public string? GroupName { get; set; }
    public decimal? Persons { get; set; }
    public string? Vip { get; set; }
    public DateTime? TruncBegin { get; set; }
    public DateTime? TruncEnd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepHkResvRoomView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_HK_RESV_ROOM_VIEW");

            entity.Property(e => e.Arrival)
                .HasColumnName("ARRIVAL")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ArrivalTime)
                .HasColumnName("ARRIVAL_TIME")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ComputedResvStatus)
                .HasColumnName("COMPUTED_RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Departure)
                .HasColumnName("DEPARTURE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .HasMaxLength(163)
                .IsUnicode(false);

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .IsUnicode(false);

            entity.Property(e => e.GuestName)
                .HasColumnName("GUEST_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Persons)
                .HasColumnName("PERSONS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategoryLabel)
                .HasColumnName("ROOM_CATEGORY_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TruncBegin)
                .HasColumnName("TRUNC_BEGIN")
                .HasColumnType("DATE");

            entity.Property(e => e.TruncEnd)
                .HasColumnName("TRUNC_END")
                .HasColumnType("DATE");

            entity.Property(e => e.Vip)
                .HasColumnName("VIP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
