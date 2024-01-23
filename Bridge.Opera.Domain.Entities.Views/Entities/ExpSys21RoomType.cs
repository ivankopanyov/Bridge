namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpSys21RoomType
{
    public string Resort { get; set; }
    public string HotelCode { get; set; }
    public string RoomCategory { get; set; }
    public string ShortDescription { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string Label { get; set; }
    public string DiscontinuedInd { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpSys21RoomType>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_SYS21_ROOM_TYPE");

            entity.Property(e => e.DiscontinuedInd)
                .HasColumnName("DISCONTINUED_IND")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.HotelCode)
                .HasColumnName("HOTEL_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Label)
                .IsRequired()
                .HasColumnName("LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomCategory)
                .IsRequired()
                .HasColumnName("ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
