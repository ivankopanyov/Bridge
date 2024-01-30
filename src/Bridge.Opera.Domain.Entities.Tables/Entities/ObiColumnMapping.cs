namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiColumnMapping
{
    public string? BiTableName { get; set; }
    public string? BiCode { get; set; }
    public string? BiLabel { get; set; }
    public string? OperaCode { get; set; }
    public string? OperaResort { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? BiDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiColumnMapping>(entity =>
        {
            entity.HasKey(e => new { e.BiTableName, e.BiCode, e.OperaCode })
                .HasName("OBI_COL_MAP_PK");

            entity.ToTable("OBI_COLUMN_MAPPING");

            entity.HasIndex(e => new { e.BiTableName, e.OperaCode, e.OperaResort })
                .HasName("OBI_COL_MAP_UK")
                .IsUnique();

            entity.Property(e => e.BiTableName)
                .HasColumnName("BI_TABLE_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BiCode)
                .HasColumnName("BI_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OperaCode)
                .HasColumnName("OPERA_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BiDesc)
                .HasColumnName("BI_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BiLabel)
                .HasColumnName("BI_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OperaResort)
                .HasColumnName("OPERA_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
