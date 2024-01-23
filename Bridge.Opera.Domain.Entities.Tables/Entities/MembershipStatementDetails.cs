namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipStatementDetails
{
    public decimal MemberStatementId { get; set; }
    public decimal StatementBatchId { get; set; }
    public decimal MembershipId { get; set; }
    public string PrintYn { get; set; }
    public string Status { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? OpeningBalance { get; set; }
    public decimal? StCreditPoints { get; set; }
    public decimal? StDebitPoints { get; set; }
    public decimal? StAwardsConsumed { get; set; }
    public decimal? YtdCreditPoints { get; set; }
    public decimal? YtdDebitPoints { get; set; }
    public decimal? YtdAwardsConsumed { get; set; }
    public decimal? TotalCreditPoints { get; set; }
    public decimal? TotalDebitPoints { get; set; }
    public decimal? TotalAwardsConsumed { get; set; }
    public decimal? StNoRecords { get; set; }
    public decimal? StStayPoints { get; set; }
    public decimal? StNightPoints { get; set; }
    public decimal? StRevenuePoints { get; set; }
    public decimal? YtdStayPoints { get; set; }
    public decimal? YtdNightPoints { get; set; }
    public decimal? YtdRevenuePoints { get; set; }
    public decimal? TotalStayPoints { get; set; }
    public decimal? TotalNightPoints { get; set; }
    public decimal? TotalRevenuePoints { get; set; }
    public decimal? StNameId { get; set; }
    public string StMembershipCardNo { get; set; }
    public string StMembershipLevel { get; set; }
    public string StDisplayName { get; set; }
    public string UserKeyword { get; set; }
    public string StatementNotes { get; set; }
    public string ErrorLog { get; set; }

    public virtual MembershipStatementHeader StatementBatch { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipStatementDetails>(entity =>
        {
            entity.HasKey(e => e.MemberStatementId)
                .HasName("MEMBERSHIP_STATEMENT_DETAI_PK");

            entity.ToTable("MEMBERSHIP_STATEMENT_DETAILS");

            entity.HasIndex(e => e.StatementBatchId)
                .HasName("MEMBERSHIP_STATEMENT_BATCH_ID");

            entity.HasIndex(e => new { e.MembershipId, e.StatementBatchId })
                .HasName("MEMBERSHIP_STATEMENT_MEMBER_ID");

            entity.HasIndex(e => new { e.StMembershipCardNo, e.StatementBatchId })
                .HasName("MEMBERSHIP_STATEMENT_DET_IDX1");

            entity.HasIndex(e => new { e.StMembershipLevel, e.StatementBatchId })
                .HasName("MEMBERSHIP_STATEMENT_DET_IDX2");

            entity.HasIndex(e => new { e.Status, e.StatementBatchId })
                .HasName("MEMBERSHIP_STATEMENT_STATUS");

            entity.HasIndex(e => new { e.UserKeyword, e.StatementBatchId })
                .HasName("MEMBERSHIP_STATEMENT_USER_KEY");

            entity.Property(e => e.MemberStatementId)
                .HasColumnName("MEMBER_STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ErrorLog)
                .HasColumnName("ERROR_LOG")
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OpeningBalance)
                .HasColumnName("OPENING_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintYn)
                .IsRequired()
                .HasColumnName("PRINT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StAwardsConsumed)
                .HasColumnName("ST_AWARDS_CONSUMED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StCreditPoints)
                .HasColumnName("ST_CREDIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StDebitPoints)
                .HasColumnName("ST_DEBIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StDisplayName)
                .HasColumnName("ST_DISPLAY_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StMembershipCardNo)
                .HasColumnName("ST_MEMBERSHIP_CARD_NO")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StMembershipLevel)
                .HasColumnName("ST_MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StNameId)
                .HasColumnName("ST_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StNightPoints)
                .HasColumnName("ST_NIGHT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StNoRecords)
                .HasColumnName("ST_NO_RECORDS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StRevenuePoints)
                .HasColumnName("ST_REVENUE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StStayPoints)
                .HasColumnName("ST_STAY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatementBatchId)
                .HasColumnName("STATEMENT_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.StatementNotes)
                .HasColumnName("STATEMENT_NOTES")
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TotalAwardsConsumed)
                .HasColumnName("TOTAL_AWARDS_CONSUMED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalCreditPoints)
                .HasColumnName("TOTAL_CREDIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalDebitPoints)
                .HasColumnName("TOTAL_DEBIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalNightPoints)
                .HasColumnName("TOTAL_NIGHT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalRevenuePoints)
                .HasColumnName("TOTAL_REVENUE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TotalStayPoints)
                .HasColumnName("TOTAL_STAY_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UserKeyword)
                .HasColumnName("USER_KEYWORD")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.YtdAwardsConsumed)
                .HasColumnName("YTD_AWARDS_CONSUMED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdCreditPoints)
                .HasColumnName("YTD_CREDIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdDebitPoints)
                .HasColumnName("YTD_DEBIT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdNightPoints)
                .HasColumnName("YTD_NIGHT_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdRevenuePoints)
                .HasColumnName("YTD_REVENUE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.YtdStayPoints)
                .HasColumnName("YTD_STAY_POINTS")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(MembershipStatementHeader)))
				entity.Ignore(e => e.StatementBatch);
			else
	            entity.HasOne(d => d.StatementBatch)
	                .WithMany(p => p.MembershipStatementDetails)
	                .HasForeignKey(d => d.StatementBatchId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("MEMBERSHIP_ST_MEMBERSHIP_S_FK");
        });
	}
}
