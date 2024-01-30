namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RfmCodes
{
    public RfmCodes()
    {
        RfmCodeDetails = new HashSet<RfmCodeDetails>();
    }

    public string? ChainCode { get; set; }
    public string? RfmCode { get; set; }
    public string? Description { get; set; }
    public string? CalculationBasedOn { get; set; }
    public string? CalculationPeriod { get; set; }
    public decimal? CalculationMonths { get; set; }
    public decimal? CalendarMonth { get; set; }
    public string? RfmFormula { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }

    public virtual ICollection<RfmCodeDetails> RfmCodeDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RfmCodes>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RfmCode })
                .HasName("RFM_CODES_PK");

            entity.ToTable("RFM_CODES");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RfmCode)
                .HasColumnName("RFM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalculationBasedOn)
                .IsRequired()
                .HasColumnName("CALCULATION_BASED_ON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalculationMonths)
                .HasColumnName("CALCULATION_MONTHS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CalculationPeriod)
                .IsRequired()
                .HasColumnName("CALCULATION_PERIOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CalendarMonth)
                .HasColumnName("CALENDAR_MONTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RfmFormula)
                .IsRequired()
                .HasColumnName("RFM_FORMULA")
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(RfmCodeDetails)))
				entity.Ignore(e => e.RfmCodeDetails);
		});
	}
}
