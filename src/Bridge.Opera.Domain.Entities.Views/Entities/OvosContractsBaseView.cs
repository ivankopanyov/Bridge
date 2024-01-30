namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OvosContractsBaseView
{
    public DateTime? EndDate { get; set; }
    public string? ContractType { get; set; }
    public string? Unit { get; set; }
    public decimal? AdvBookingDays { get; set; }
    public string? ContractPassword { get; set; }
    public string? RentalProgramYn { get; set; }
    public DateTime? RentalBeginDate { get; set; }
    public DateTime? RentalEndDate { get; set; }
    public string? AutoRenewalYn { get; set; }
    public string? OptOutPenaltyFormula { get; set; }
    public decimal? OptOutPenalty { get; set; }
    public decimal? OwnerRevShare { get; set; }
    public string? RevShareFormula { get; set; }
    public decimal? CommByOwner { get; set; }
    public string? SalesAssociate { get; set; }
    public DateTime? ContractPresentedDate { get; set; }
    public string? SsnTaxId { get; set; }
    public DateTime? EstimatedClosingDate { get; set; }
    public decimal? PurchasePrice { get; set; }
    public string? RealEstateAgent { get; set; }
    public string? SpecialChangesToUnit { get; set; }
    public string? Udfc01 { get; set; }
    public string? Udfc02 { get; set; }
    public string? Udfc03 { get; set; }
    public string? Udfc04 { get; set; }
    public string? Udfc05 { get; set; }
    public string? Udfc06 { get; set; }
    public string? Udfc07 { get; set; }
    public string? Udfc08 { get; set; }
    public string? Udfc09 { get; set; }
    public string? Udfc10 { get; set; }
    public string? Udfc11 { get; set; }
    public string? Udfc12 { get; set; }
    public string? Udfc13 { get; set; }
    public string? Udfc14 { get; set; }
    public string? Udfc15 { get; set; }
    public decimal? Udfn01 { get; set; }
    public decimal? Udfn02 { get; set; }
    public decimal? Udfn03 { get; set; }
    public decimal? Udfn04 { get; set; }
    public decimal? Udfn05 { get; set; }
    public decimal? Udfn06 { get; set; }
    public decimal? Udfn07 { get; set; }
    public decimal? Udfn08 { get; set; }
    public decimal? Udfn09 { get; set; }
    public decimal? Udfn10 { get; set; }
    public decimal? Udfn11 { get; set; }
    public decimal? Udfn12 { get; set; }
    public decimal? Udfn13 { get; set; }
    public decimal? Udfn14 { get; set; }
    public decimal? Udfn15 { get; set; }
    public DateTime? Udfd01 { get; set; }
    public DateTime? Udfd02 { get; set; }
    public DateTime? Udfd03 { get; set; }
    public DateTime? Udfd04 { get; set; }
    public DateTime? Udfd05 { get; set; }
    public DateTime? Udfd06 { get; set; }
    public DateTime? Udfd07 { get; set; }
    public DateTime? Udfd08 { get; set; }
    public DateTime? Udfd09 { get; set; }
    public DateTime? Udfd10 { get; set; }
    public DateTime? Udfd11 { get; set; }
    public DateTime? Udfd12 { get; set; }
    public DateTime? Udfd13 { get; set; }
    public DateTime? Udfd14 { get; set; }
    public DateTime? Udfd15 { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? OwnerRoomCategory { get; set; }
    public string? IgnoreTemplateUpdateYn { get; set; }
    public string? FractionalYn { get; set; }
    public string? RepeatCycle { get; set; }
    public decimal? RepeatLength { get; set; }
    public DateTime? RepeatStart { get; set; }
    public string? Resort { get; set; }
    public decimal? ContractId { get; set; }
    public string? Status { get; set; }
    public string? TemplateCode { get; set; }
    public string? ContractNumber { get; set; }
    public string? Description { get; set; }
    public decimal? NameId { get; set; }
    public decimal? AddressId { get; set; }
    public DateTime? BeginDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosContractsBaseView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OVOS_CONTRACTS_BASE_VIEW");

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdvBookingDays)
                .HasColumnName("ADV_BOOKING_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AutoRenewalYn)
                .HasColumnName("AUTO_RENEWAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CommByOwner)
                .HasColumnName("COMM_BY_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractNumber)
                .HasColumnName("CONTRACT_NUMBER")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContractPassword)
                .HasColumnName("CONTRACT_PASSWORD")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ContractPresentedDate)
                .HasColumnName("CONTRACT_PRESENTED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ContractType)
                .HasColumnName("CONTRACT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EstimatedClosingDate)
                .HasColumnName("ESTIMATED_CLOSING_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FractionalYn)
                .HasColumnName("FRACTIONAL_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IgnoreTemplateUpdateYn)
                .HasColumnName("IGNORE_TEMPLATE_UPDATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OptOutPenalty)
                .HasColumnName("OPT_OUT_PENALTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OptOutPenaltyFormula)
                .HasColumnName("OPT_OUT_PENALTY_FORMULA")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.OwnerRevShare)
                .HasColumnName("OWNER_REV_SHARE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerRoomCategory)
                .HasColumnName("OWNER_ROOM_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PurchasePrice)
                .HasColumnName("PURCHASE_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RealEstateAgent)
                .HasColumnName("REAL_ESTATE_AGENT")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RentalBeginDate)
                .HasColumnName("RENTAL_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RentalEndDate)
                .HasColumnName("RENTAL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RentalProgramYn)
                .HasColumnName("RENTAL_PROGRAM_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RepeatCycle)
                .HasColumnName("REPEAT_CYCLE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RepeatLength)
                .HasColumnName("REPEAT_LENGTH")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RepeatStart)
                .HasColumnName("REPEAT_START")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevShareFormula)
                .HasColumnName("REV_SHARE_FORMULA")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.SalesAssociate)
                .HasColumnName("SALES_ASSOCIATE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.SpecialChangesToUnit)
                .HasColumnName("SPECIAL_CHANGES_TO_UNIT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SsnTaxId)
                .HasColumnName("SSN_TAX_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.TemplateCode)
                .HasColumnName("TEMPLATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Udfc01)
                .HasColumnName("UDFC01")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc02)
                .HasColumnName("UDFC02")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc03)
                .HasColumnName("UDFC03")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc04)
                .HasColumnName("UDFC04")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc05)
                .HasColumnName("UDFC05")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc06)
                .HasColumnName("UDFC06")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc07)
                .HasColumnName("UDFC07")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc08)
                .HasColumnName("UDFC08")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc09)
                .HasColumnName("UDFC09")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc10)
                .HasColumnName("UDFC10")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc11)
                .HasColumnName("UDFC11")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc12)
                .HasColumnName("UDFC12")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc13)
                .HasColumnName("UDFC13")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc14)
                .HasColumnName("UDFC14")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfc15)
                .HasColumnName("UDFC15")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Udfd01)
                .HasColumnName("UDFD01")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd02)
                .HasColumnName("UDFD02")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd03)
                .HasColumnName("UDFD03")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd04)
                .HasColumnName("UDFD04")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd05)
                .HasColumnName("UDFD05")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd06)
                .HasColumnName("UDFD06")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd07)
                .HasColumnName("UDFD07")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd08)
                .HasColumnName("UDFD08")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd09)
                .HasColumnName("UDFD09")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd10)
                .HasColumnName("UDFD10")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd11)
                .HasColumnName("UDFD11")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd12)
                .HasColumnName("UDFD12")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd13)
                .HasColumnName("UDFD13")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd14)
                .HasColumnName("UDFD14")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfd15)
                .HasColumnName("UDFD15")
                .HasColumnType("DATE");

            entity.Property(e => e.Udfn01)
                .HasColumnName("UDFN01")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn02)
                .HasColumnName("UDFN02")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn03)
                .HasColumnName("UDFN03")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn04)
                .HasColumnName("UDFN04")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn05)
                .HasColumnName("UDFN05")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn06)
                .HasColumnName("UDFN06")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn07)
                .HasColumnName("UDFN07")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn08)
                .HasColumnName("UDFN08")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn09)
                .HasColumnName("UDFN09")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn10)
                .HasColumnName("UDFN10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn11)
                .HasColumnName("UDFN11")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn12)
                .HasColumnName("UDFN12")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn13)
                .HasColumnName("UDFN13")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn14)
                .HasColumnName("UDFN14")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Udfn15)
                .HasColumnName("UDFN15")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Unit)
                .HasColumnName("UNIT")
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
