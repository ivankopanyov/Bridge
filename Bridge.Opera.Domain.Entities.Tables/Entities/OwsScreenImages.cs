namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsScreenImages
{
    public string ScreenName { get; set; }
    public string ImageDesc { get; set; }
    public string ImageFilename { get; set; }
    public decimal? ImageOrder { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsScreenImages>(entity =>
        {
            entity.HasKey(e => new { e.ScreenName, e.ImageFilename })
                .HasName("OSE_PK");

            entity.ToTable("OWS_SCREEN_IMAGES");

            entity.Property(e => e.ScreenName)
                .HasColumnName("SCREEN_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ImageFilename)
                .HasColumnName("IMAGE_FILENAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ImageDesc)
                .HasColumnName("IMAGE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ImageOrder)
                .HasColumnName("IMAGE_ORDER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
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
