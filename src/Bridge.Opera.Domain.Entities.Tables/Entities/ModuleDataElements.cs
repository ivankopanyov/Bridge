namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ModuleDataElements
{
    public string Module { get; set; }
    public string DataElement { get; set; }
    public string DataElementDatatype { get; set; }
    public decimal? LovSequence { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ModuleDataElements>(entity =>
        {
            entity.HasKey(e => new { e.Module, e.DataElement })
                .HasName("OCO_907838");

            entity.ToTable("MODULE_DATA_ELEMENTS");

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.DataElement)
                .HasColumnName("DATA_ELEMENT")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.DataElementDatatype)
                .HasColumnName("DATA_ELEMENT_DATATYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LovSequence)
                .HasColumnName("LOV_SEQUENCE")
                .HasColumnType("NUMBER");
        });
	}
}
