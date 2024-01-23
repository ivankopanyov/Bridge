namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ObiAwDefinition
{
    public string SchemaName { get; set; }
    public string AwName { get; set; }
    public DateTime? RefreshTs { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string RebuildYn { get; set; }
    public string AwFormat11gYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAwDefinition>(entity =>
        {
            entity.HasKey(e => new { e.SchemaName, e.AwName })
                .HasName("OBI_AW_DEFINITION_PK");

            entity.ToTable("OBI_AW_DEFINITION");

            entity.Property(e => e.SchemaName)
                .HasColumnName("SCHEMA_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.AwName)
                .HasColumnName("AW_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.AwFormat11gYn)
                .HasColumnName("AW_FORMAT_11G_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RebuildYn)
                .HasColumnName("REBUILD_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.RefreshTs)
                .HasColumnName("REFRESH_TS")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
