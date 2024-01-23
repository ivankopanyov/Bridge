namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TrxCodeArrangement1
{
    public string Resort { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public decimal ArrangementId { get; set; }
    public string ArrangementCode { get; set; }
    public string Type { get; set; }
    public string ArrangementDesc { get; set; }
    public string EligibleYn { get; set; }
    public string ExportBucketType { get; set; }
    public string CompYn { get; set; }
    public string InheritAuthRatecodeYn { get; set; }
    public decimal? RoutingPercent { get; set; }
    public decimal? RoutingAmount { get; set; }
    public decimal? RoutingCovers { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public string DailyYn { get; set; }
    public string ArrTaxTypeCode { get; set; }
    public string RevenueYn { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodeArrangement1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRX_CODE_ARRANGEMENT");

            entity.Property(e => e.ArrTaxTypeCode)
                .HasColumnName("ARR_TAX_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementCode)
                .IsRequired()
                .HasColumnName("ARRANGEMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementDesc)
                .HasColumnName("ARRANGEMENT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ArrangementId)
                .HasColumnName("ARRANGEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompYn)
                .HasColumnName("COMP_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DailyYn)
                .HasColumnName("DAILY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EligibleYn)
                .HasColumnName("ELIGIBLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExportBucketType)
                .HasColumnName("EXPORT_BUCKET_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InheritAuthRatecodeYn)
                .HasColumnName("INHERIT_AUTH_RATECODE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenueYn)
                .HasColumnName("REVENUE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoutingAmount)
                .HasColumnName("ROUTING_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingCovers)
                .HasColumnName("ROUTING_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingPercent)
                .HasColumnName("ROUTING_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
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
