namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmFeature
{
    public string Feature { get; set; }
    public string FeatureType { get; set; }
    public string Resort { get; set; }
    public string FeatureDesc { get; set; }
    public string FeatureLongDesc { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmFeature>(entity =>
        {
            entity.HasKey(e => new { e.FeatureType, e.Feature, e.Resort })
                .HasName("LM_FEATURE_PK");

            entity.ToTable("LM_FEATURE");

            entity.HasIndex(e => new { e.FeatureType, e.Resort })
                .HasName("LM_FEATURE_IND");

            entity.Property(e => e.FeatureType)
                .HasColumnName("FEATURE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Feature)
                .HasColumnName("FEATURE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FeatureDesc)
                .HasColumnName("FEATURE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FeatureLongDesc)
                .HasColumnName("FEATURE_LONG_DESC")
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        });
	}
}
