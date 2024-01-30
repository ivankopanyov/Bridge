namespace Bridge.Opera.Domain.Entities.Tables;

public partial class FsSourceParameterCol
{
    public string? Par { get; set; }
    public string? Src { get; set; }
    public string? SrcCol { get; set; }
    public string? SrcColFormula { get; set; }
    public string? RequiredYn { get; set; }
    public string? UseForAuthYn { get; set; }
    public string? DefaultValue { get; set; }
    public string? EncryptYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<FsSourceParameterCol>(entity =>
        {
            entity.HasKey(e => new { e.Par, e.Src })
                .HasName("FS_SOURCE_PAR_COL_PK");

            entity.ToTable("FS_SOURCE_PARAMETER_COL");

            entity.HasIndex(e => new { e.Src, e.Par })
                .HasName("FS_SOURCE_PAR_COL_IND");

            entity.Property(e => e.Par)
                .HasColumnName("PAR")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Src)
                .HasColumnName("SRC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DefaultValue)
                .HasColumnName("DEFAULT_VALUE")
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EncryptYn)
                .HasColumnName("ENCRYPT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RequiredYn)
                .HasColumnName("REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SrcCol)
                .HasColumnName("SRC_COL")
                .IsUnicode(false);

            entity.Property(e => e.SrcColFormula)
                .HasColumnName("SRC_COL_FORMULA")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UseForAuthYn)
                .HasColumnName("USE_FOR_AUTH_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        });
	}
}
