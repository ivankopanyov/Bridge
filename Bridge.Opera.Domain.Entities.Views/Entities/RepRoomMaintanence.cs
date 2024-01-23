namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepRoomMaintanence
{
    public string Resort { get; set; }
    public string Room { get; set; }
    public string RoomNo { get; set; }
    public string RoomCategory { get; set; }
    public string RoomStatus { get; set; }
    public string FoStatus { get; set; }
    public string RoomClass { get; set; }
    public string RateCode { get; set; }
    public string MaintenanceCode { get; set; }
    public string MaintanenceDesc { get; set; }
    public string Remarks { get; set; }
    public string ResolvedName { get; set; }
    public string ResolvedDateChar { get; set; }
    public string ResolvedTime { get; set; }
    public DateTime? ResolvedDate { get; set; }
    public string InsertedBy { get; set; }
    public string EnteredDate { get; set; }
    public string EnteredTime { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepRoomMaintanence>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ROOM_MAINTANENCE");

            entity.Property(e => e.EnteredDate)
                .HasColumnName("ENTERED_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.EnteredTime)
                .HasColumnName("ENTERED_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.FoStatus)
                .HasColumnName("FO_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertedBy)
                .HasColumnName("INSERTED_BY")
                .IsUnicode(false);

            entity.Property(e => e.MaintanenceDesc)
                .IsRequired()
                .HasColumnName("MAINTANENCE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MaintenanceCode)
                .IsRequired()
                .HasColumnName("MAINTENANCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Remarks)
                .IsRequired()
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedDate)
                .HasColumnName("RESOLVED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ResolvedDateChar)
                .HasColumnName("RESOLVED_DATE_CHAR")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedName)
                .HasColumnName("RESOLVED_NAME")
                .IsUnicode(false);

            entity.Property(e => e.ResolvedTime)
                .HasColumnName("RESOLVED_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomNo)
                .HasColumnName("ROOM_NO")
                .HasMaxLength(36)
                .IsUnicode(false);

            entity.Property(e => e.RoomStatus)
                .IsRequired()
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
