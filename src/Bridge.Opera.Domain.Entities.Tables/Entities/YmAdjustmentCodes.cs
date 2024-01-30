namespace Bridge.Opera.Domain.Entities.Tables;

public partial class YmAdjustmentCodes
{
    public YmAdjustmentCodes()
    {
        YmNameAdjustments = new HashSet<YmNameAdjustments>();
        YmRateSetAdjustments = new HashSet<YmRateSetAdjustments>();
    }

    public string? Resort { get; set; }
    public string? AdjustmentCode { get; set; }
    public string? Description { get; set; }
    public string? AdjustmentType { get; set; }
    public decimal? AdjustmentAmount { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? FlatOrPercentage { get; set; }

    public virtual ICollection<YmNameAdjustments> YmNameAdjustments { get; set; }
    public virtual ICollection<YmRateSetAdjustments> YmRateSetAdjustments { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<YmAdjustmentCodes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AdjustmentCode })
                .HasName("YM_ADJUSTMENT_CODES_PK");

            entity.ToTable("YM_ADJUSTMENT_CODES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AdjustmentCode)
                .HasColumnName("ADJUSTMENT_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.AdjustmentAmount)
                .HasColumnName("ADJUSTMENT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdjustmentType)
                .IsRequired()
                .HasColumnName("ADJUSTMENT_TYPE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .IsRequired()
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.FlatOrPercentage)
                .HasColumnName("FLAT_OR_PERCENTAGE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("'FLAT'");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(YmNameAdjustments)))
				entity.Ignore(e => e.YmNameAdjustments);

			if (!types.Contains(typeof(YmRateSetAdjustments)))
				entity.Ignore(e => e.YmRateSetAdjustments);
		});
	}
}
