namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AsbProformaFolios
{
    public string Resort { get; set; }
    public decimal ResvNameId { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal? Amount { get; set; }
    public DateTime? FirstIssueDate { get; set; }
    public DateTime? LastIssueDate { get; set; }
    public decimal? IssueCount { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal? SeqNo { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AsbProformaFolios>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.ResvNameId, e.BeginDate, e.EndDate })
                .HasName("APF_PK");

            entity.ToTable("ASB_PROFORMA_FOLIOS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Amount)
                .HasColumnName("AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FirstIssueDate)
                .HasColumnName("FIRST_ISSUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IssueCount)
                .HasColumnName("ISSUE_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LastIssueDate)
                .HasColumnName("LAST_ISSUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SeqNo)
                .HasColumnName("SEQ_NO")
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
