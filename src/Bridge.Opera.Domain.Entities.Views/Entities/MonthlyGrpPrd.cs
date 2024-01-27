namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MonthlyGrpPrd
{
    public decimal? RecordId { get; set; }
    public string Resort { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string FirstStatus { get; set; }
    public DateTime? FirstStatusChgDate { get; set; }
    public decimal? FirstRoomNights { get; set; }
    public decimal? FirstRoomRevenue { get; set; }
    public string FirstFlagNewStatus { get; set; }
    public string SecondStatus { get; set; }
    public DateTime? SecondStatusChgDate { get; set; }
    public decimal? SecondRoomNights { get; set; }
    public decimal? SecondRoomRevenue { get; set; }
    public string SecondFlagNewStatus { get; set; }
    public decimal? VarianceRoomNights { get; set; }
    public decimal? VarianceRoomRevenue { get; set; }
    public string GroupName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MonthlyGrpPrd>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MONTHLY_GRP_PRD");

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstFlagNewStatus)
                .HasColumnName("FIRST_FLAG_NEW_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FirstRoomNights)
                .HasColumnName("FIRST_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstRoomRevenue)
                .HasColumnName("FIRST_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstStatus)
                .HasColumnName("FIRST_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FirstStatusChgDate)
                .HasColumnName("FIRST_STATUS_CHG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RecordId)
                .HasColumnName("RECORD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SecondFlagNewStatus)
                .HasColumnName("SECOND_FLAG_NEW_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SecondRoomNights)
                .HasColumnName("SECOND_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SecondRoomRevenue)
                .HasColumnName("SECOND_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SecondStatus)
                .HasColumnName("SECOND_STATUS")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SecondStatusChgDate)
                .HasColumnName("SECOND_STATUS_CHG_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.VarianceRoomNights)
                .HasColumnName("VARIANCE_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.VarianceRoomRevenue)
                .HasColumnName("VARIANCE_ROOM_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
