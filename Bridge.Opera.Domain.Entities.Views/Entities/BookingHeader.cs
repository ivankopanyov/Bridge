namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BookingHeader
{
    public string Resort { get; set; }
    public decimal AllotmentHeaderId { get; set; }
    public string AllotmentType { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public string AllotmentCode { get; set; }
    public decimal? MasterNameId { get; set; }
    public decimal? CompanyNameId { get; set; }
    public decimal? AgentNameId { get; set; }
    public decimal? SourceNameId { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string CancelRule { get; set; }
    public string RateCode { get; set; }
    public string Status { get; set; }
    public decimal? Elastic { get; set; }
    public DateTime? InvCutoffDate { get; set; }
    public decimal? InvCutoffDays { get; set; }
    public decimal? TentativeLevel { get; set; }
    public string Info { get; set; }
    public string MarketCode { get; set; }
    public string Source { get; set; }
    public string Channel { get; set; }
    public decimal? AvgPeoplePerRoom { get; set; }
    public string OriginalRateCode { get; set; }
    public string BookingId { get; set; }
    public decimal? CancellationNo { get; set; }
    public string CancellationCode { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string CancellationDesc { get; set; }
    public string GuaranteeCode { get; set; }
    public decimal? RoomsPerDay { get; set; }
    public decimal? AverageRate { get; set; }
    public string ReserveInventoryYn { get; set; }
    public string AllotmentOrigion { get; set; }
    public int? SuperBlockId { get; set; }
    public string SuperBlockResort { get; set; }
    public decimal? ActionId { get; set; }
    public decimal? DmlSeqNo { get; set; }
    public decimal? ContactNameId { get; set; }
    public string Alias { get; set; }
    public string SalesId { get; set; }
    public string PaymentMethod { get; set; }
    public string CreditCardNumber { get; set; }
    public DateTime? CreditCardExpDate { get; set; }
    public string CreditCardType { get; set; }
    public string RivMarketSegment { get; set; }
    public string ExchangePostingType { get; set; }
    public string CurrencyCode { get; set; }
    public decimal? ExchangeRate { get; set; }
    public DateTime? DateOpenedForPickup { get; set; }
    public string Mainmarket { get; set; }
    public string Tracecode { get; set; }
    public decimal? Owner { get; set; }
    public string OwnerSrepname { get; set; }
    public string OwnerCode { get; set; }
    public decimal? RmsOwner { get; set; }
    public string RmsOwnerSrepname { get; set; }
    public string RmsOwnerCode { get; set; }
    public decimal? CatOwner { get; set; }
    public string CatOwnerSrepname { get; set; }
    public string CatOwnerCode { get; set; }
    public string Bookingtype { get; set; }
    public string Bookingmethod { get; set; }
    public DateTime? MethodDue { get; set; }
    public DateTime? RmsDecision { get; set; }
    public DateTime? RmsFollowup { get; set; }
    public string RmsCurrency { get; set; }
    public string RmsQuoteCurr { get; set; }
    public decimal? RmsExchange { get; set; }
    public decimal? Attendees { get; set; }
    public string CatStatus { get; set; }
    public DateTime? CatDecision { get; set; }
    public DateTime? CatFollowup { get; set; }
    public DateTime? CatCutoff { get; set; }
    public string CatCurrency { get; set; }
    public string CatQuoteCurr { get; set; }
    public decimal? CatExchange { get; set; }
    public string Infoboard { get; set; }
    public string BfstYn { get; set; }
    public decimal? BfstPrice { get; set; }
    public string BfstDesc { get; set; }
    public string PorterageYn { get; set; }
    public decimal? PorteragePrice { get; set; }
    public string Commission { get; set; }
    public string DetailsOkYn { get; set; }
    public string DistributedYn { get; set; }
    public string ContractNr { get; set; }
    public string Functiontype { get; set; }
    public string Representative { get; set; }
    public string BookingStatus { get; set; }
    public decimal? DefaultPmResvNameId { get; set; }
    public string CateringonlyYn { get; set; }
    public string EventsGuaranteedYn { get; set; }
    public string Udfc01 { get; set; }
    public string Udfc02 { get; set; }
    public string Udfc03 { get; set; }
    public string Udfc04 { get; set; }
    public string Udfc05 { get; set; }
    public string Udfc06 { get; set; }
    public string Udfc07 { get; set; }
    public string Udfc08 { get; set; }
    public string Udfc09 { get; set; }
    public string Udfc10 { get; set; }
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
    public decimal? CatCanxNo { get; set; }
    public string CatCanxCode { get; set; }
    public DateTime? CatCanxDate { get; set; }
    public string CatCanxDesc { get; set; }
    public string DownloadResort { get; set; }
    public decimal? DownloadSrep { get; set; }
    public DateTime? DownloadDate { get; set; }
    public DateTime? UploadDate { get; set; }
    public byte? LaptopChange { get; set; }
    public decimal? TaxAmount { get; set; }
    public decimal? ServiceCharge { get; set; }
    public string OwnerResort { get; set; }
    public string RmsOwnerResort { get; set; }
    public string CatOwnerResort { get; set; }
    public DateTime? ShoulderBeginDate { get; set; }
    public DateTime? ShoulderEndDate { get; set; }
    public string Bookingmethoddesc { get; set; }
    public string LeadOrigin { get; set; }
    public DateTime? DueDate { get; set; }
    public string Leadstatus { get; set; }
    public string SentYn { get; set; }
    public DateTime? SentDate { get; set; }
    public string SentVia { get; set; }
    public decimal? SentBy { get; set; }
    public string ReplyStatus { get; set; }
    public DateTime? ReplyDate { get; set; }
    public string ReplyVia { get; set; }
    public decimal? ReplyBy { get; set; }
    public DateTime? DatePel { get; set; }
    public DateTime? DateAcl { get; set; }
    public DateTime? DateTdl { get; set; }
    public DateTime? DateCfl { get; set; }
    public DateTime? DateLsl { get; set; }
    public string TdlReason { get; set; }
    public string LeadNewYn { get; set; }
    public string LeadReceivedYn { get; set; }
    public string HideAccInfoYn { get; set; }
    public string PendingSendYn { get; set; }
    public string Tourcode { get; set; }
    public string AttachmentUrl { get; set; }
    public string CateringPkgsYn { get; set; }
    public string FbAgendaCurr { get; set; }
    public string ProposalShowSpacenameYn { get; set; }
    public string ProposalShowEventpriceYn { get; set; }
    public string ProposalOwnerSelection { get; set; }
    public string ProposalDecisionSelection { get; set; }
    public string RateProtection { get; set; }
    public string NonCompete { get; set; }
    public string ConversionCode { get; set; }
    public string RankingCode { get; set; }
    public string NonCompeteCode { get; set; }
    public string RateGuaranteedYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BookingHeader>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOOKING_HEADER");

            entity.Property(e => e.ActionId)
                .HasColumnName("ACTION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentNameId)
                .HasColumnName("AGENT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Alias)
                .HasColumnName("ALIAS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentHeaderId)
                .HasColumnName("ALLOTMENT_HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentOrigion)
                .HasColumnName("ALLOTMENT_ORIGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentType)
                .IsRequired()
                .HasColumnName("ALLOTMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AttachmentUrl)
                .HasColumnName("ATTACHMENT_URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Attendees)
                .HasColumnName("ATTENDEES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AverageRate)
                .HasColumnName("AVERAGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgPeoplePerRoom)
                .HasColumnName("AVG_PEOPLE_PER_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BfstDesc)
                .HasColumnName("BFST_DESC")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.BfstPrice)
                .HasColumnName("BFST_PRICE")
                .HasColumnType("NUMBER(9,2)");

            entity.Property(e => e.BfstYn)
                .HasColumnName("BFST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookingStatus)
                .IsRequired()
                .HasColumnName("BOOKING_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Bookingmethod)
                .HasColumnName("BOOKINGMETHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Bookingmethoddesc)
                .HasColumnName("BOOKINGMETHODDESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Bookingtype)
                .HasColumnName("BOOKINGTYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancelRule)
                .HasColumnName("CANCEL_RULE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationCode)
                .HasColumnName("CANCELLATION_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancellationDate)
                .HasColumnName("CANCELLATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CancellationDesc)
                .HasColumnName("CANCELLATION_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CancellationNo)
                .HasColumnName("CANCELLATION_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatCanxCode)
                .HasColumnName("CAT_CANX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatCanxDate)
                .HasColumnName("CAT_CANX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CatCanxDesc)
                .HasColumnName("CAT_CANX_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CatCanxNo)
                .HasColumnName("CAT_CANX_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatCurrency)
                .HasColumnName("CAT_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatCutoff)
                .HasColumnName("CAT_CUTOFF")
                .HasColumnType("DATE");

            entity.Property(e => e.CatDecision)
                .HasColumnName("CAT_DECISION")
                .HasColumnType("DATE");

            entity.Property(e => e.CatExchange)
                .HasColumnName("CAT_EXCHANGE")
                .HasColumnType("NUMBER(9,2)");

            entity.Property(e => e.CatFollowup)
                .HasColumnName("CAT_FOLLOWUP")
                .HasColumnType("DATE");

            entity.Property(e => e.CatOwner)
                .HasColumnName("CAT_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CatOwnerCode)
                .HasColumnName("CAT_OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerResort)
                .HasColumnName("CAT_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatOwnerSrepname)
                .HasColumnName("CAT_OWNER_SREPNAME")
                .IsUnicode(false);

            entity.Property(e => e.CatQuoteCurr)
                .HasColumnName("CAT_QUOTE_CURR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CatStatus)
                .HasColumnName("CAT_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CateringPkgsYn)
                .HasColumnName("CATERING_PKGS_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CateringonlyYn)
                .HasColumnName("CATERINGONLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Commission)
                .HasColumnName("COMMISSION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContactNameId)
                .HasColumnName("CONTACT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractNr)
                .HasColumnName("CONTRACT_NR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ConversionCode)
                .HasColumnName("CONVERSION_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpDate)
                .HasColumnName("CREDIT_CARD_EXP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CreditCardNumber)
                .HasColumnName("CREDIT_CARD_NUMBER")
                .IsUnicode(false);

            entity.Property(e => e.CreditCardType)
                .HasColumnName("CREDIT_CARD_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DateAcl)
                .HasColumnName("DATE_ACL")
                .HasColumnType("DATE");

            entity.Property(e => e.DateCfl)
                .HasColumnName("DATE_CFL")
                .HasColumnType("DATE");

            entity.Property(e => e.DateLsl)
                .HasColumnName("DATE_LSL")
                .HasColumnType("DATE");

            entity.Property(e => e.DateOpenedForPickup)
                .HasColumnName("DATE_OPENED_FOR_PICKUP")
                .HasColumnType("DATE");

            entity.Property(e => e.DatePel)
                .HasColumnName("DATE_PEL")
                .HasColumnType("DATE");

            entity.Property(e => e.DateTdl)
                .HasColumnName("DATE_TDL")
                .HasColumnType("DATE");

            entity.Property(e => e.DefaultPmResvNameId)
                .HasColumnName("DEFAULT_PM_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DetailsOkYn)
                .HasColumnName("DETAILS_OK_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DistributedYn)
                .HasColumnName("DISTRIBUTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DmlSeqNo)
                .HasColumnName("DML_SEQ_NO")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DownloadDate)
                .HasColumnName("DOWNLOAD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DownloadResort)
                .HasColumnName("DOWNLOAD_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DownloadSrep)
                .HasColumnName("DOWNLOAD_SREP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DueDate)
                .HasColumnName("DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Elastic)
                .HasColumnName("ELASTIC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EventsGuaranteedYn)
                .HasColumnName("EVENTS_GUARANTEED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ExchangePostingType)
                .HasColumnName("EXCHANGE_POSTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExchangeRate)
                .HasColumnName("EXCHANGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FbAgendaCurr)
                .HasColumnName("FB_AGENDA_CURR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Functiontype)
                .HasColumnName("FUNCTIONTYPE")
                .HasMaxLength(60)
                .IsUnicode(false);

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HideAccInfoYn)
                .HasColumnName("HIDE_ACC_INFO_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Info)
                .HasColumnName("INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Infoboard)
                .HasColumnName("INFOBOARD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvCutoffDate)
                .HasColumnName("INV_CUTOFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InvCutoffDays)
                .HasColumnName("INV_CUTOFF_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LaptopChange)
                .HasColumnName("LAPTOP_CHANGE")
                .HasColumnType("NUMBER(2)");

            entity.Property(e => e.LeadNewYn)
                .HasColumnName("LEAD_NEW_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.LeadOrigin)
                .HasColumnName("LEAD_ORIGIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LeadReceivedYn)
                .HasColumnName("LEAD_RECEIVED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Leadstatus)
                .HasColumnName("LEADSTATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Mainmarket)
                .HasColumnName("MAINMARKET")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterNameId)
                .HasColumnName("MASTER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MethodDue)
                .HasColumnName("METHOD_DUE")
                .HasColumnType("DATE");

            entity.Property(e => e.NonCompete)
                .HasColumnName("NON_COMPETE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.NonCompeteCode)
                .HasColumnName("NON_COMPETE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OriginalRateCode)
                .HasColumnName("ORIGINAL_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Owner)
                .HasColumnName("OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OwnerCode)
                .IsRequired()
                .HasColumnName("OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OwnerResort)
                .HasColumnName("OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerSrepname)
                .HasColumnName("OWNER_SREPNAME")
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethod)
                .HasColumnName("PAYMENT_METHOD")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PendingSendYn)
                .HasColumnName("PENDING_SEND_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PorteragePrice)
                .HasColumnName("PORTERAGE_PRICE")
                .HasColumnType("NUMBER(9,2)");

            entity.Property(e => e.PorterageYn)
                .HasColumnName("PORTERAGE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProposalDecisionSelection)
                .HasColumnName("PROPOSAL_DECISION_SELECTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProposalOwnerSelection)
                .HasColumnName("PROPOSAL_OWNER_SELECTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProposalShowEventpriceYn)
                .HasColumnName("PROPOSAL_SHOW_EVENTPRICE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ProposalShowSpacenameYn)
                .HasColumnName("PROPOSAL_SHOW_SPACENAME_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RankingCode)
                .HasColumnName("RANKING_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RateGuaranteedYn)
                .HasColumnName("RATE_GUARANTEED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RateProtection)
                .HasColumnName("RATE_PROTECTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReplyBy)
                .HasColumnName("REPLY_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReplyDate)
                .HasColumnName("REPLY_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ReplyStatus)
                .HasColumnName("REPLY_STATUS")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ReplyVia)
                .HasColumnName("REPLY_VIA")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Representative)
                .HasColumnName("REPRESENTATIVE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReserveInventoryYn)
                .HasColumnName("RESERVE_INVENTORY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RivMarketSegment)
                .HasColumnName("RIV_MARKET_SEGMENT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsCurrency)
                .HasColumnName("RMS_CURRENCY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsDecision)
                .HasColumnName("RMS_DECISION")
                .HasColumnType("DATE");

            entity.Property(e => e.RmsExchange)
                .HasColumnName("RMS_EXCHANGE")
                .HasColumnType("NUMBER(9,2)");

            entity.Property(e => e.RmsFollowup)
                .HasColumnName("RMS_FOLLOWUP")
                .HasColumnType("DATE");

            entity.Property(e => e.RmsOwner)
                .HasColumnName("RMS_OWNER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RmsOwnerCode)
                .HasColumnName("RMS_OWNER_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerResort)
                .HasColumnName("RMS_OWNER_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RmsOwnerSrepname)
                .HasColumnName("RMS_OWNER_SREPNAME")
                .IsUnicode(false);

            entity.Property(e => e.RmsQuoteCurr)
                .HasColumnName("RMS_QUOTE_CURR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsPerDay)
                .HasColumnName("ROOMS_PER_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SalesId)
                .HasColumnName("SALES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SentBy)
                .HasColumnName("SENT_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SentDate)
                .HasColumnName("SENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SentVia)
                .HasColumnName("SENT_VIA")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.SentYn)
                .HasColumnName("SENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ServiceCharge)
                .HasColumnName("SERVICE_CHARGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShoulderBeginDate)
                .HasColumnName("SHOULDER_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ShoulderEndDate)
                .HasColumnName("SHOULDER_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceNameId)
                .HasColumnName("SOURCE_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SuperBlockId).HasColumnName("SUPER_BLOCK_ID");

            entity.Property(e => e.SuperBlockResort)
                .HasColumnName("SUPER_BLOCK_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TaxAmount)
                .HasColumnName("TAX_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TdlReason)
                .HasColumnName("TDL_REASON")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TentativeLevel)
                .HasColumnName("TENTATIVE_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Tourcode)
                .HasColumnName("TOURCODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Tracecode)
                .HasColumnName("TRACECODE")
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

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("DATE");
        });
	}
}
