namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AwardRequests
{
    public decimal? AwardRequestId { get; set; }
    public string? Resort { get; set; }
    public string? AwardCode { get; set; }
    public string? MembershipNo { get; set; }
    public decimal? AwardQty { get; set; }
    public DateTime? ProcessedDate { get; set; }
    public string? RequestAgentId { get; set; }
    public DateTime? RequestTime { get; set; }
    public string? CancelAgentId { get; set; }
    public DateTime? CancelTime { get; set; }
    public decimal? ConfirmationNumber { get; set; }
    public decimal? ResvNameId { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? AwardOrderNo { get; set; }
    public decimal? BalancePoints { get; set; }
    public decimal? NewPointBalance { get; set; }
    public string? SearchLastName { get; set; }
    public string? SearchFirstName { get; set; }
    public DateTime? SearchAwardDate { get; set; }
    public string? RecordStatus { get; set; }

    public virtual Awards Awards { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AwardRequests>(entity =>
        {
            entity.HasKey(e => e.AwardRequestId)
                .HasName("AWARD_REQUESTS_PK");

            entity.ToTable("AWARD_REQUESTS");

            entity.HasIndex(e => new { e.Resort, e.AwardCode })
                .HasName("AWARD_REQUESTS_FK_I");

            entity.HasIndex(e => new { e.Resort, e.RecordStatus })
                .HasName("AWARD_REQS_RESORT_STATUS_IDX");

            entity.Property(e => e.AwardRequestId)
                .HasColumnName("AWARD_REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwardCode)
                .IsRequired()
                .HasColumnName("AWARD_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AwardOrderNo)
                .HasColumnName("AWARD_ORDER_NO")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AwardQty)
                .HasColumnName("AWARD_QTY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BalancePoints)
                .HasColumnName("BALANCE_POINTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CancelAgentId)
                .HasColumnName("CANCEL_AGENT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CancelTime)
                .HasColumnName("CANCEL_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.ConfirmationNumber)
                .HasColumnName("CONFIRMATION_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstName)
                .HasColumnName("FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .HasColumnName("LAST_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.MembershipNo)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NewPointBalance)
                .HasColumnName("NEW_POINT_BALANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProcessedDate)
                .HasColumnName("PROCESSED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RecordStatus)
                .HasColumnName("RECORD_STATUS")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.RequestAgentId)
                .HasColumnName("REQUEST_AGENT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RequestTime)
                .HasColumnName("REQUEST_TIME")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SearchAwardDate)
                .HasColumnName("SEARCH_AWARD_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SearchFirstName)
                .HasColumnName("SEARCH_FIRST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SearchLastName)
                .HasColumnName("SEARCH_LAST_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

			if (!types.Contains(typeof(Awards)))
				entity.Ignore(e => e.Awards);
			else
	            entity.HasOne(d => d.Awards)
	                .WithMany(p => p.AwardRequests)
	                .HasPrincipalKey(p => new { p.Resort, p.AwardCode })
	                .HasForeignKey(d => new { d.Resort, d.AwardCode })
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("AWARD_REQUESTS_FK");
        });
	}
}
