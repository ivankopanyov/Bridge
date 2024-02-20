namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LmRequiredResFeature
{
    public string? Feature { get; set; }
    public decimal? ReqSeq { get; set; }
    public string? Resort { get; set; }
    public string? FeatureType { get; set; }
    public decimal? Priority010 { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmRequiredResFeature>(entity =>
        {
            entity.HasKey(e => new { e.ReqSeq, e.Resort, e.FeatureType, e.Feature })
                .HasName("LM_REQ_RES_FEA_PK");

            entity.ToTable("LM_REQUIRED_RES_FEATURE");

            entity.Property(e => e.ReqSeq)
                .HasColumnName("REQ_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FeatureType)
                .HasColumnName("FEATURE_TYPE")
                .HasMaxLength(240)
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

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Priority010)
                .HasColumnName("PRIORITY0_10")
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
