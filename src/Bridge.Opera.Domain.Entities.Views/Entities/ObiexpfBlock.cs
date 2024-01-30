namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpfBlock
{
    public string? RowKey { get; set; }
    public DateTime? RowTimestamp { get; set; }
    public string? Resort { get; set; }
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? AllotmentId { get; set; }
    public string? AllotmentDesc { get; set; }
    public string? ResortDesc { get; set; }
    public decimal? AllotmentHeaderId { get; set; }
    public string? AllotmentType { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? AllotmentCode { get; set; }
    public decimal? CompanyId { get; set; }
    public string? Company { get; set; }
    public decimal? AgentId { get; set; }
    public string? Agent { get; set; }
    public decimal? SourceId { get; set; }
    public string? Source { get; set; }
    public decimal? CompanyContactId { get; set; }
    public string? CompanyContact { get; set; }
    public decimal? AgentContactId { get; set; }
    public string? AgentContact { get; set; }
    public string? Channel { get; set; }
    public string? ChannelDesc { get; set; }
    public string? AllotmentOrigion { get; set; }
    public string? Status { get; set; }
    public string? BookingStatus { get; set; }
    public string? BookingStatusDesc { get; set; }
    public string? RoomsOwner { get; set; }
    public string? RmsOwnerCode { get; set; }
    public string? RmsOwnerDesc { get; set; }
    public string? RmsOwnerResort { get; set; }
    public string? RmsOwnerResortDesc { get; set; }
    public string? Owner { get; set; }
    public string? OwnerCode { get; set; }
    public string? OwnerDesc { get; set; }
    public string? OwnerResort { get; set; }
    public string? OwnerResortDesc { get; set; }
    public DateTime? CancellationDate { get; set; }
    public DateTime? ShoulderBeginDate { get; set; }
    public DateTime? ShoulderEndDate { get; set; }
    public string? CustomCol1 { get; set; }
    public string? CustomDesc1 { get; set; }
    public string? CustomLabel1 { get; set; }
    public string? CustomCol2 { get; set; }
    public string? CustomDesc2 { get; set; }
    public string? CustomLabel2 { get; set; }
    public string? CustomCol3 { get; set; }
    public string? CustomDesc3 { get; set; }
    public string? CustomLabel3 { get; set; }
    public string? CustomCol4 { get; set; }
    public string? CustomDesc4 { get; set; }
    public string? CustomLabel4 { get; set; }
    public string? CustomCol5 { get; set; }
    public string? CustomDesc5 { get; set; }
    public string? CustomLabel5 { get; set; }
    public string? CustomCol6 { get; set; }
    public string? CustomDesc6 { get; set; }
    public string? CustomLabel6 { get; set; }
    public string? CustomCol7 { get; set; }
    public string? CustomDesc7 { get; set; }
    public string? CustomLabel7 { get; set; }
    public string? CustomCol8 { get; set; }
    public string? CustomDesc8 { get; set; }
    public string? CustomLabel8 { get; set; }
    public string? CustomCol9 { get; set; }
    public string? CustomDesc9 { get; set; }
    public string? CustomLabel9 { get; set; }
    public string? CustomCol10 { get; set; }
    public string? CustomDesc10 { get; set; }
    public string? CustomLabel10 { get; set; }
    public string? ResortId { get; set; }
    public string? AllKey { get; set; }
    public string? MarketCode { get; set; }
    public string? SourceCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpfBlock>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPF_BLOCK");

            entity.Property(e => e.Agent)
                .HasColumnName("AGENT")
                .IsUnicode(false);

            entity.Property(e => e.AgentContact)
                .HasColumnName("AGENT_CONTACT")
                .IsUnicode(false);

            entity.Property(e => e.AgentContactId)
                .HasColumnName("AGENT_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentId)
                .HasColumnName("AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentDesc)
                .IsRequired()
                .HasColumnName("ALLOTMENT_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentId)
                .HasColumnName("ALLOTMENT_ID")
                .HasMaxLength(61)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentOrigion)
                .HasColumnName("ALLOTMENT_ORIGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentType)
                .IsRequired()
                .HasColumnName("ALLOTMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatusDesc)
                .HasColumnName("BOOKING_STATUS_DESC")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChannelDesc)
                .HasColumnName("CHANNEL_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .IsUnicode(false);

            entity.Property(e => e.CompanyContact)
                .HasColumnName("COMPANY_CONTACT")
                .IsUnicode(false);

            entity.Property(e => e.CompanyContactId)
                .HasColumnName("COMPANY_CONTACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CustomCol1)
                .HasColumnName("CUSTOM_COL_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol10)
                .HasColumnName("CUSTOM_COL_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol2)
                .HasColumnName("CUSTOM_COL_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol3)
                .HasColumnName("CUSTOM_COL_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol4)
                .HasColumnName("CUSTOM_COL_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol5)
                .HasColumnName("CUSTOM_COL_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol6)
                .HasColumnName("CUSTOM_COL_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol7)
                .HasColumnName("CUSTOM_COL_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol8)
                .HasColumnName("CUSTOM_COL_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol9)
                .HasColumnName("CUSTOM_COL_9")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc1)
                .HasColumnName("CUSTOM_DESC_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc10)
                .HasColumnName("CUSTOM_DESC_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc2)
                .HasColumnName("CUSTOM_DESC_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc3)
                .HasColumnName("CUSTOM_DESC_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc4)
                .HasColumnName("CUSTOM_DESC_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc5)
                .HasColumnName("CUSTOM_DESC_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc6)
                .HasColumnName("CUSTOM_DESC_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc7)
                .HasColumnName("CUSTOM_DESC_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc8)
                .HasColumnName("CUSTOM_DESC_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc9)
                .HasColumnName("CUSTOM_DESC_9")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel1)
                .HasColumnName("CUSTOM_LABEL_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel10)
                .HasColumnName("CUSTOM_LABEL_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel2)
                .HasColumnName("CUSTOM_LABEL_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel3)
                .HasColumnName("CUSTOM_LABEL_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel4)
                .HasColumnName("CUSTOM_LABEL_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel5)
                .HasColumnName("CUSTOM_LABEL_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel6)
                .HasColumnName("CUSTOM_LABEL_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel7)
                .HasColumnName("CUSTOM_LABEL_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel8)
                .HasColumnName("CUSTOM_LABEL_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel9)
                .HasColumnName("CUSTOM_LABEL_9")
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasMaxLength(33)
                .IsUnicode(false);

            entity.Property(e => e.OwnerCode)
                .IsRequired()
                .HasColumnName("OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OwnerDesc)
                .HasColumnName("OWNER_DESC")
                .IsUnicode(false);

            entity.Property(e => e.OwnerResort)
                .HasColumnName("OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerResortDesc)
                .HasColumnName("OWNER_RESORT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortDesc)
                .HasColumnName("RESORT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .IsRequired()
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerCode)
                .HasColumnName("RMS_OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerDesc)
                .HasColumnName("RMS_OWNER_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerResort)
                .HasColumnName("RMS_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerResortDesc)
                .HasColumnName("RMS_OWNER_RESORT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.RoomsOwner)
                .HasColumnName("ROOMS_OWNER")
                .HasMaxLength(33)
                .IsUnicode(false);

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(61)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.ShoulderBeginDate)
                .HasColumnName("SHOULDER_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ShoulderEndDate)
                .HasColumnName("SHOULDER_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .IsUnicode(false);

            entity.Property(e => e.SourceCode)
                .HasColumnName("SOURCE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceId)
                .HasColumnName("SOURCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
