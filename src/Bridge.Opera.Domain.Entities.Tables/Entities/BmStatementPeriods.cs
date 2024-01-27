namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmStatementPeriods
{
    public BmStatementPeriods()
    {
        BmStatements = new HashSet<BmStatements>();
    }

    public decimal StatementId { get; set; }
    public DateTime StatementDate { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string ExportedYn { get; set; }
    public string Note { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime? FreezeDate { get; set; }

    public virtual ICollection<BmStatements> BmStatements { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmStatementPeriods>(entity =>
        {
            entity.HasKey(e => e.StatementId)
                .HasName("BMSP_PK");

            entity.ToTable("BM_STATEMENT_PERIODS");

            entity.HasIndex(e => e.EndDate)
                .HasName("BMSP_END_DATE");

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ExportedYn)
                .HasColumnName("EXPORTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FreezeDate)
                .HasColumnName("FREEZE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Note)
                .HasColumnName("NOTE")
                .IsUnicode(false);

            entity.Property(e => e.StatementDate)
                .HasColumnName("STATEMENT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(BmStatements)))
				entity.Ignore(e => e.BmStatements);
		});
	}
}
