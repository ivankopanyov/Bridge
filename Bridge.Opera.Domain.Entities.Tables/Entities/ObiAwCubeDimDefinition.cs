namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiAwCubeDimDefinition
{
    public string SchemaName { get; set; }
    public string AwName { get; set; }
    public string CubeName { get; set; }
    public string DimensionName { get; set; }
    public string ActiveYn { get; set; }
    public decimal? EstimatedMembers { get; set; }
    public DateTime? EstimationDate { get; set; }
    public DateTime? RefreshTs { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAwCubeDimDefinition>(entity =>
        {
            entity.HasKey(e => new { e.SchemaName, e.AwName, e.CubeName, e.DimensionName })
                .HasName("OBI_AW_CUBE_DIM_DEFINITION_PK");

            entity.ToTable("OBI_AW_CUBE_DIM_DEFINITION");

            entity.Property(e => e.SchemaName)
                .HasColumnName("SCHEMA_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.AwName)
                .HasColumnName("AW_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.CubeName)
                .HasColumnName("CUBE_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.DimensionName)
                .HasColumnName("DIMENSION_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ActiveYn)
                .HasColumnName("ACTIVE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("'N'");

            entity.Property(e => e.EstimatedMembers)
                .HasColumnName("ESTIMATED_MEMBERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.EstimationDate)
                .HasColumnName("ESTIMATION_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.RefreshTs)
                .HasColumnName("REFRESH_TS")
                .HasColumnType("DATE");
        });
	}
}
