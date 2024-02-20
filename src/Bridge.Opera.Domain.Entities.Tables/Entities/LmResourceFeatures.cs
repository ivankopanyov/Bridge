namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmResourceFeatures
{
    public string? ResId { get; set; }
    public string? Resort { get; set; }
    public string? FeatureType { get; set; }
    public string? Feature { get; set; }
    public decimal? Level010 { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmResourceFeatures>(entity =>
        {
            entity.HasKey(e => new { e.ResId, e.Resort, e.FeatureType, e.Feature })
                .HasName("LRE_PK");

            entity.ToTable("LM_RESOURCE_FEATURES");

            entity.HasIndex(e => new { e.Feature, e.Resort, e.ResId })
                .HasName("LM_RES_FEA_IND");

            entity.Property(e => e.ResId)
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FeatureType)
                .HasColumnName("FEATURE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Feature)
                .HasColumnName("FEATURE")
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

            entity.Property(e => e.Level010)
                .HasColumnName("LEVEL0_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
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
