namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsAttribute
{
    public string? Atr { get; set; }
    public string? AtrDesc { get; set; }
    public string? Datatype { get; set; }
    public string? AtrCat { get; set; }
    public decimal? OrderBy { get; set; }
    public string? InternalYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsAttribute>(entity =>
        {
            entity.HasKey(e => e.Atr)
                .HasName("FS_ATTRIBUTE_PK");

            entity.ToTable("FS_ATTRIBUTE");

            entity.Property(e => e.Atr)
                .HasColumnName("ATR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AtrCat)
                .IsRequired()
                .HasColumnName("ATR_CAT")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AtrDesc)
                .IsRequired()
                .HasColumnName("ATR_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Datatype)
                .IsRequired()
                .HasColumnName("DATATYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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
