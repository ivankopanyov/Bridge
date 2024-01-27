namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosRotationPoints
{
    public decimal Id { get; set; }
    public string Resort { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Room { get; set; }
    public decimal? ContractId { get; set; }
    public decimal? RandomPoints { get; set; }
    public decimal? CalculatedPoints { get; set; }
    public decimal? AveragePoints { get; set; }
    public decimal? AdjustmentPoints { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? ForecastedPoints { get; set; }
    public decimal? BalanceForwardPoints { get; set; }
    public decimal? ManualAdjustmentPoints { get; set; }
    public decimal? OooOosPoints { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosRotationPoints>(entity =>
        {
            entity.ToTable("OVOS_ROTATION_POINTS");

            entity.HasIndex(e => new { e.Resort, e.BeginDate, e.EndDate, e.Room })
                .HasName("ORP_IDX1");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustmentPoints)
                .HasColumnName("ADJUSTMENT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AveragePoints)
                .HasColumnName("AVERAGE_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BalanceForwardPoints)
                .HasColumnName("BALANCE_FORWARD_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CalculatedPoints)
                .HasColumnName("CALCULATED_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ForecastedPoints)
                .HasColumnName("FORECASTED_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ManualAdjustmentPoints)
                .HasColumnName("MANUAL_ADJUSTMENT_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OooOosPoints)
                .HasColumnName("OOO_OOS_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RandomPoints)
                .HasColumnName("RANDOM_POINTS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
