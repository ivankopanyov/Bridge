namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Ogriddisplayarray
{
    public DateTime? FDate { get; set; }
    public string FLabel { get; set; }
    public decimal? FCell1 { get; set; }
    public decimal? FCell2 { get; set; }
    public decimal? FCell3 { get; set; }
    public decimal? FCell4 { get; set; }
    public decimal? FCell5 { get; set; }
    public decimal? FCell6 { get; set; }
    public decimal? FCell7 { get; set; }
    public decimal? FCell8 { get; set; }
    public decimal? FCell9 { get; set; }
    public decimal? FCell10 { get; set; }
    public decimal? FCell11 { get; set; }
    public decimal? FCell12 { get; set; }
    public decimal? FId1 { get; set; }
    public decimal? FId2 { get; set; }
    public decimal? FId3 { get; set; }
    public decimal? FId4 { get; set; }
    public decimal? FId5 { get; set; }
    public decimal? FId6 { get; set; }
    public decimal? FId7 { get; set; }
    public decimal? FId8 { get; set; }
    public decimal? FId9 { get; set; }
    public decimal? FId10 { get; set; }
    public decimal? FId11 { get; set; }
    public decimal? FId12 { get; set; }
    public decimal? FDaytotal { get; set; }
    public decimal? FTotalbook { get; set; }
    public string FInternalLabel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Ogriddisplayarray>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OGRIDDISPLAYARRAY");

            entity.HasIndex(e => new { e.FDate, e.FInternalLabel })
                .HasName("OGRIDDISPLAYARRAY_IDX1");

            entity.Property(e => e.FCell1)
                .HasColumnName("F_CELL1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell10)
                .HasColumnName("F_CELL10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell11)
                .HasColumnName("F_CELL11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell12)
                .HasColumnName("F_CELL12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell2)
                .HasColumnName("F_CELL2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell3)
                .HasColumnName("F_CELL3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell4)
                .HasColumnName("F_CELL4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell5)
                .HasColumnName("F_CELL5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell6)
                .HasColumnName("F_CELL6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell7)
                .HasColumnName("F_CELL7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell8)
                .HasColumnName("F_CELL8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FCell9)
                .HasColumnName("F_CELL9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FDate)
                .HasColumnName("F_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FDaytotal)
                .HasColumnName("F_DAYTOTAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId1)
                .HasColumnName("F_ID1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId10)
                .HasColumnName("F_ID10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId11)
                .HasColumnName("F_ID11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId12)
                .HasColumnName("F_ID12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId2)
                .HasColumnName("F_ID2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId3)
                .HasColumnName("F_ID3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId4)
                .HasColumnName("F_ID4")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId5)
                .HasColumnName("F_ID5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId6)
                .HasColumnName("F_ID6")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId7)
                .HasColumnName("F_ID7")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId8)
                .HasColumnName("F_ID8")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FId9)
                .HasColumnName("F_ID9")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FInternalLabel)
                .HasColumnName("F_INTERNAL_LABEL")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.FLabel)
                .HasColumnName("F_LABEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FTotalbook)
                .HasColumnName("F_TOTALBOOK")
                .HasColumnType("NUMBER");
        });
	}
}
