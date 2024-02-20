namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NameMatchDomains
{
    public string? ChainCode { get; set; }
    public string? Resort { get; set; }
    public string? RuleCode { get; set; }
    public string? DomainScope { get; set; }
    public decimal? MaxMatches { get; set; }
    public decimal? MergeDelay { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameMatchDomains>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NAME_MATCH_DOMAINS");

            entity.HasIndex(e => new { e.ChainCode, e.Resort })
                .HasName("NAME_MATCH_DOM_UKI1")
                .IsUnique();

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DomainScope)
                .HasColumnName("DOMAIN_SCOPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxMatches)
                .HasColumnName("MAX_MATCHES")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MergeDelay)
                .HasColumnName("MERGE_DELAY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RuleCode)
                .HasColumnName("RULE_CODE")
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
