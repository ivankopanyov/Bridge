namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CorporateAgreements
{
    public decimal? CaId { get; set; }
    public decimal? NameId { get; set; }
    public string? MasterAccount { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? ProjectedRoomNights { get; set; }
    public decimal? CommittedRoomNights { get; set; }
    public string? PaymentType { get; set; }
    public decimal? TaCommissionPct { get; set; }
    public string? TaCommissionDesc { get; set; }
    public string? ChannelCode { get; set; }
    public string? MarketCode { get; set; }
    public string? Contact { get; set; }
    public string? SalesPerson { get; set; }
    public string? BonusCheckYn { get; set; }
    public string? BonusCheckDesc { get; set; }
    public string? AccommodationYn { get; set; }
    public string? AccommodationDesc { get; set; }
    public string? ConferenceYn { get; set; }
    public string? ConferenceDesc { get; set; }
    public string? CaDesc { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? ProjectedRevenue { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? JobNameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CorporateAgreements>(entity =>
        {
            entity.HasKey(e => e.CaId)
                .HasName("SYS_C0027570");

            entity.ToTable("CORPORATE_AGREEMENTS");

            entity.HasIndex(e => e.MasterAccount)
                .HasName("CORP_AGREEMENT_MASTER_ACC");

            entity.HasIndex(e => new { e.NameId, e.BeginDate, e.EndDate })
                .HasName("CORP_AGREEMENT_NAMEID_DATE");

            entity.Property(e => e.CaId)
                .HasColumnName("CA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AccommodationDesc)
                .HasColumnName("ACCOMMODATION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AccommodationYn)
                .HasColumnName("ACCOMMODATION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BonusCheckDesc)
                .HasColumnName("BONUS_CHECK_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BonusCheckYn)
                .HasColumnName("BONUS_CHECK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CaDesc)
                .HasColumnName("CA_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ChannelCode)
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommittedRoomNights)
                .HasColumnName("COMMITTED_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ConferenceDesc)
                .HasColumnName("CONFERENCE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ConferenceYn)
                .HasColumnName("CONFERENCE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Contact)
                .HasColumnName("CONTACT")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.JobNameId)
                .HasColumnName("JOB_NAME_ID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterAccount)
                .IsRequired()
                .HasColumnName("MASTER_ACCOUNT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProjectedRevenue)
                .HasColumnName("PROJECTED_REVENUE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.ProjectedRoomNights)
                .HasColumnName("PROJECTED_ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SalesPerson)
                .HasColumnName("SALES_PERSON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaCommissionDesc)
                .HasColumnName("TA_COMMISSION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TaCommissionPct)
                .HasColumnName("TA_COMMISSION_PCT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
