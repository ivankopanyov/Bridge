namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiColumnMappingHdrVw
{
    public string BiTableName { get; set; }
    public string BiCode { get; set; }
    public string BiLabel { get; set; }
    public string BiCodeDesc { get; set; }
    public string OperaCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiColumnMappingHdrVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_COLUMN_MAPPING_HDR_VW");

            entity.Property(e => e.BiCode)
                .IsRequired()
                .HasColumnName("BI_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BiCodeDesc)
                .HasColumnName("BI_CODE_DESC")
                .IsUnicode(false);

            entity.Property(e => e.BiLabel)
                .HasColumnName("BI_LABEL")
                .IsUnicode(false);

            entity.Property(e => e.BiTableName)
                .HasColumnName("BI_TABLE_NAME")
                .HasColumnType("CHAR(4)");

            entity.Property(e => e.OperaCodes)
                .HasColumnName("OPERA_CODES")
                .IsUnicode(false);
        });
	}
}
