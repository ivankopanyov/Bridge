namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TrxRoutingInstrsBaseView
{
    public string? DailyYn { get; set; }
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubgroup { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? TrxCode { get; set; }
    public decimal? BillToNameId { get; set; }
    public decimal? FolioView { get; set; }
    public DateTime? BeginDate { get; set; }
    public decimal? ToResvNameId { get; set; }
    public decimal? BillingInstrnCode { get; set; }
    public DateTime? EndDate { get; set; }
    public string? AddTrxYn { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public decimal? AddressId { get; set; }
    public decimal? AuthorizerId { get; set; }
    public string? RequestedBy { get; set; }
    public string? AccountCode { get; set; }
    public decimal? CreditLimit { get; set; }
    public decimal? LimitUsed { get; set; }
    public string? Comments { get; set; }
    public string? DeclinedYn { get; set; }
    public decimal? DeclinedBy { get; set; }
    public string? CompVoucherNo { get; set; }
    public decimal? CompCovers { get; set; }
    public string? CompTypeCode { get; set; }
    public decimal? RoutingPercent { get; set; }
    public string? RoutingLimitType { get; set; }
    public decimal? MembershipId { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public string? DayString { get; set; }
    public string? RoutingType { get; set; }
    public decimal? RoutingInstructionsId { get; set; }
    public decimal? RoutingLinkId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxRoutingInstrsBaseView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRX_ROUTING_INSTRS_BASE_VIEW");

            entity.Property(e => e.AccountCode)
                .HasColumnName("ACCOUNT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AddTrxYn)
                .HasColumnName("ADD_TRX_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillToNameId)
                .HasColumnName("BILL_TO_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BillingInstrnCode)
                .HasColumnName("BILLING_INSTRN_CODE")
                .HasColumnType("NUMBER");

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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LimitUsed)
                .HasColumnName("LIMIT_USED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
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

            entity.Property(e => e.RoutingInstructionsId)
                .HasColumnName("ROUTING_INSTRUCTIONS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingLimitType)
                .HasColumnName("ROUTING_LIMIT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RoutingLinkId)
                .HasColumnName("ROUTING_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingPercent)
                .HasColumnName("ROUTING_PERCENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingType)
                .HasColumnName("ROUTING_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubgroup)
                .HasColumnName("TC_SUBGROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToResvNameId)
                .HasColumnName("TO_RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
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
