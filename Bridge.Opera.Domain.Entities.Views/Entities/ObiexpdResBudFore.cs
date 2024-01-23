namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpdResBudFore
{
    public string RowKey { get; set; }
    public DateTime RowTimestamp { get; set; }
    public string Resort { get; set; }
    public decimal AccountingYear { get; set; }
    public string AccountingType { get; set; }
    public string BudgetType { get; set; }
    public string BudgetCodeType { get; set; }
    public string BudgetCodeValue { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string PeriodType { get; set; }
    public decimal? Revenue { get; set; }
    public decimal? RoomNights { get; set; }
    public string LockedYn { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpdResBudFore>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXPD_RES_BUD_FORE");

            entity.Property(e => e.AccountingType)
                .IsRequired()
                .HasColumnName("ACCOUNTING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountingYear)
                .HasColumnName("ACCOUNTING_YEAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BudgetCodeType)
                .IsRequired()
                .HasColumnName("BUDGET_CODE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BudgetCodeValue)
                .IsRequired()
                .HasColumnName("BUDGET_CODE_VALUE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BudgetType)
                .IsRequired()
                .HasColumnName("BUDGET_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LockedYn)
                .HasColumnName("LOCKED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PeriodType)
                .IsRequired()
                .HasColumnName("PERIOD_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Revenue)
                .HasColumnName("REVENUE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RoomNights)
                .HasColumnName("ROOM_NIGHTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RowKey)
                .HasColumnName("ROW_KEY")
                .HasMaxLength(135)
                .IsUnicode(false);

            entity.Property(e => e.RowTimestamp)
                .HasColumnName("ROW_TIMESTAMP")
                .HasColumnType("DATE");

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
