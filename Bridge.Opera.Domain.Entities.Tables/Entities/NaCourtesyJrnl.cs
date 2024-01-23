namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NaCourtesyJrnl
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public decimal MembershipId { get; set; }
    public DateTime TransferDate { get; set; }
    public decimal? TotalRevenue { get; set; }
    public decimal TransferId { get; set; }
    public string ActionType { get; set; }
    public string StatusDescription { get; set; }
    public string ProcessedStatus { get; set; }
    public DateTime? ProcessedDate { get; set; }
    public string Machine { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string RetransferYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NaCourtesyJrnl>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.MembershipId, e.TransferDate })
                .HasName("COURT_TRANS_DATA_PK");

            entity.ToTable("NA_COURTESY_JRNL");

            entity.HasIndex(e => e.InsertDate)
                .HasName("COURT_INSERT_DT_IDX");

            entity.HasIndex(e => e.TransferId)
                .HasName("COURT_TRANS_DATA_UK")
                .IsUnique();

            entity.HasIndex(e => new { e.Resort, e.TransferDate, e.ProcessedStatus })
                .HasName("COURT_TRANS_DT_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MembershipId)
                .HasColumnName("MEMBERSHIP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransferDate)
                .HasColumnName("TRANSFER_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ProcessedDate)
                .HasColumnName("PROCESSED_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ProcessedStatus)
                .HasColumnName("PROCESSED_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RetransferYn)
                .HasColumnName("RETRANSFER_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.StatusDescription)
                .HasColumnName("STATUS_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.TotalRevenue)
                .HasColumnName("TOTAL_REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TransferId)
                .HasColumnName("TRANSFER_ID")
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
