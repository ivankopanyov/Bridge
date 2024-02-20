namespace Bridge.Opera.Domain.Entities.Tables;

public partial class MembershipPtsSchDtl
{
    public decimal? PtsSchId { get; set; }
    public string? ChainCode { get; set; }
    public string? PtsSchCode { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? FlatOrPercentage { get; set; }
    public decimal? PointsVar { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? InactiveDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipPtsSchDtl>(entity =>
        {
            entity.HasKey(e => e.PtsSchId)
                .HasName("MPL_PK");

            entity.ToTable("MEMBERSHIP_PTS_SCH_DTL");

            entity.HasIndex(e => new { e.ChainCode, e.PtsSchCode, e.BeginDate })
                .HasName("MEM_PTS_SCH_DET_UK1")
                .IsUnique();

            entity.Property(e => e.PtsSchId)
                .HasColumnName("PTS_SCH_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.ChainCode)
                .IsRequired()
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(240)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.FlatOrPercentage)
                .IsRequired()
                .HasColumnName("FLAT_OR_PERCENTAGE")
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

            entity.Property(e => e.PointsVar)
                .HasColumnName("POINTS_VAR")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PtsSchCode)
                .IsRequired()
                .HasColumnName("PTS_SCH_CODE")
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
