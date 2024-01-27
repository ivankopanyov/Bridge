namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsSourceAttributeCol
{
    public string Atr { get; set; }
    public string Src { get; set; }
    public string SrcCol { get; set; }
    public string SrcColFormula { get; set; }
    public decimal? SummaryOrderBy { get; set; }
    public string AuthParYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsSourceAttributeCol>(entity =>
        {
            entity.HasKey(e => new { e.Atr, e.Src })
                .HasName("FS_SOURCE_ATR_COL_PK");

            entity.ToTable("FS_SOURCE_ATTRIBUTE_COL");

            entity.HasIndex(e => new { e.Src, e.Atr })
                .HasName("FS_SOURCE_ATR_COL_IND");

            entity.Property(e => e.Atr)
                .HasColumnName("ATR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Src)
                .HasColumnName("SRC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AuthParYn)
                .HasColumnName("AUTH_PAR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SrcCol)
                .HasColumnName("SRC_COL")
                .IsUnicode(false);

            entity.Property(e => e.SrcColFormula)
                .HasColumnName("SRC_COL_FORMULA")
                .IsUnicode(false);

            entity.Property(e => e.SummaryOrderBy)
                .HasColumnName("SUMMARY_ORDER_BY")
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
