namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RoomCategoryTemplate
{
    public string RoomCategory { get; set; }
    public string RoomClass { get; set; }
    public decimal NumberRooms { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public string Compiled { get; set; }
    public string PsuedoRoomType { get; set; }
    public DateTime? ActiveDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string ReplacesCategory { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? MaxRollaways { get; set; }
    public string RateCategory { get; set; }
    public string GenericFlag { get; set; }
    public string SuiteYn { get; set; }
    public string Label { get; set; }
    public string MeetingroomYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string RateCode { get; set; }
    public decimal? MaxOccupancy { get; set; }
    public decimal? RateAmount { get; set; }
    public decimal? DefOccupancy { get; set; }
    public decimal? ImageId { get; set; }
    public string PseudoYn { get; set; }
    public string SendToInterfaceYn { get; set; }
    public string YieldableYn { get; set; }
    public string YieldCategory { get; set; }
    public string Housekeeping { get; set; }
    public string CanDeleteYn { get; set; }
    public string RoominfoUrl { get; set; }
    public string OwnerYn { get; set; }
    public decimal? InitialRoundUp { get; set; }
    public decimal? Increments { get; set; }
    public string ChainCode { get; set; }
    public decimal? MaxOccupancyAdults { get; set; }
    public decimal? MaxOccupancyChildren { get; set; }
    public decimal? MaxFixBedOccupancy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RoomCategoryTemplate>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ROOM_CATEGORY_TEMPLATE");

            entity.HasIndex(e => new { e.ChainCode, e.Label })
                .HasName("ROOM_CATEGORY_TEMPLATE_UK")
                .IsUnique();

            entity.Property(e => e.ActiveDate)
                .HasColumnName("ACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Compiled)
                .HasColumnName("COMPILED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DefOccupancy)
                .HasColumnName("DEF_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GenericFlag)
                .HasColumnName("GENERIC_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Housekeeping)
                .HasColumnName("HOUSEKEEPING")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ImageId)
                .HasColumnName("IMAGE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Increments)
                .HasColumnName("INCREMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InitialRoundUp)
                .HasColumnName("INITIAL_ROUND_UP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MaxFixBedOccupancy)
                .HasColumnName("MAX_FIX_BED_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancyAdults)
                .HasColumnName("MAX_OCCUPANCY_ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancyChildren)
                .HasColumnName("MAX_OCCUPANCY_CHILDREN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxRollaways)
                .HasColumnName("MAX_ROLLAWAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MeetingroomYn)
                .HasColumnName("MEETINGROOM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.NumberRooms)
                .HasColumnName("NUMBER_ROOMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerYn)
                .HasColumnName("OWNER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PseudoYn)
                .HasColumnName("PSEUDO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PsuedoRoomType)
                .HasColumnName("PSUEDO_ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateAmount)
                .HasColumnName("RATE_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCategory)
                .HasColumnName("RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReplacesCategory)
                .HasColumnName("REPLACES_CATEGORY")
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

            entity.Property(e => e.RoominfoUrl)
                .HasColumnName("ROOMINFO_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SendToInterfaceYn)
                .HasColumnName("SEND_TO_INTERFACE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SuiteYn)
                .HasColumnName("SUITE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldableYn)
                .HasColumnName("YIELDABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
