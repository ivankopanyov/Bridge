namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateCode
{
    public string RateCode { get; set; }
    public string GdsHost { get; set; }
    public string GdsRateCode1 { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public string GdsRateCategory { get; set; }
    public string GdsRateLevel { get; set; }
    public string NegRateCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateCode>(entity =>
        {
            entity.HasKey(e => new { e.RateCode, e.GdsHost })
                .HasName("PK_RATE_CODE_GDS");

            entity.ToTable("GDS_RATE_CODE");

            entity.HasIndex(e => e.GdsHost)
                .HasName("GDS_RATE_CODE_IDX1");

            entity.Property(e => e.RateCode)
                .HasColumnName("RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCategory)
                .HasColumnName("GDS_RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCode1)
                .IsRequired()
                .HasColumnName("GDS_RATE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateLevel)
                .HasColumnName("GDS_RATE_LEVEL")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegRateCode)
                .HasColumnName("NEG_RATE_CODE")
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
