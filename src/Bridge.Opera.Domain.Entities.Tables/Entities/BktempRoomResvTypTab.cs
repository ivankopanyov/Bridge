namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BktempRoomResvTypTab
{
    public decimal? Keynumber { get; set; }
    public string? SummaryType { get; set; }
    public string? Chain { get; set; }
    public string? Resort { get; set; }
    public string? PmsStatus { get; set; }
    public string? PmsTimeUnitType { get; set; }
    public DateTime? PmsStartTime { get; set; }
    public decimal? PmsNumberOfTimeUnits { get; set; }
    public string? PmsPmsId { get; set; }
    public string? PmsCrsId { get; set; }
    public string? PmsRoomType { get; set; }
    public decimal? PmsNumberOfRooms { get; set; }
    public string? CrsStatus { get; set; }
    public string? CrsTimeUnitType { get; set; }
    public DateTime? CrsStartTime { get; set; }
    public decimal? CrsNumberOfTimeUnits { get; set; }
    public string? CrsPmsId { get; set; }
    public string? CrsCrsId { get; set; }
    public string? CrsRoomType { get; set; }
    public decimal? CrsNumberOfRooms { get; set; }
    public string? RoomTypeShortDesc { get; set; }
    public decimal? RequestId { get; set; }
    public string? CrsShareNo { get; set; }
    public string? CrsDeductInventory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BktempRoomResvTypTab>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BKTEMP_ROOM_RESV_TYP_TAB");

            entity.HasIndex(e => e.RequestId)
                .HasName("RESV_TAB_REQ_ID");

            entity.Property(e => e.Chain)
                .HasColumnName("CHAIN")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CrsCrsId)
                .HasColumnName("CRS_CRS_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CrsDeductInventory)
                .HasColumnName("CRS_DEDUCT_INVENTORY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CrsNumberOfRooms)
                .HasColumnName("CRS_NUMBER_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsNumberOfTimeUnits)
                .HasColumnName("CRS_NUMBER_OF_TIME_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CrsPmsId)
                .HasColumnName("CRS_PMS_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CrsRoomType)
                .HasColumnName("CRS_ROOM_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CrsShareNo)
                .HasColumnName("CRS_SHARE_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CrsStartTime)
                .HasColumnName("CRS_START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.CrsStatus)
                .HasColumnName("CRS_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CrsTimeUnitType)
                .HasColumnName("CRS_TIME_UNIT_TYPE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.Keynumber)
                .HasColumnName("KEYNUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsCrsId)
                .HasColumnName("PMS_CRS_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PmsNumberOfRooms)
                .HasColumnName("PMS_NUMBER_OF_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsNumberOfTimeUnits)
                .HasColumnName("PMS_NUMBER_OF_TIME_UNITS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsPmsId)
                .HasColumnName("PMS_PMS_ID")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PmsRoomType)
                .HasColumnName("PMS_ROOM_TYPE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PmsStartTime)
                .HasColumnName("PMS_START_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.PmsStatus)
                .HasColumnName("PMS_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsTimeUnitType)
                .HasColumnName("PMS_TIME_UNIT_TYPE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomTypeShortDesc)
                .HasColumnName("ROOM_TYPE_SHORT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SummaryType)
                .HasColumnName("SUMMARY_TYPE")
                .HasMaxLength(8)
                .IsUnicode(false);
        });
	}
}
