namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsSold
{
    public string GdsHost { get; set; }
    public string Resort { get; set; }
    public string GdsRoomCategory { get; set; }
    public DateTime SoldDate { get; set; }
    public decimal NumberSold { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsSold>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.Resort, e.SoldDate, e.GdsRoomCategory })
                .HasName("GSD_PK");

            entity.ToTable("GDS_SOLD");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SoldDate)
                .HasColumnName("SOLD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GdsRoomCategory)
                .HasColumnName("GDS_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NumberSold)
                .HasColumnName("NUMBER_SOLD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
