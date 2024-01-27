namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpEfolioDetails4
{
    public decimal? ExportId { get; set; }
    public decimal? RowSequence { get; set; }
    public decimal? PartySequence { get; set; }
    public decimal? DetailSequence { get; set; }
    public string ExportType { get; set; }
    public string Cardnum { get; set; }
    public string Cardauthcode { get; set; }
    public string Cardrefnum { get; set; }
    public string Cardexpirationdate { get; set; }
    public string Cardtype { get; set; }
    public string Cardholdername { get; set; }
    public decimal? Netvalue { get; set; }
    public decimal? Taxvalue { get; set; }
    public decimal? Grossvalue { get; set; }
    public decimal? PaymentAmount { get; set; }
    public DateTime? PaymentDate { get; set; }
    public string ExpPaymentType { get; set; }
    public string PaymentTrxDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpEfolioDetails4>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_EFOLIO_DETAILS_4");

            entity.Property(e => e.Cardauthcode)
                .HasColumnName("CARDAUTHCODE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cardexpirationdate)
                .HasColumnName("CARDEXPIRATIONDATE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cardholdername)
                .HasColumnName("CARDHOLDERNAME")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cardnum)
                .HasColumnName("CARDNUM")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cardrefnum)
                .HasColumnName("CARDREFNUM")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Cardtype)
                .HasColumnName("CARDTYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DetailSequence)
                .HasColumnName("DETAIL_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExpPaymentType)
                .HasColumnName("EXP_PAYMENT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ExportType)
                .HasColumnName("EXPORT_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Grossvalue)
                .HasColumnName("GROSSVALUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Netvalue)
                .HasColumnName("NETVALUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PartySequence)
                .HasColumnName("PARTY_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentAmount)
                .HasColumnName("PAYMENT_AMOUNT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentDate)
                .HasColumnName("PAYMENT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.PaymentTrxDescription)
                .HasColumnName("PAYMENT_TRX_DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowSequence)
                .HasColumnName("ROW_SEQUENCE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Taxvalue)
                .HasColumnName("TAXVALUE")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
