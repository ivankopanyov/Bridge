namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomRepairs
{
    public string? Resort { get; set; }
    public string? Room { get; set; }
    public decimal? Seq { get; set; }
    public string? RepairType { get; set; }
    public string? ReasonCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? RoomStatus { get; set; }
    public DateTime? CompletedDate { get; set; }
    public string? ReturnStatus { get; set; }
    public string? RepairRemarks { get; set; }
    public string? CalculateRotationYn { get; set; }

    public virtual ResortRoomStatusReason Re { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomRepairs>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Room, e.Seq })
                .HasName("ROOM_REPAIRS_PK");

            entity.ToTable("ROOM_REPAIRS");

            entity.HasIndex(e => new { e.BeginDate, e.EndDate })
                .HasName("ROOM_REPAIRS_DATES_IDX");

            entity.HasIndex(e => new { e.ReasonCode, e.Resort })
                .HasName("ROOM_REPAIRS_REASON_FK_IDX");

            entity.HasIndex(e => new { e.Resort, e.Room, e.BeginDate, e.EndDate, e.RoomStatus })
                .HasName("ROOM_REPAIRS_RSRMDTST_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Seq)
                .HasColumnName("SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CalculateRotationYn)
                .HasColumnName("CALCULATE_ROTATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CompletedDate)
                .HasColumnName("COMPLETED_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReasonCode)
                .IsRequired()
                .HasColumnName("REASON_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RepairRemarks)
                .HasColumnName("REPAIR_REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RepairType)
                .IsRequired()
                .HasColumnName("REPAIR_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ReturnStatus)
                .IsRequired()
                .HasColumnName("RETURN_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomStatus)
                .IsRequired()
                .HasColumnName("ROOM_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(ResortRoomStatusReason)))
				entity.Ignore(e => e.Re);
			else
	            entity.HasOne(d => d.Re)
	                .WithMany(p => p.RoomRepairs)
	                .HasPrincipalKey(p => new { p.ReasonCode, p.Resort })
	                .HasForeignKey(d => new { d.ReasonCode, d.Resort })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ROOM_REPAIRS_REASON_FK");
        });
	}
}
