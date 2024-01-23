namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScRoomtypeMapView
{
    public decimal? MapId { get; set; }
    public string Resort { get; set; }
    public string ScRoomCategory { get; set; }
    public string PmsRoomCategory { get; set; }
    public string PmsRoomCatDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string SelectYn { get; set; }
    public string PmsLabel { get; set; }
    public string ScLabel { get; set; }
    public string ShDesc { get; set; }
    public string Status { get; set; }
    public string ScResort { get; set; }
    public string ScReturnCategory { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScRoomtypeMapView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_ROOMTYPE_MAP_VIEW");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MapId)
                .HasColumnName("MAP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PmsLabel)
                .HasColumnName("PMS_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmsRoomCatDesc)
                .HasColumnName("PMS_ROOM_CAT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PmsRoomCategory)
                .HasColumnName("PMS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScLabel)
                .HasColumnName("SC_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScResort)
                .HasColumnName("SC_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScReturnCategory)
                .HasColumnName("SC_RETURN_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ScRoomCategory)
                .HasColumnName("SC_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SelectYn)
                .HasColumnName("SELECT_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.ShDesc)
                .HasColumnName("SH_DESC")
                .HasMaxLength(450)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
