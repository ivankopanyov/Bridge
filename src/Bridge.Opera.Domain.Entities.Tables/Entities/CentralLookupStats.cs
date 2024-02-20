namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CentralLookupStats
{
    public string? Resort { get; set; }
    public string? NameType { get; set; }
    public DateTime? LookupDate { get; set; }
    public decimal? ProfileCounter { get; set; }
    public decimal? LookupFailed { get; set; }
    public decimal? LookupSuccess { get; set; }
    public decimal? LookupError { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CentralLookupStats>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.NameType, e.LookupDate })
                .HasName("CENTRAL_LOOKUP_STATS_PK");

            entity.ToTable("CENTRAL_LOOKUP_STATS");

            entity.HasIndex(e => e.LookupDate)
                .HasName("CENTRAL_LOOKUP_STATS_IND");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LookupDate)
                .HasColumnName("LOOKUP_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.LookupError)
                .HasColumnName("LOOKUP_ERROR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LookupFailed)
                .HasColumnName("LOOKUP_FAILED")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LookupSuccess)
                .HasColumnName("LOOKUP_SUCCESS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ProfileCounter)
                .HasColumnName("PROFILE_COUNTER")
                .HasColumnType("NUMBER");
        });
	}
}
