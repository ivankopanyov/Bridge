namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcSchema
{
    public string? Resort { get; set; }
    public decimal? RowId { get; set; }
    public string? DbfLogo { get; set; }
    public string? SchemaName { get; set; }
    public string? ActionName { get; set; }
    public string? Schema { get; set; }
    public decimal? AttrCount { get; set; }
    public DateTime? InsertDate { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcSchema>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("IFC_SCHEMA");

            entity.HasIndex(e => new { e.RowId, e.SchemaName })
                .HasName("IFC_SCHEMA_PK")
                .IsUnique();

            entity.Property(e => e.ActionName)
                .HasColumnName("ACTION_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AttrCount)
                .HasColumnName("ATTR_COUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RowId)
                .HasColumnName("ROW_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Schema)
                .HasColumnName("SCHEMA")
                .HasColumnType("CLOB");

            entity.Property(e => e.SchemaName)
                .HasColumnName("SCHEMA_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");
        });
	}
}
