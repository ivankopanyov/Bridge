namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxRoutingInstructions
{
    public string? RoutingType { get; set; }
    public decimal? RoutingInstructionsId { get; set; }
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
    public string? DailyYn { get; set; }
    public decimal? RoutingLinkId { get; set; }

    public virtual Name BillToName { get; set; }
    public virtual TrxCodeArrangement BillingInstrnCodeNavigation { get; set; }
    public virtual TcGroups TcGroups { get; set; }
    public virtual TcSubgroups TcSubgroups { get; set; }
    public virtual TrxCodes TrxCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxRoutingInstructions>(entity =>
        {
            entity.HasKey(e => e.RoutingInstructionsId)
                .HasName("TRX_ROUTING_ISTR_PK");

            entity.ToTable("TRX_ROUTING_INSTRUCTIONS");

            entity.HasIndex(e => e.BillToNameId)
                .HasName("TRX_ROUTING_INST_IND1");

            entity.HasIndex(e => e.BillingInstrnCode)
                .HasName("TRX_RINST_BILLING_FKI");

            entity.HasIndex(e => e.ToResvNameId)
                .HasName("TRX_RINST_TORESV_IDX");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("TRX_ROUT_TRX_CODES_IDX");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.FolioView })
                .HasName("TRX_RINST_RESV_FOL_VIEW_IDX");

            entity.HasIndex(e => new { e.Resort, e.TcSubgroup, e.TcGroup })
                .HasName("TRX_ROUT_INSTR_SUBGROUPS_FKI");

            entity.HasIndex(e => new { e.TcGroup, e.Resort, e.TcSubgroup })
                .HasName("TRX_ROUT_INSTR_GROUPS_FKI");

            entity.HasIndex(e => new { e.Resort, e.ResvNameId, e.TcGroup, e.TcSubgroup, e.TrxCode, e.BillingInstrnCode, e.BeginDate, e.EndDate, e.FolioView, e.AuthorizerId, e.RequestedBy, e.DayString })
                .HasName("TRX_RINST_UK")
                .IsUnique();

            entity.Property(e => e.RoutingInstructionsId)
                .HasColumnName("ROUTING_INSTRUCTIONS_ID")
                .HasColumnType("NUMBER");

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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.AuthorizerId)
                .HasColumnName("AUTHORIZER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BillToNameId)
                .HasColumnName("BILL_TO_NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.BillingInstrnCode)
                .HasColumnName("BILLING_INSTRN_CODE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Comments)
                .HasColumnName("COMMENTS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.CompCovers)
                .HasColumnName("COMP_COVERS")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DailyYn)
                .HasColumnName("DAILY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DayString)
                .HasColumnName("DAY_STRING")
                .HasMaxLength(7)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DeclinedBy)
                .HasColumnName("DECLINED_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DeclinedYn)
                .HasColumnName("DECLINED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FolioView)
                .HasColumnName("FOLIO_VIEW")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingLimitType)
                .HasColumnName("ROUTING_LIMIT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoutingLinkId)
                .HasColumnName("ROUTING_LINK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoutingPercent)
                .HasColumnName("ROUTING_PERCENT")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RoutingType)
                .HasColumnName("ROUTING_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

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
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

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

			if (!types.Contains(typeof(Name)))
				entity.Ignore(e => e.BillToName);
			else
	            entity.HasOne(d => d.BillToName)
	                .WithMany(p => p.TrxRoutingInstructions)
	                .HasForeignKey(d => d.BillToNameId)
	                .HasConstraintName("ROUTING_INSTR_BILL_TO_NAME_ID");

			if (!types.Contains(typeof(TrxCodeArrangement)))
				entity.Ignore(e => e.BillingInstrnCodeNavigation);
			else
	            entity.HasOne(d => d.BillingInstrnCodeNavigation)
	                .WithMany(p => p.TrxRoutingInstructions)
	                .HasForeignKey(d => d.BillingInstrnCode)
	                .HasConstraintName("ROUTING_INSTRN_BILLING_FK");

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.TrxRoutingInstructions)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .HasConstraintName("ROUTING_INST_TRX_CODES_FK");

			if (!types.Contains(typeof(TcGroups)))
				entity.Ignore(e => e.TcGroups);
			else
	            entity.HasOne(d => d.TcGroups)
	                .WithMany(p => p.TrxRoutingInstructions)
	                .HasForeignKey(d => new { d.TcGroup, d.Resort })
	                .HasConstraintName("ROUTING_INSTR_GROUPS_FK");

			if (!types.Contains(typeof(TcSubgroups)))
				entity.Ignore(e => e.TcSubgroups);
			else
	            entity.HasOne(d => d.TcSubgroups)
	                .WithMany(p => p.TrxRoutingInstructions)
	                .HasForeignKey(d => new { d.Resort, d.TcSubgroup, d.TcGroup })
	                .HasConstraintName("ROUTING_INSTR_SUBGROUPS_FK");
        });
	}
}
