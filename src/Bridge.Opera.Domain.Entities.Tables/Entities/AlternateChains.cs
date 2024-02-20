namespace Bridge.Opera.Domain.Entities.Tables;

public partial class AlternateChains
{
    public string? ChainCode { get; set; }
    public string? AlternateChainCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? Day1 { get; set; }
    public string? Day2 { get; set; }
    public string? Day3 { get; set; }
    public string? Day4 { get; set; }
    public string? Day5 { get; set; }
    public string? Day6 { get; set; }
    public string? Day7 { get; set; }
    public string? CrossSell { get; set; }

    public virtual ChainCode ChainCodeNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AlternateChains>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.AlternateChainCode })
                .HasName("ALTERNATE_CHAINS_PK");

            entity.ToTable("ALTERNATE_CHAINS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlternateChainCode)
                .HasColumnName("ALTERNATE_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CrossSell)
                .HasColumnName("CROSS_SELL")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Day1)
                .HasColumnName("DAY1")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Day2)
                .HasColumnName("DAY2")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Day3)
                .HasColumnName("DAY3")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Day4)
                .HasColumnName("DAY4")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Day5)
                .HasColumnName("DAY5")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Day6)
                .HasColumnName("DAY6")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Day7)
                .HasColumnName("DAY7")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

			if (!types.Contains(typeof(ChainCode)))
				entity.Ignore(e => e.ChainCodeNavigation);
			else
	            entity.HasOne(d => d.ChainCodeNavigation)
	                .WithMany(p => p.AlternateChains)
	                .HasForeignKey(d => d.ChainCode)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("AC_CHAIN_CODE_FK");
        });
	}
}
