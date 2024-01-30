namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsConvRateRooms
{
    public string? GdsHost { get; set; }
    public string? Resort { get; set; }
    public string? RateCode { get; set; }
    public string? GdsRateCode { get; set; }
    public string? RoomCategory { get; set; }
    public string? GdsRoomCategory { get; set; }
    public DateTime? BeginDate { get; set; }
    public decimal? GdsRateCodeOrder { get; set; }
    public string? RateUpdateStatus { get; set; }
    public DateTime? LastRateUpdateDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? ShadowBeginDate { get; set; }
    public string? Shadow { get; set; }
    public decimal? GdsRoomOrder { get; set; }
    public string? ActivateYn { get; set; }
    public string? AvailabilityUpdateYn { get; set; }
    public string? RateRoomGdsYn { get; set; }
    public string? PublicYn { get; set; }
    public string? BbarYn { get; set; }
    public string? DisplayRegionalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsConvRateRooms>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.GdsHost, e.PublicYn, e.BeginDate, e.EndDate, e.RateCode, e.GdsRateCode, e.RoomCategory })
                .HasName("GDS_CONV_RATE_ROOMS_PK");

            entity.ToTable("GDS_CONV_RATE_ROOMS");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.GdsRateCode, e.GdsRoomCategory })
                .HasName("GDS_CONV_RATE_ROOM_IND1");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.RateCode, e.RoomCategory })
                .HasName("GDS_CONV_RATE_ROOM_IND2");

            entity.HasIndex(e => new { e.GdsHost, e.Resort, e.BbarYn, e.RateCode, e.RoomCategory })
                .HasName("GDS_CONV_RATE_ROOM_IND3");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PublicYn)
                .HasColumnName("PUBLIC_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRateCode)
                .HasColumnName("GDS_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoomCategory)
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ActivateYn)
                .HasColumnName("ACTIVATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'Y'");

            entity.Property(e => e.AvailabilityUpdateYn)
                .HasColumnName("AVAILABILITY_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.BbarYn)
                .HasColumnName("BBAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DisplayRegionalYn)
                .HasColumnName("DISPLAY_REGIONAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRateCodeOrder)
                .HasColumnName("GDS_RATE_CODE_ORDER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRoomCategory)
                .IsRequired()
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRoomOrder)
                .HasColumnName("GDS_ROOM_ORDER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastRateUpdateDate)
                .HasColumnName("LAST_RATE_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RateRoomGdsYn)
                .HasColumnName("RATE_ROOM_GDS_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.RateUpdateStatus)
                .HasColumnName("RATE_UPDATE_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.Shadow)
                .HasColumnName("SHADOW")
                .HasMaxLength(650)
                .IsUnicode(false);

            entity.Property(e => e.ShadowBeginDate)
                .HasColumnName("SHADOW_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
