namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiBlkDailyProFact
{
    public string? Resort { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? BlkRms { get; set; }
    public decimal? BlkRmsCatY { get; set; }
    public decimal? BlkRmsCatN { get; set; }
    public decimal? BlkGrossRev { get; set; }
    public decimal? BlkGrossRevCatY { get; set; }
    public decimal? BlkGrossRevCatN { get; set; }
    public decimal? BlkNetRev { get; set; }
    public decimal? BlkNetRevCatY { get; set; }
    public decimal? BlkNetRevCatN { get; set; }
    public decimal? BlkOtherRev { get; set; }
    public decimal? BlkOtherRevCatY { get; set; }
    public decimal? BlkOtherRevCatN { get; set; }
    public decimal? BlkFbRev { get; set; }
    public decimal? BlkFbRevCatY { get; set; }
    public decimal? BlkFbRevCatN { get; set; }
    public decimal? BlkPickRms { get; set; }
    public decimal? BlkPickRmsCatY { get; set; }
    public decimal? BlkPickRmsCatN { get; set; }
    public decimal? BlkPickRev { get; set; }
    public decimal? BlkPickRevCatY { get; set; }
    public decimal? BlkPickRevCatN { get; set; }
    public decimal? BlkContRms { get; set; }
    public decimal? BlkContRmsCatY { get; set; }
    public decimal? BlkContRmsCatN { get; set; }
    public decimal? BlkContRev { get; set; }
    public decimal? BlkContRevCatY { get; set; }
    public decimal? BlkContRevCatN { get; set; }
    public decimal? BlkTotalGrossRev { get; set; }
    public decimal? BlkTotalGrossRevCatY { get; set; }
    public decimal? BlkTotalGrossRevCatN { get; set; }
    public decimal? BlkTotalNetRev { get; set; }
    public decimal? BlkTotalNetRevCatY { get; set; }
    public decimal? BlkTotalNetRevCatN { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiBlkDailyProFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_BLK_DAILY_PRO_FACT");

            entity.Property(e => e.BlkContRev)
                .HasColumnName("BLK_CONT_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkContRevCatN)
                .HasColumnName("BLK_CONT_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkContRevCatY)
                .HasColumnName("BLK_CONT_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkContRms)
                .HasColumnName("BLK_CONT_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkContRmsCatN)
                .HasColumnName("BLK_CONT_RMS_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkContRmsCatY)
                .HasColumnName("BLK_CONT_RMS_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkFbRev)
                .HasColumnName("BLK_FB_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkFbRevCatN)
                .HasColumnName("BLK_FB_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkFbRevCatY)
                .HasColumnName("BLK_FB_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkGrossRev)
                .HasColumnName("BLK_GROSS_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkGrossRevCatN)
                .HasColumnName("BLK_GROSS_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkGrossRevCatY)
                .HasColumnName("BLK_GROSS_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkNetRev)
                .HasColumnName("BLK_NET_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkNetRevCatN)
                .HasColumnName("BLK_NET_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkNetRevCatY)
                .HasColumnName("BLK_NET_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkOtherRev)
                .HasColumnName("BLK_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkOtherRevCatN)
                .HasColumnName("BLK_OTHER_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkOtherRevCatY)
                .HasColumnName("BLK_OTHER_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkPickRev)
                .HasColumnName("BLK_PICK_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkPickRevCatN)
                .HasColumnName("BLK_PICK_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkPickRevCatY)
                .HasColumnName("BLK_PICK_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkPickRms)
                .HasColumnName("BLK_PICK_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkPickRmsCatN)
                .HasColumnName("BLK_PICK_RMS_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkPickRmsCatY)
                .HasColumnName("BLK_PICK_RMS_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRms)
                .HasColumnName("BLK_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRmsCatN)
                .HasColumnName("BLK_RMS_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkRmsCatY)
                .HasColumnName("BLK_RMS_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkTotalGrossRev)
                .HasColumnName("BLK_TOTAL_GROSS_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkTotalGrossRevCatN)
                .HasColumnName("BLK_TOTAL_GROSS_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkTotalGrossRevCatY)
                .HasColumnName("BLK_TOTAL_GROSS_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkTotalNetRev)
                .HasColumnName("BLK_TOTAL_NET_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkTotalNetRevCatN)
                .HasColumnName("BLK_TOTAL_NET_REV_CAT_N")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkTotalNetRevCatY)
                .HasColumnName("BLK_TOTAL_NET_REV_CAT_Y")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}
