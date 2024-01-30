namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsAttributeCat
{
    public string? AtrCat { get; set; }
    public string? AtrCatDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsAttributeCat>(entity =>
        {
            entity.HasKey(e => e.AtrCat)
                .HasName("FS_ATTRIBUTE_CAT_PK");

            entity.ToTable("FS_ATTRIBUTE_CAT");

            entity.Property(e => e.AtrCat)
                .HasColumnName("ATR_CAT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AtrCatDesc)
                .IsRequired()
                .HasColumnName("ATR_CAT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
