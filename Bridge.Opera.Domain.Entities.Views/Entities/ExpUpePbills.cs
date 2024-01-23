namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ExpUpePbills
{
    public decimal? ExportId { get; set; }
    public decimal? ViewId { get; set; }
    public string FolioId { get; set; }
    public string ProfileType { get; set; }
    public decimal? NameId { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? GuestBalance { get; set; }
    public decimal? Postings { get; set; }
    public decimal? Payments { get; set; }
    public string SourceCode { get; set; }
    public string MarketCode { get; set; }
    public string MarketMainCode { get; set; }
    public string CountryCode { get; set; }
    public string Channel { get; set; }
    public string NameTaxType { get; set; }
    public string TaxExemptNo { get; set; }
    public decimal? MembershipId { get; set; }
    public decimal? BillingContactId { get; set; }
    public decimal? PmsSeqNo { get; set; }
    public string PermanentBillingId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpUpePbills>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EXP_UPE_PBILLS");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillingContactId)
                .HasColumnName("BILLING_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportId)
                .HasColumnName("EXPORT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FolioId)
                .HasColumnName("FOLIO_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GuestBalance)
                .HasColumnName("GUEST_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketMainCode)
                .HasColumnName("MARKET_MAIN_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Payments)
                .HasColumnName("PAYMENTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PermanentBillingId)
                .HasColumnName("PERMANENT_BILLING_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PmsSeqNo)
                .HasColumnName("PMS_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Postings)
                .HasColumnName("POSTINGS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileType)
                .HasColumnName("PROFILE_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TaxExemptNo)
                .HasColumnName("TAX_EXEMPT_NO")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ViewId)
                .HasColumnName("VIEW_ID")
                .HasColumnType("NUMBER");
        });
	}
}
