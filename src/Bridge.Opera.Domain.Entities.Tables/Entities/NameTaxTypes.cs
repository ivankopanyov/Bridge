namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameTaxTypes
{
    public string? NameTaxType { get; set; }
    public string? Description { get; set; }
    public string? Resort { get; set; }
    public string? CollectingAgentYn { get; set; }
    public decimal? ReportExemptDays { get; set; }
    public decimal? ReportTaxPerc { get; set; }
    public string? PrintAutoAdjustYn { get; set; }
    public decimal? MinLengthOfStay { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameTaxTypes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.NameTaxType })
                .HasName("NAME_TAX_TYPE_PK");

            entity.ToTable("NAME$_TAX_TYPES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameTaxType)
                .HasColumnName("NAME_TAX_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CollectingAgentYn)
                .HasColumnName("COLLECTING_AGENT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.MinLengthOfStay)
                .HasColumnName("MIN_LENGTH_OF_STAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PrintAutoAdjustYn)
                .HasColumnName("PRINT_AUTO_ADJUST_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ReportExemptDays)
                .HasColumnName("REPORT_EXEMPT_DAYS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ReportTaxPerc)
                .HasColumnName("REPORT_TAX_PERC")
                .HasColumnType("NUMBER");
        });
	}
}
