namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OvosExpView
{
    public string Resort { get; set; }
    public decimal ContractId { get; set; }
    public string Unit { get; set; }
    public decimal? OwnerNameId { get; set; }
    public string DisplayName { get; set; }
    public string ContractNumber { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? RentalBeginDate { get; set; }
    public DateTime? RentalEndDate { get; set; }
    public string RentalProgramYn { get; set; }
    public DateTime? InsuranceExpDate { get; set; }
    public DateTime? BlackoutExpDate { get; set; }
    public DateTime? CompNightsExpDate { get; set; }
    public DateTime? MinRateExpDate { get; set; }
    public DateTime? MaxNightsDate { get; set; }
    public DateTime? ContractExpDate { get; set; }
    public DateTime? RentalExpDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosExpView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OVOS_EXP_VIEW");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlackoutExpDate)
                .HasColumnName("BLACKOUT_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CompNightsExpDate)
                .HasColumnName("COMP_NIGHTS_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ContractExpDate)
                .HasColumnName("CONTRACT_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractNumber)
                .HasColumnName("CONTRACT_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsuranceExpDate)
                .HasColumnName("INSURANCE_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MaxNightsDate)
                .HasColumnName("MAX_NIGHTS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MinRateExpDate)
                .HasColumnName("MIN_RATE_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.OwnerNameId)
                .HasColumnName("OWNER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RentalBeginDate)
                .HasColumnName("RENTAL_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RentalEndDate)
                .HasColumnName("RENTAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RentalExpDate)
                .HasColumnName("RENTAL_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RentalProgramYn)
                .HasColumnName("RENTAL_PROGRAM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Unit)
                .HasColumnName("UNIT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
