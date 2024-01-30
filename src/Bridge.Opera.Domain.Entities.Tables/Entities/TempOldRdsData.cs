namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TempOldRdsData
{
    public string? Resort { get; set; }
    public decimal? ResvNameId { get; set; }
    public decimal? ResvDepositScheduleId { get; set; }
    public decimal? DepositAmount { get; set; }
    public DateTime? DepositDueDate { get; set; }
    public decimal? Percentage { get; set; }
    public string? RuleCode { get; set; }
    public string? Type { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TempOldRdsData>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TEMP_OLD_RDS_DATA");

            entity.Property(e => e.DepositAmount)
                .HasColumnName("DEPOSIT_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DepositDueDate)
                .HasColumnName("DEPOSIT_DUE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Percentage)
                .HasColumnName("PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResvDepositScheduleId)
                .HasColumnName("RESV_DEPOSIT_SCHEDULE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
