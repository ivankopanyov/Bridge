namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AuditBox
{
    public DateTime TrxDate { get; set; }
    public string Resort { get; set; }
    public string TrxCode { get; set; }
    public string Description { get; set; }
    public decimal? NoOfTrans { get; set; }
    public decimal? ActualAmount { get; set; }
    public decimal? InputAttempt1 { get; set; }
    public decimal? InputAttempt2 { get; set; }
    public decimal? InputAttempt3 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AuditBox>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TrxDate, e.TrxCode })
                .HasName("AB_PK");

            entity.ToTable("AUDIT_BOX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TrxDate)
                .HasColumnName("TRX_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.TrxCode)
                .HasColumnName("TRX_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActualAmount)
                .HasColumnName("ACTUAL_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InputAttempt1)
                .HasColumnName("INPUT_ATTEMPT1")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InputAttempt2)
                .HasColumnName("INPUT_ATTEMPT2")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InputAttempt3)
                .HasColumnName("INPUT_ATTEMPT3")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfTrans)
                .HasColumnName("NO_OF_TRANS")
                .HasColumnType("NUMBER");
        });
	}
}
