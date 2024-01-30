namespace Bridge.Opera.Domain.Entities.Tables;

public partial class Us1099
{
    public decimal? Id { get; set; }
    public string? Resort { get; set; }
    public string? PeriodId { get; set; }
    public decimal? NameId { get; set; }
    public string? TaxId { get; set; }
    public string? AccountNo { get; set; }
    public decimal? Income { get; set; }
    public string? SentYn { get; set; }
    public string? Name { get; set; }
    public string? FirstName { get; set; }
    public decimal? AddressId { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Middle { get; set; }
    public decimal? Denomination100 { get; set; }
    public decimal? Denomination50 { get; set; }
    public decimal? Denomination20 { get; set; }
    public decimal? Denomination10 { get; set; }
    public decimal? Denomination5 { get; set; }
    public decimal? Denomination1 { get; set; }
    public decimal? DenominationMisc { get; set; }
    public decimal? AmountPaid { get; set; }
    public string? Currency { get; set; }
    public string? TrxNo { get; set; }
    public string? DocumentType { get; set; }
    public string? DocumentNo { get; set; }
    public string? IssuedBy { get; set; }
    public string? Occupation { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? PrintedYn { get; set; }
    public DateTime? LastPrinted { get; set; }
    public string? ConfirmationNo { get; set; }
    public decimal? ResvNameId { get; set; }
    public DateTime? TriggerDate { get; set; }
    public string? MultiplePaymentsYn { get; set; }
    public string? OverrideReason { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Us1099>(entity =>
        {
            entity.ToTable("US_1099");

            entity.HasIndex(e => new { e.Resort, e.PeriodId, e.NameId, e.ResvNameId })
                .HasName("US_1099_IDX1");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccountNo)
                .HasColumnName("ACCOUNT_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Address1)
                .HasColumnName("ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasColumnName("ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address3)
                .HasColumnName("ADDRESS3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Address4)
                .HasColumnName("ADDRESS4")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AmountPaid)
                .HasColumnName("AMOUNT_PAID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmationNo)
                .HasColumnName("CONFIRMATION_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasColumnName("CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DateOfBirth)
                .HasColumnName("DATE_OF_BIRTH")
                .HasColumnType("DATE");

            entity.Property(e => e.Denomination1)
                .HasColumnName("DENOMINATION_1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Denomination10)
                .HasColumnName("DENOMINATION_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Denomination100)
                .HasColumnName("DENOMINATION_100")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Denomination20)
                .HasColumnName("DENOMINATION_20")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Denomination5)
                .HasColumnName("DENOMINATION_5")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Denomination50)
                .HasColumnName("DENOMINATION_50")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DenominationMisc)
                .HasColumnName("DENOMINATION_MISC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DocumentNo)
                .HasColumnName("DOCUMENT_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DocumentType)
                .HasColumnName("DOCUMENT_TYPE")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Income)
                .HasColumnName("INCOME")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssuedBy)
                .HasColumnName("ISSUED_BY")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.LastPrinted)
                .HasColumnName("LAST_PRINTED")
                .HasColumnType("DATE");

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MultiplePaymentsYn)
                .HasColumnName("MULTIPLE_PAYMENTS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Occupation)
                .HasColumnName("OCCUPATION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OverrideReason)
                .HasColumnName("OVERRIDE_REASON")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PeriodId)
                .IsRequired()
                .HasColumnName("PERIOD_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrintedYn)
                .HasColumnName("PRINTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SentYn)
                .HasColumnName("SENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TaxId)
                .HasColumnName("TAX_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TriggerDate)
                .HasColumnName("TRIGGER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxNo)
                .HasColumnName("TRX_NO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ZipCode)
                .HasColumnName("ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
