namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiScBlkBudgetMonthlyFact
{
    public string Resort { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? BudgetCatYNights { get; set; }
    public decimal? BudgetCatYRev { get; set; }
    public decimal? BudgetCatYAvgRate { get; set; }
    public decimal? BudgetCatNNights { get; set; }
    public decimal? BudgetCatNRev { get; set; }
    public decimal? BudgetCatNAvgRate { get; set; }
    public decimal? BudgetBlkNights { get; set; }
    public decimal? BudgetBlkRev { get; set; }
    public decimal? BudgetBlkAvgRate { get; set; }
    public decimal? BudgetFbRev { get; set; }
    public decimal? BudgetOtherRev { get; set; }
    public decimal? BlkCatYOtherRev { get; set; }
    public decimal? BlkCatYFbRev { get; set; }
    public decimal? BlkCatYPickRms { get; set; }
    public decimal? BlkCatYPickRev { get; set; }
    public decimal? BlkCatYContRev { get; set; }
    public decimal? BlkCatYContRms { get; set; }
    public decimal? BlkCatYBlkRms { get; set; }
    public decimal? BlkCatYGrossRev { get; set; }
    public decimal? BlkCatYNetRev { get; set; }
    public decimal? BlkCatNOtherRev { get; set; }
    public decimal? BlkCatNFbRev { get; set; }
    public decimal? BlkCatNPickRms { get; set; }
    public decimal? BlkCatNPickRev { get; set; }
    public decimal? BlkCatNContRev { get; set; }
    public decimal? BlkCatNContRms { get; set; }
    public decimal? BlkCatNBlkRms { get; set; }
    public decimal? BlkCatNGrossRev { get; set; }
    public decimal? BlkCatNNetRev { get; set; }
    public decimal? BlkOtherRev { get; set; }
    public decimal? BlkFbRev { get; set; }
    public decimal? BlkPickRms { get; set; }
    public decimal? BlkPickRev { get; set; }
    public decimal? BlkContRev { get; set; }
    public decimal? BlkContRms { get; set; }
    public decimal? BlkBlkRms { get; set; }
    public decimal? BlkGrossRev { get; set; }
    public decimal? BlkNetRev { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiScBlkBudgetMonthlyFact>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_SC_BLK_BUDGET_MONTHLY_FACT");

            entity.Property(e => e.BlkBlkRms)
                .HasColumnName("BLK_BLK_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatNBlkRms)
                .HasColumnName("BLK_CAT_N_BLK_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatNContRev)
                .HasColumnName("BLK_CAT_N_CONT_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatNContRms)
                .HasColumnName("BLK_CAT_N_CONT_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatNFbRev)
                .HasColumnName("BLK_CAT_N_FB_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatNGrossRev)
                .HasColumnName("BLK_CAT_N_GROSS_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatNNetRev)
                .HasColumnName("BLK_CAT_N_NET_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatNOtherRev)
                .HasColumnName("BLK_CAT_N_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatNPickRev)
                .HasColumnName("BLK_CAT_N_PICK_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatNPickRms)
                .HasColumnName("BLK_CAT_N_PICK_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatYBlkRms)
                .HasColumnName("BLK_CAT_Y_BLK_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatYContRev)
                .HasColumnName("BLK_CAT_Y_CONT_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatYContRms)
                .HasColumnName("BLK_CAT_Y_CONT_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatYFbRev)
                .HasColumnName("BLK_CAT_Y_FB_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatYGrossRev)
                .HasColumnName("BLK_CAT_Y_GROSS_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatYNetRev)
                .HasColumnName("BLK_CAT_Y_NET_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatYOtherRev)
                .HasColumnName("BLK_CAT_Y_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatYPickRev)
                .HasColumnName("BLK_CAT_Y_PICK_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkCatYPickRms)
                .HasColumnName("BLK_CAT_Y_PICK_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkContRev)
                .HasColumnName("BLK_CONT_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkContRms)
                .HasColumnName("BLK_CONT_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkFbRev)
                .HasColumnName("BLK_FB_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkGrossRev)
                .HasColumnName("BLK_GROSS_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkNetRev)
                .HasColumnName("BLK_NET_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkOtherRev)
                .HasColumnName("BLK_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkPickRev)
                .HasColumnName("BLK_PICK_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BlkPickRms)
                .HasColumnName("BLK_PICK_RMS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetBlkAvgRate)
                .HasColumnName("BUDGET_BLK_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetBlkNights)
                .HasColumnName("BUDGET_BLK_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetBlkRev)
                .HasColumnName("BUDGET_BLK_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCatNAvgRate)
                .HasColumnName("BUDGET_CAT_N_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCatNNights)
                .HasColumnName("BUDGET_CAT_N_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCatNRev)
                .HasColumnName("BUDGET_CAT_N_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCatYAvgRate)
                .HasColumnName("BUDGET_CAT_Y_AVG_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCatYNights)
                .HasColumnName("BUDGET_CAT_Y_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCatYRev)
                .HasColumnName("BUDGET_CAT_Y_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetFbRev)
                .HasColumnName("BUDGET_FB_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetOtherRev)
                .HasColumnName("BUDGET_OTHER_REV")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");
        });
	}
}
