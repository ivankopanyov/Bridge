namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsInventoryMessage
{
    public string EchoToken { get; set; }
    public string GdsHost { get; set; }
    public string Resort { get; set; }
    public string ChainCode { get; set; }
    public DateTime BeginDate { get; set; }
    public string RoomCategory { get; set; }
    public decimal? PropRoomAvail { get; set; }
    public decimal? RoomAvail { get; set; }
    public string BlockCode { get; set; }
    public string Status { get; set; }
    public string ErrorText { get; set; }
    public string Source { get; set; }
    public decimal? RetryCount { get; set; }
    public string ErrorCode { get; set; }
    public string SubCode { get; set; }
    public string OldEchoToken { get; set; }
    public string ResendYn { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal? ResendCount { get; set; }
    public decimal BooklimitSeqId { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? BlockAvail { get; set; }
    public string BookinglimitType { get; set; }
    public string ResyncYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsInventoryMessage>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.Resort, e.RoomCategory, e.BeginDate, e.EchoToken, e.BookinglimitType })
                .HasName("GDS_INVENTORY_MESSAGE_PK");

            entity.ToTable("GDS_INVENTORY_MESSAGE");

            entity.HasIndex(e => e.EchoToken)
                .HasName("GDS_INVENTORY_MESSAGE_IND1");

            entity.HasIndex(e => new { e.Status, e.BooklimitSeqId })
                .HasName("GDS_INVENTORY_MESSAGE_IND2");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EchoToken)
                .HasColumnName("ECHO_TOKEN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookinglimitType)
                .HasColumnName("BOOKINGLIMIT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BlockAvail)
                .HasColumnName("BLOCK_AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlockCode)
                .HasColumnName("BLOCK_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BooklimitSeqId)
                .HasColumnName("BOOKLIMIT_SEQ_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorCode)
                .HasColumnName("ERROR_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ErrorText)
                .HasColumnName("ERROR_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("TIMESTAMP(2)");

            entity.Property(e => e.OldEchoToken)
                .HasColumnName("OLD_ECHO_TOKEN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PropRoomAvail)
                .HasColumnName("PROP_ROOM_AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResendCount)
                .HasColumnName("RESEND_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResendYn)
                .HasColumnName("RESEND_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResyncYn)
                .HasColumnName("RESYNC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RetryCount)
                .HasColumnName("RETRY_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomAvail)
                .HasColumnName("ROOM_AVAIL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SubCode)
                .HasColumnName("SUB_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("TIMESTAMP(2)");
        });
	}
}
