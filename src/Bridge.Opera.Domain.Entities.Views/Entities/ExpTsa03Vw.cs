namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpTsa03Vw
{
    public string? BusinessDate { get; set; }
    public string? Resort { get; set; }
    public string? Name { get; set; }
    public string? RoomType { get; set; }
    public string? RoomTypeDesc { get; set; }
    public string? RoomClass { get; set; }
    public string? RoomClassDesc { get; set; }
    public decimal? ExistingRoom { get; set; }
    public decimal? OoRoom { get; set; }
    public decimal? OsRoom { get; set; }
    public decimal? NoOfDefiniteRoom { get; set; }
    public decimal? NoOfGuests { get; set; }
    public decimal? DayUseRoom { get; set; }
    public decimal? NoShowRoom { get; set; }
    public decimal? TotalRoomRevenue { get; set; }
    public decimal? TotalFbRevenue { get; set; }
    public decimal? TotalOtherRevenue { get; set; }
    public decimal? TotalPackageRevenue { get; set; }
    public decimal? TotalPackageRoomRevenue { get; set; }
    public decimal? TotalPackageFbRevenue { get; set; }
    public decimal? TotalPackageOtherRevenue { get; set; }
    public decimal? TotalPackageNonRevenue { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpTsa03Vw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_TSA03_VW");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.DayUseRoom)
                .HasColumnName("DAY_USE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ExistingRoom)
                .HasColumnName("EXISTING_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NoOfDefiniteRoom)
                .HasColumnName("NO_OF_DEFINITE_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfGuests)
                .HasColumnName("NO_OF_GUESTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoShowRoom)
                .HasColumnName("NO_SHOW_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OoRoom)
                .HasColumnName("OO_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OsRoom)
                .HasColumnName("OS_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClass)
                .IsRequired()
                .HasColumnName("ROOM_CLASS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomClassDesc)
                .HasColumnName("ROOM_CLASS_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .HasColumnName("ROOM_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.RoomTypeDesc)
                .HasColumnName("ROOM_TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TotalFbRevenue)
                .HasColumnName("TOTAL_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalOtherRevenue)
                .HasColumnName("TOTAL_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPackageFbRevenue)
                .HasColumnName("TOTAL_PACKAGE_FB_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPackageNonRevenue)
                .HasColumnName("TOTAL_PACKAGE_NON_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPackageOtherRevenue)
                .HasColumnName("TOTAL_PACKAGE_OTHER_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPackageRevenue)
                .HasColumnName("TOTAL_PACKAGE_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalPackageRoomRevenue)
                .HasColumnName("TOTAL_PACKAGE_ROOM_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRoomRevenue)
                .HasColumnName("TOTAL_ROOM_REVENUE")
                .HasColumnType("NUMBER");
        });
	}
}
