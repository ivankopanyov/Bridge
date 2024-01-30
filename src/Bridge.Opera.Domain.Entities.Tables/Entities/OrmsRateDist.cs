namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsRateDist
{
    public string? Resort { get; set; }
    public string? YieldCategory { get; set; }
    public DateTime? TruncArrivalDate { get; set; }
    public byte Los { get; set; }
    public decimal? PricesliceId { get; set; }
    public decimal? BookingClassId { get; set; }
    public bool MilestoneId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? YResvActual { get; set; }
    public decimal? YResvAdjustedActual { get; set; }
    public decimal? YResvHistory { get; set; }
    public decimal? YResvForecast { get; set; }
    public decimal? YResvCounter { get; set; }
    public decimal? NyResvActual { get; set; }
    public decimal? NyResvAdjustedActual { get; set; }
    public decimal? NyResvHistory { get; set; }
    public decimal? NyResvForecast { get; set; }
    public decimal? NyResvCounter { get; set; }
    public decimal? YCnclActual { get; set; }
    public decimal? YCnclAdjustedActual { get; set; }
    public decimal? YCnclHistory { get; set; }
    public decimal? YCnclForecast { get; set; }
    public decimal? YCnclCounter { get; set; }
    public decimal? NyCnclActual { get; set; }
    public decimal? NyCnclAdjustedActual { get; set; }
    public decimal? NyCnclHistory { get; set; }
    public decimal? NyCnclForecast { get; set; }
    public decimal? NyCnclCounter { get; set; }
    public decimal? DemandTransfered { get; set; }

    public virtual OrmsResvData OrmsResvData { get; set; }
    public virtual OrmsPriceSlices Priceslice { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsRateDist>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.YieldCategory, e.TruncArrivalDate, e.Los, e.PricesliceId, e.BookingClassId, e.MilestoneId })
                .HasName("ORMS_RATE_DIST_PK");

            entity.ToTable("ORMS_RATE_DIST");

            entity.HasIndex(e => e.PricesliceId)
                .HasName("ORMS_RATE_DIST_IND1");

            entity.HasIndex(e => new { e.Resort, e.TruncArrivalDate, e.Los })
                .HasName("ORMS_RATE_DIST_ARRDT");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.YieldCategory)
                .HasColumnName("YIELD_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TruncArrivalDate)
                .HasColumnName("TRUNC_ARRIVAL_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Los).HasColumnName("LOS");

            entity.Property(e => e.PricesliceId)
                .HasColumnName("PRICESLICE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BookingClassId)
                .HasColumnName("BOOKING_CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MilestoneId).HasColumnName("MILESTONE_ID");

            entity.Property(e => e.DemandTransfered)
                .HasColumnName("DEMAND_TRANSFERED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NyCnclActual)
                .HasColumnName("NY_CNCL_ACTUAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NyCnclAdjustedActual)
                .HasColumnName("NY_CNCL_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NyCnclCounter)
                .HasColumnName("NY_CNCL_COUNTER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NyCnclForecast)
                .HasColumnName("NY_CNCL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyCnclHistory)
                .HasColumnName("NY_CNCL_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyResvActual)
                .HasColumnName("NY_RESV_ACTUAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NyResvAdjustedActual)
                .HasColumnName("NY_RESV_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NyResvCounter)
                .HasColumnName("NY_RESV_COUNTER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NyResvForecast)
                .HasColumnName("NY_RESV_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NyResvHistory)
                .HasColumnName("NY_RESV_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YCnclActual)
                .HasColumnName("Y_CNCL_ACTUAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YCnclAdjustedActual)
                .HasColumnName("Y_CNCL_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YCnclCounter)
                .HasColumnName("Y_CNCL_COUNTER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YCnclForecast)
                .HasColumnName("Y_CNCL_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YCnclHistory)
                .HasColumnName("Y_CNCL_HISTORY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YResvActual)
                .HasColumnName("Y_RESV_ACTUAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YResvAdjustedActual)
                .HasColumnName("Y_RESV_ADJUSTED_ACTUAL")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YResvCounter)
                .HasColumnName("Y_RESV_COUNTER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.YResvForecast)
                .HasColumnName("Y_RESV_FORECAST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YResvHistory)
                .HasColumnName("Y_RESV_HISTORY")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(OrmsPriceSlices)))
				entity.Ignore(e => e.Priceslice);
			else
	            entity.HasOne(d => d.Priceslice)
	                .WithMany(p => p.OrmsRateDist)
	                .HasForeignKey(d => d.PricesliceId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_RATE_DIST_ORMS_PRICE_FK1");

			if (!types.Contains(typeof(OrmsResvData)))
				entity.Ignore(e => e.OrmsResvData);
			else
	            entity.HasOne(d => d.OrmsResvData)
	                .WithMany(p => p.OrmsRateDist)
	                .HasForeignKey(d => new { d.Resort, d.TruncArrivalDate })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("ORMS_RATE_DIST_FK");
        });
	}
}
