namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OgriddisplayarrayView
{
    public DateTime? FDate { get; set; }
    public string? FLabel { get; set; }
    public string? FCell1 { get; set; }
    public string? FCell2 { get; set; }
    public string? FCell3 { get; set; }
    public string? FCell4 { get; set; }
    public string? FCell5 { get; set; }
    public string? FCell6 { get; set; }
    public string? FCell7 { get; set; }
    public string? FCell8 { get; set; }
    public string? FCell9 { get; set; }
    public string? FCell10 { get; set; }
    public string? FCell11 { get; set; }
    public string? FCell12 { get; set; }
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
    public string? FInternalLabel { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OgriddisplayarrayView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OGRIDDISPLAYARRAY_VIEW");

            entity.Property(e => e.FCell1)
                .HasColumnName("F_CELL1")
                .IsUnicode(false);

            entity.Property(e => e.FCell10)
                .HasColumnName("F_CELL10")
                .IsUnicode(false);

            entity.Property(e => e.FCell11)
                .HasColumnName("F_CELL11")
                .IsUnicode(false);

            entity.Property(e => e.FCell12)
                .HasColumnName("F_CELL12")
                .IsUnicode(false);

            entity.Property(e => e.FCell2)
                .HasColumnName("F_CELL2")
                .IsUnicode(false);

            entity.Property(e => e.FCell3)
                .HasColumnName("F_CELL3")
                .IsUnicode(false);

            entity.Property(e => e.FCell4)
                .HasColumnName("F_CELL4")
                .IsUnicode(false);

            entity.Property(e => e.FCell5)
                .HasColumnName("F_CELL5")
                .IsUnicode(false);

            entity.Property(e => e.FCell6)
                .HasColumnName("F_CELL6")
                .IsUnicode(false);

            entity.Property(e => e.FCell7)
                .HasColumnName("F_CELL7")
                .IsUnicode(false);

            entity.Property(e => e.FCell8)
                .HasColumnName("F_CELL8")
                .IsUnicode(false);

            entity.Property(e => e.FCell9)
                .HasColumnName("F_CELL9")
                .IsUnicode(false);

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
