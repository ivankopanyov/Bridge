namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepAllotmentView
{
    public decimal HeaderId { get; set; }
    public string Resort { get; set; }
    public string RoomType { get; set; }
    public DateTime AllotmentDate { get; set; }
    public string InsertFormatDate { get; set; }
    public string InsertTime { get; set; }
    public decimal? CurrentToSell { get; set; }
    public decimal? Original { get; set; }
    public decimal? Change { get; set; }
    public decimal? Pickup { get; set; }
    public decimal? Remain { get; set; }
    public decimal? Single { get; set; }
    public decimal? Double { get; set; }
    public decimal? Triple { get; set; }
    public decimal? Quad { get; set; }
    public string BlockName { get; set; }
    public DateTime? CutOffDate { get; set; }
    public decimal? InvCutoffDays { get; set; }
    public decimal? MasterNameId { get; set; }
    public decimal? CompanyNameId { get; set; }
    public string CompanyName { get; set; }
    public string AgentName { get; set; }
    public string SourceName { get; set; }
    public decimal? AgentNameId { get; set; }
    public decimal? SourceNameId { get; set; }
    public string Description { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string CancelRule { get; set; }
    public string RateCode { get; set; }
    public string Status { get; set; }
    public decimal? Elastic { get; set; }
    public decimal? TentativeLevel { get; set; }
    public string Info { get; set; }
    public string MarketCode { get; set; }
    public string Source { get; set; }
    public string Channel { get; set; }
    public decimal? AvgPeoplePerRoom { get; set; }
    public string OriginalRateCode { get; set; }
    public string BookingId { get; set; }
    public string GuaranteeCode { get; set; }
    public decimal? CancellationNo { get; set; }
    public string CancellationCode { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string CancellationDesc { get; set; }
    public decimal? RoomsPerDay { get; set; }
    public decimal? AverageRate { get; set; }
    public string AllotmentOrigion { get; set; }
    public string SuperBlockResort { get; set; }
    public int? SuperBlockId { get; set; }
    public string AllotmentCode { get; set; }
    public decimal InsertUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepAllotmentView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_ALLOTMENT_VIEW");

            entity.Property(e => e.AgentName)
                .HasColumnName("AGENT_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AgentNameId)
                .HasColumnName("AGENT_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AllotmentCode)
                .IsRequired()
                .HasColumnName("ALLOTMENT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AllotmentDate)
                .HasColumnName("ALLOTMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.AllotmentOrigion)
                .HasColumnName("ALLOTMENT_ORIGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AverageRate)
                .HasColumnName("AVERAGE_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AvgPeoplePerRoom)
                .HasColumnName("AVG_PEOPLE_PER_ROOM")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BlockName)
                .IsRequired()
                .HasColumnName("BLOCK_NAME")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
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

            entity.Property(e => e.Change)
                .HasColumnName("CHANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Channel)
                .HasColumnName("CHANNEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompanyName)
                .HasColumnName("COMPANY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.CompanyNameId)
                .HasColumnName("COMPANY_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CurrentToSell)
                .HasColumnName("CURRENT_TO_SELL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CutOffDate)
                .HasColumnName("CUT_OFF_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Double)
                .HasColumnName("DOUBLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Elastic)
                .HasColumnName("ELASTIC")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.GuaranteeCode)
                .HasColumnName("GUARANTEE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HeaderId)
                .HasColumnName("HEADER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Info)
                .HasColumnName("INFO")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InsertFormatDate)
                .HasColumnName("INSERT_FORMAT_DATE")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.InsertTime)
                .HasColumnName("INSERT_TIME")
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InvCutoffDays)
                .HasColumnName("INV_CUTOFF_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MarketCode)
                .HasColumnName("MARKET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MasterNameId)
                .HasColumnName("MASTER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Original)
                .HasColumnName("ORIGINAL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OriginalRateCode)
                .HasColumnName("ORIGINAL_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Pickup)
                .HasColumnName("PICKUP")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Quad)
                .HasColumnName("QUAD")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Remain)
                .HasColumnName("REMAIN")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomType)
                .IsRequired()
                .HasColumnName("ROOM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RoomsPerDay)
                .HasColumnName("ROOMS_PER_DAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Single)
                .HasColumnName("SINGLE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Source)
                .HasColumnName("SOURCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SourceName)
                .HasColumnName("SOURCE_NAME")
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

            entity.Property(e => e.TentativeLevel)
                .HasColumnName("TENTATIVE_LEVEL")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Triple)
                .HasColumnName("TRIPLE")
                .HasColumnType("NUMBER");
        });
	}
}
