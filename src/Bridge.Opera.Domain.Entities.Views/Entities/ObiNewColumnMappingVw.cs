namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiNewColumnMappingVw
{
    public string BiTableName { get; set; }
    public string BiCode { get; set; }
    public string BiLabel { get; set; }
    public string BiCodeDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiNewColumnMappingVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_NEW_COLUMN_MAPPING_VW");

            entity.Property(e => e.BiCode)
                .IsRequired()
                .HasColumnName("BI_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BiCodeDesc)
                .HasColumnName("BI_CODE_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.BiLabel)
                .IsRequired()
                .HasColumnName("BI_LABEL")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BiTableName)
                .HasColumnName("BI_TABLE_NAME")
                .HasColumnType("CHAR(4)");
        });
	}
}
