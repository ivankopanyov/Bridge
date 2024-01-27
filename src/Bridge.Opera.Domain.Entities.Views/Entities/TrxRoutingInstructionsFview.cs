namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TrxRoutingInstructionsFview
{
    public string Resort { get; set; }
    public string RoutingType { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal? ToResvNameId { get; set; }
    public string RoomName { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? BillToNameId { get; set; }
    public decimal? FolioView { get; set; }
    public string AddressName { get; set; }
    public string GpSubgpTrxCode { get; set; }
    public string BillingInstrnCode { get; set; }
    public decimal? AddressId { get; set; }
    public string RequestedBy { get; set; }
    public string Comments { get; set; }
    public decimal? AppUserId { get; set; }
    public string RoutingInstruction { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? LimitUsed { get; set; }
    public string AccountCode { get; set; }
    public string DeclinedYn { get; set; }
    public decimal? DeclinedBy { get; set; }
    public string CompVoucherNo { get; set; }
    public decimal? AuthSpend { get; set; }
    public decimal? CompCovers { get; set; }
    public string CompTypeCode { get; set; }
    public string Day1 { get; set; }
    public string Day2 { get; set; }
    public string Day3 { get; set; }
    public string Day4 { get; set; }
    public string Day5 { get; set; }
    public string Day6 { get; set; }
    public string Day7 { get; set; }
    public string DayString { get; set; }
    public string DailyYn { get; set; }
    public decimal? RoutingLinkId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxRoutingInstructionsFview>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRX_ROUTING_INSTRUCTIONS_FVIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AddressName)
                .HasColumnName("ADDRESS_NAME")
                .IsUnicode(false);

            entity.Property(e => e.AppUserId)
                .HasColumnName("APP_USER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthSpend)
                .HasColumnName("AUTH_SPEND")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillToNameId)
                .HasColumnName("BILL_TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingInstrnCode)
                .HasColumnName("BILLING_INSTRN_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CompCovers)
                .HasColumnName("COMP_COVERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompTypeCode)
                .HasColumnName("COMP_TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CompVoucherNo)
                .HasColumnName("COMP_VOUCHER_NO")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.CreditLimit)
                .HasColumnName("CREDIT_LIMIT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DailyYn)
                .HasColumnName("DAILY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DayString)
                .HasColumnName("DAY_STRING")
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.DeclinedBy)
                .HasColumnName("DECLINED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeclinedYn)
                .HasColumnName("DECLINED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.GpSubgpTrxCode)
                .HasColumnName("GP_SUBGP_TRX_CODE")
                .IsUnicode(false);

            entity.Property(e => e.LimitUsed)
                .HasColumnName("LIMIT_USED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestedBy)
                .HasColumnName("REQUESTED_BY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomName)
                .HasColumnName("ROOM_NAME")
                .IsUnicode(false);

            entity.Property(e => e.RoutingInstruction)
                .HasColumnName("ROUTING_INSTRUCTION")
                .IsUnicode(false);

            entity.Property(e => e.RoutingLinkId)
                .HasColumnName("ROUTING_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingType)
                .HasColumnName("ROUTING_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ToResvNameId)
                .HasColumnName("TO_RESV_NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
