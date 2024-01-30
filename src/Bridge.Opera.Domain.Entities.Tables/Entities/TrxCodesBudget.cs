namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TrxCodesBudget
{
    public decimal? TcBudgetId { get; set; }
    public string? Resort { get; set; }
    public string? TrxCode { get; set; }
    public string? TcGroup { get; set; }
    public string? TcSubGroup { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? BudgetAmt { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

    public virtual TrxCodes TrxCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TrxCodesBudget>(entity =>
        {
            entity.HasKey(e => e.TcBudgetId)
                .HasName("TRX_CODES_BUDGET_PK");

            entity.ToTable("TRX$_CODES_BUDGET");

            entity.HasIndex(e => new { e.Resort, e.TrxCode })
                .HasName("TRX_CODE_BUDGET_TRXCODE_IDX");

            entity.Property(e => e.TcBudgetId)
                .HasColumnName("TC_BUDGET_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BudgetAmt)
                .HasColumnName("BUDGET_AMT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcGroup)
                .HasColumnName("TC_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TcSubGroup)
                .HasColumnName("TC_SUB_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

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

			if (!types.Contains(typeof(TrxCodes)))
				entity.Ignore(e => e.TrxCodes);
			else
	            entity.HasOne(d => d.TrxCodes)
	                .WithMany(p => p.TrxCodesBudget)
	                .HasForeignKey(d => new { d.Resort, d.TrxCode })
	                .HasConstraintName("TRX_CODE_BUDGET_TRXCD_FK");
        });
	}
}
