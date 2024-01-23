namespace Bridge.Opera.Domain.Entities.Tables;

public partial class BmStatements
{
    public decimal StatementId { get; set; }
    public decimal NameId { get; set; }
    public DateTime StatementDate { get; set; }
    public decimal ContractId { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Note { get; set; }
    public string ExportedYn { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual BmAccounts Name { get; set; }
    public virtual BmStatementPeriods Statement { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BmStatements>(entity =>
        {
            entity.HasKey(e => new { e.StatementId, e.ContractId })
                .HasName("BMS_PK");

            entity.ToTable("BM_STATEMENTS");

            entity.HasIndex(e => e.ContractId)
                .HasName("BMS_CONTRACT");

            entity.HasIndex(e => new { e.BeginDate, e.EndDate })
                .HasName("BMS_DATES");

            entity.HasIndex(e => new { e.NameId, e.StatementId })
                .HasName("BMS_NAME_PERIOD");

            entity.HasIndex(e => new { e.NameId, e.BeginDate, e.EndDate })
                .HasName("BMS_NAME_DATE");

            entity.Property(e => e.StatementId)
                .HasColumnName("STATEMENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ContractId)
                .HasColumnName("CONTRACT_ID")
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

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
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

			if (!types.Contains(typeof(BmAccounts)))
				entity.Ignore(e => e.Name);
			else
	            entity.HasOne(d => d.Name)
	                .WithMany(p => p.BmStatements)
	                .HasForeignKey(d => d.NameId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BMS_BMA_FK");

			if (!types.Contains(typeof(BmStatementPeriods)))
				entity.Ignore(e => e.Statement);
			else
	            entity.HasOne(d => d.Statement)
	                .WithMany(p => p.BmStatements)
	                .HasForeignKey(d => d.StatementId)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("BMS_BMSP_FK");
        });
	}
}
