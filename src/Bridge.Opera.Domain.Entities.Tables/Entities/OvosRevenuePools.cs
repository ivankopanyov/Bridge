namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OvosRevenuePools
{
    public string? Resort { get; set; }
    public string? RevenuePool { get; set; }
    public string? Description { get; set; }
    public string? AccountPrefix { get; set; }
    public decimal? DisplaySeq { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OvosRevenuePools>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.RevenuePool })
                .HasName("OVOS_REV_POOLS_PK");

            entity.ToTable("OVOS_REVENUE_POOLS");

            entity.HasIndex(e => new { e.Resort, e.AccountPrefix })
                .HasName("OVOS_REV_POOLS_UK")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RevenuePool)
                .HasColumnName("REVENUE_POOL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AccountPrefix)
                .IsRequired()
                .HasColumnName("ACCOUNT_PREFIX")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DisplaySeq)
                .HasColumnName("DISPLAY_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
