namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationRoomMoves
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? OldRoom { get; set; }
    public string? NewRoom { get; set; }
    public string? MoveReasonCode { get; set; }
    public string? MoveReasonDesc { get; set; }
    public string? MoveType { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationRoomMoves>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RESERVATION_ROOM_MOVES");

            entity.HasIndex(e => new { e.Resort, e.BusinessDate })
                .HasName("RESVRMMOVE_DATE_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId })
                .HasName("RESVRMMOVE_ID_IDX");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MoveReasonCode)
                .HasColumnName("MOVE_REASON_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MoveReasonDesc)
                .HasColumnName("MOVE_REASON_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MoveType)
                .HasColumnName("MOVE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NewRoom)
                .IsRequired()
                .HasColumnName("NEW_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OldRoom)
                .IsRequired()
                .HasColumnName("OLD_ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
