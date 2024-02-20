namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidGuaranteeCodesChn
{
    public string? ChainCode { get; set; }
    public string? GuaranteeCode { get; set; }
    public byte? ClosingProbability { get; set; }
    public string? ShortDescription { get; set; }
    public string? LongDescription { get; set; }
    public string? GdsShortDescription { get; set; }
    public string? CashBasisYn { get; set; }
    public string? CroAllowedYn { get; set; }
    public string? PhoneRequiredYn { get; set; }
    public string? AddressRequiredYn { get; set; }
    public string? CreditCardRequiredYn { get; set; }
    public string? ReserveInventoryYn { get; set; }
    public string? DepositRequiredYn { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? MandatoryArrTimeYn { get; set; }
    public string? CanDeleteYn { get; set; }
    public string? InternalYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidGuaranteeCodesChn>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_GUARANTEE_CODES_CHN");

            entity.Property(e => e.AddressRequiredYn)
                .HasColumnName("ADDRESS_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CanDeleteYn)
                .HasColumnName("CAN_DELETE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CashBasisYn)
                .HasColumnName("CASH_BASIS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ClosingProbability).HasColumnName("CLOSING_PROBABILITY");

            entity.Property(e => e.CreditCardRequiredYn)
                .HasColumnName("CREDIT_CARD_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CroAllowedYn)
                .HasColumnName("CRO_ALLOWED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepositRequiredYn)
                .HasColumnName("DEPOSIT_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.GdsShortDescription)
                .HasColumnName("GDS_SHORT_DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .IsRequired()
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
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

            entity.Property(e => e.InternalYn)
                .HasColumnName("INTERNAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LongDescription)
                .HasColumnName("LONG_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MandatoryArrTimeYn)
                .HasColumnName("MANDATORY_ARR_TIME_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PhoneRequiredYn)
                .HasColumnName("PHONE_REQUIRED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReserveInventoryYn)
                .HasColumnName("RESERVE_INVENTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ShortDescription)
                .IsRequired()
                .HasColumnName("SHORT_DESCRIPTION")
                .HasMaxLength(80)
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
