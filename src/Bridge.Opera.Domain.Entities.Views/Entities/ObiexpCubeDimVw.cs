namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiexpCubeDimVw
{
    public string? Cube { get; set; }
    public string? CubeDesc { get; set; }
    public string? Export { get; set; }
    public string? ExportTab { get; set; }
    public string? FileTypeDesc { get; set; }
    public string? DatamartYn { get; set; }
    public string? DimensionYn { get; set; }
    public string? LargeDimensionYn { get; set; }
    public string? FullDimensionYn { get; set; }
    public string? GlobalYn { get; set; }
    public string? ExportView { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiexpCubeDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBIEXP_CUBE_DIM_VW");

            entity.Property(e => e.Cube)
                .HasColumnName("CUBE")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.CubeDesc)
                .HasColumnName("CUBE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.DatamartYn)
                .HasColumnName("DATAMART_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.DimensionYn)
                .HasColumnName("DIMENSION_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Export)
                .IsRequired()
                .HasColumnName("EXPORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExportTab)
                .HasColumnName("EXPORT_TAB")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ExportView)
                .HasColumnName("EXPORT_VIEW")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.FileTypeDesc)
                .HasColumnName("FILE_TYPE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FullDimensionYn)
                .HasColumnName("FULL_DIMENSION_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.GlobalYn)
                .HasColumnName("GLOBAL_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.LargeDimensionYn)
                .HasColumnName("LARGE_DIMENSION_YN")
                .HasColumnType("CHAR(1)");
        });
	}
}
