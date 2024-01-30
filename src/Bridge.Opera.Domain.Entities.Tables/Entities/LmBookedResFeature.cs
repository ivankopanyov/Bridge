namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmBookedResFeature
{
    public decimal? BookedResFeaId { get; set; }
    public decimal? BookedResId { get; set; }
    public string? Resort { get; set; }
    public string? FeatureType { get; set; }
    public string? Feature { get; set; }
    public string? ResType { get; set; }
    public string? ResId { get; set; }
    public decimal? Priority010 { get; set; }
    public string? RequestedYn { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmBookedResFeature>(entity =>
        {
            entity.HasKey(e => new { e.BookedResFeaId, e.Resort })
                .HasName("LM_BOOKED_RES_FEA_PK");

            entity.ToTable("LM_BOOKED_RES_FEATURE");

            entity.HasIndex(e => new { e.BookedResId, e.Resort, e.BookedResFeaId })
                .HasName("LM_BOOKED_RES_FEA_UK")
                .IsUnique();

            entity.Property(e => e.BookedResFeaId)
                .HasColumnName("BOOKED_RES_FEA_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookedResId)
                .HasColumnName("BOOKED_RES_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Feature)
                .IsRequired()
                .HasColumnName("FEATURE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FeatureType)
                .IsRequired()
                .HasColumnName("FEATURE_TYPE")
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

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority010)
                .HasColumnName("PRIORITY0_10")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RequestedYn)
                .HasColumnName("REQUESTED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.ResId)
                .HasColumnName("RES_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResType)
                .IsRequired()
                .HasColumnName("RES_TYPE")
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
