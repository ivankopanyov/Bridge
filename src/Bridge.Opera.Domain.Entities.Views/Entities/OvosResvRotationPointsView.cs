namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OvosResvRotationPointsView
{
    public decimal? ForecastedPoints { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? RotationId { get; set; }
    public DateTime? BusinessDate { get; set; }
    public string? Room { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? PointType { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Points { get; set; }
    public decimal? ContractId { get; set; }
    public string? AdjCode { get; set; }
    public string? Description { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosResvRotationPointsView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OVOS_RESV_ROTATION_POINTS_VIEW");

            entity.Property(e => e.AdjCode)
                .HasColumnName("ADJ_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ForecastedPoints)
                .HasColumnName("FORECASTED_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PointType)
                .HasColumnName("POINT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Points)
                .HasColumnName("POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Room)
                .IsRequired()
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RotationId)
                .HasColumnName("ROTATION_ID")
                .HasColumnType("NUMBER");
        });
	}
}
