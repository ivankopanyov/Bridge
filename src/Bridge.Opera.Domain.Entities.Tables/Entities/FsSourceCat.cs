namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsSourceCat
{
    public string? SrcCat { get; set; }
    public string? CatType { get; set; }
    public string? Url { get; set; }
    public string? SrcCatDesc { get; set; }
    public decimal? OrderBy { get; set; }
    public string? ObiUser { get; set; }
    public string? ObiPwd { get; set; }
    public string? AuthUrl { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsSourceCat>(entity =>
        {
            entity.HasKey(e => e.SrcCat)
                .HasName("FS_SOURCE_CAT_PK");

            entity.ToTable("FS_SOURCE_CAT");

            entity.Property(e => e.SrcCat)
                .HasColumnName("SRC_CAT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AuthUrl)
                .HasColumnName("AUTH_URL")
                .IsUnicode(false);

            entity.Property(e => e.CatType)
                .IsRequired()
                .HasColumnName("CAT_TYPE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObiPwd)
                .HasColumnName("OBI_PWD")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ObiUser)
                .HasColumnName("OBI_USER")
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SrcCatDesc)
                .HasColumnName("SRC_CAT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Url)
                .HasColumnName("URL")
                .IsUnicode(false);
        });
	}
}
