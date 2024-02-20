namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestRsvMessages
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? Msgid { get; set; }
    public string? Recipient { get; set; }
    public string? StatusFlag { get; set; }
    public DateTime? StatusDate { get; set; }
    public string? ReceivedBy { get; set; }
    public string? Description { get; set; }
    public string? PrintedStatus { get; set; }
    public DateTime? PrintedDate { get; set; }
    public DateTime? SmsSentOn { get; set; }
    public string? SmsSentBy { get; set; }
    public string? SentToRoomYn { get; set; }

    public virtual GuestMessages Msg { get; set; }
    public virtual ReservationName Res { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestRsvMessages>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.Msgid })
                .HasName("GUEST_RESERVATION_PK");

            entity.ToTable("GUEST_RSV_MESSAGES");

            entity.HasIndex(e => new { e.Msgid, e.ResvNameId })
                .HasName("GUEST_RSV_MSGS_IDX");

            entity.HasIndex(e => new { e.Resort, e.StatusFlag })
                .HasName("GUEST_RSV_MSGS_RES_STAT_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Msgid)
                .HasColumnName("MSGID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrintedDate)
                .HasColumnName("PRINTED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PrintedStatus)
                .HasColumnName("PRINTED_STATUS")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReceivedBy)
                .HasColumnName("RECEIVED_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Recipient)
                .HasColumnName("RECIPIENT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.SentToRoomYn)
                .HasColumnName("SENT_TO_ROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SmsSentBy)
                .HasColumnName("SMS_SENT_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SmsSentOn)
                .HasColumnName("SMS_SENT_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.StatusDate)
                .HasColumnName("STATUS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StatusFlag)
                .IsRequired()
                .HasColumnName("STATUS_FLAG")
                .HasMaxLength(2)
                .IsUnicode(false);

			if (!types.Contains(typeof(GuestMessages)))
				entity.Ignore(e => e.Msg);
			else
	            entity.HasOne(d => d.Msg)
	                .WithMany(p => p.GuestRsvMessages)
	                .HasForeignKey(d => d.Msgid)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GST_RSVT_FK_MSG");

			if (!types.Contains(typeof(ReservationName)))
				entity.Ignore(e => e.Res);
			else
	            entity.HasOne(d => d.Res)
	                .WithMany(p => p.GuestRsvMessages)
	                .HasForeignKey(d => new { d.Resort, d.ResvNameId })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("GST_RSVT_FK_RSVT_NAME");
        });
	}
}
