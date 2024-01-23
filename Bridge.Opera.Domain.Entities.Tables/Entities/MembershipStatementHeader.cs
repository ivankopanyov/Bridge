namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipStatementHeader
{
    public MembershipStatementHeader()
    {
        MembershipStatementDetails = new HashSet<MembershipStatementDetails>();
    }

    public decimal StatementBatchId { get; set; }
    public DateTime StatementDate { get; set; }
    public DateTime EndDate { get; set; }
    public string MembershipType { get; set; }
    public string Status { get; set; }
    public string PrintIfNull { get; set; }
    public string IncludeIfNull { get; set; }
    public string LockStatement { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public decimal? AwPointsAbove { get; set; }
    public decimal? AwPointsBelow { get; set; }
    public string MembershipLevel { get; set; }
    public decimal? NoOfMembersIncluded { get; set; }
    public decimal? NoOfTrxIncluded { get; set; }
    public string ErrorLog { get; set; }
    public string StatementNotes { get; set; }
    public string ChainCode { get; set; }

    public virtual ICollection<MembershipStatementDetails> MembershipStatementDetails { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipStatementHeader>(entity =>
        {
            entity.HasKey(e => e.StatementBatchId)
                .HasName("MEMBERSHIP_STATEMENT_HEADE_PK");

            entity.ToTable("MEMBERSHIP_STATEMENT_HEADER");

            entity.HasIndex(e => new { e.ChainCode, e.MembershipType })
                .HasName("MEMBERSHIP_STATEMENT_HDR_IDX1");

            entity.HasIndex(e => new { e.Status, e.ChainCode })
                .HasName("MEMBERSHIP_STATEMENT_HDR_IDX2");

            entity.Property(e => e.StatementBatchId)
                .HasColumnName("STATEMENT_BATCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwPointsAbove)
                .HasColumnName("AW_POINTS_ABOVE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AwPointsBelow)
                .HasColumnName("AW_POINTS_BELOW")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ErrorLog)
                .HasColumnName("ERROR_LOG")
                .IsUnicode(false);

            entity.Property(e => e.IncludeIfNull)
                .IsRequired()
                .HasColumnName("INCLUDE_IF_NULL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LockStatement)
                .IsRequired()
                .HasColumnName("LOCK_STATEMENT")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.MembershipLevel)
                .HasColumnName("MEMBERSHIP_LEVEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MembershipType)
                .IsRequired()
                .HasColumnName("MEMBERSHIP_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NoOfMembersIncluded)
                .HasColumnName("NO_OF_MEMBERS_INCLUDED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfTrxIncluded)
                .HasColumnName("NO_OF_TRX_INCLUDED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintIfNull)
                .IsRequired()
                .HasColumnName("PRINT_IF_NULL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StatementDate)
                .HasColumnName("STATEMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.StatementNotes)
                .HasColumnName("STATEMENT_NOTES")
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(MembershipStatementDetails)))
				entity.Ignore(e => e.MembershipStatementDetails);
		});
	}
}
