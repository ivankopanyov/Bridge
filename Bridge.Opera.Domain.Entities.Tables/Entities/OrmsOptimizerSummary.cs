namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrmsOptimizerSummary
{
    public string Resort { get; set; }
    public string YieldCategory { get; set; }
    public DateTime TruncArrivalDate { get; set; }
    public byte Los { get; set; }
    public decimal? Optimal { get; set; }
    public decimal? Demand { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? CapacityTransfer { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsOptimizerSummary>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.YieldCategory, e.TruncArrivalDate, e.Los })
                .HasName("ORMS_OPTIMIZER_SUMMARY_PK");

            entity.ToTable("ORMS_OPTIMIZER_SUMMARY");

            entity.HasIndex(e => new { e.Resort, e.TruncArrivalDate, e.Los })
                .HasName("ORMS_OPTIMIZER_SUM_ARRDT");

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

            entity.Property(e => e.CapacityTransfer)
                .HasColumnName("CAPACITY_TRANSFER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Demand)
                .HasColumnName("DEMAND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Optimal)
                .HasColumnName("OPTIMAL")
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
