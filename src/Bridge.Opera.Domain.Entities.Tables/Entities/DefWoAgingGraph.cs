namespace Bridge.Opera.Domain.Entities.Tables;

public partial class DefWoAgingGraph
{
    public string? Resort { get; set; }
    public decimal? SeqNumber { get; set; }
    public decimal? FromRange { get; set; }
    public string? FromUot { get; set; }
    public decimal? ToRange { get; set; }
    public string? ToUot { get; set; }
    public string? PriorityCode { get; set; }
    public string? PmYn { get; set; }
    public string? QtYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DefWoAgingGraph>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DEF_WO_AGING_GRAPH");

            entity.Property(e => e.FromRange)
                .HasColumnName("FROM_RANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.FromUot)
                .HasColumnName("FROM_UOT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PmYn)
                .HasColumnName("PM_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.PriorityCode)
                .HasColumnName("PRIORITY_CODE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.QtYn)
                .HasColumnName("QT_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SeqNumber)
                .HasColumnName("SEQ_NUMBER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToRange)
                .HasColumnName("TO_RANGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ToUot)
                .HasColumnName("TO_UOT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
