namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ReservationExtensions
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? RoomNo { get; set; }
    public string? ExtnNumber { get; set; }
    public string? ExtnType { get; set; }
    public string? InactiveYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? ReservationExtnId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReservationExtensions>(entity =>
        {
            entity.HasKey(e => e.ReservationExtnId)
                .HasName("RESERVATION_EXT_PK");

            entity.ToTable("RESERVATION_EXTENSIONS");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.RoomNo, e.ExtnNumber, e.ExtnType })
                .HasName("RESV_EXTN_UK")
                .IsUnique();

            entity.Property(e => e.ReservationExtnId)
                .HasColumnName("RESERVATION_EXTN_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExtnNumber)
                .IsRequired()
                .HasColumnName("EXTN_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExtnType)
                .HasColumnName("EXTN_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveYn)
                .HasColumnName("INACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNo)
                .IsRequired()
                .HasColumnName("ROOM_NO")
                .HasMaxLength(20)
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
