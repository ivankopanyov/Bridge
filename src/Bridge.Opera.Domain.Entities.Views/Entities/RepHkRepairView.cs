namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepHkRepairView
{
    public string Resort { get; set; }
    public string Room { get; set; }
    public string RoomNo { get; set; }
    public string RoomDesc { get; set; }
    public string RoomCategory { get; set; }
    public string RoomStatus { get; set; }
    public string ReturnStatus { get; set; }
    public string ReasonCode { get; set; }
    public string ReasonDesc { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string RepairRemarks { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string RepairType { get; set; }
    public string RoomClass { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepHkRepairView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_HK_REPAIR_VIEW");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CompletedDate)
                .HasColumnName("COMPLETED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReasonCode)
                .IsRequired()
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReasonDesc)
                .IsRequired()
                .HasColumnName("REASON_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RepairRemarks)
                .HasColumnName("REPAIR_REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RepairType)
                .IsRequired()
                .HasColumnName("REPAIR_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReturnStatus)
                .IsRequired()
                .HasColumnName("RETURN_STATUS")
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

            entity.Property(e => e.RoomDesc)
                .HasColumnName("ROOM_DESC")
                .HasMaxLength(2000)
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
