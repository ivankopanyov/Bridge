namespace Bridge.Opera.Domain.Entities.Tables;

public partial class CaRateCode
{
    public decimal? CaId { get; set; }
    public string? RateCode { get; set; }
    public string? Description { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? Resort { get; set; }
    public string? Region { get; set; }
    public string? DistributedYn { get; set; }
    public string? ApplyRateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CaRateCode>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CA_RATE_CODE");

            entity.HasIndex(e => e.CaId)
                .HasName("CA_RATE_IDX1");

            entity.Property(e => e.ApplyRateYn)
                .HasColumnName("APPLY_RATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.CaId)
                .HasColumnName("CA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DistributedYn)
                .HasColumnName("DISTRIBUTED_YN")
                .HasMaxLength(1)
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

            entity.Property(e => e.RateCode)
                .IsRequired()
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
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
