namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiMappingTables
{
    public string? BiTableName { get; set; }
    public string? BiTableDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiMappingTables>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_MAPPING_TABLES");

            entity.Property(e => e.BiTableDesc)
                .HasColumnName("BI_TABLE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.BiTableName)
                .HasColumnName("BI_TABLE_NAME")
                .HasColumnType("CHAR(4)");
        });
	}
}
