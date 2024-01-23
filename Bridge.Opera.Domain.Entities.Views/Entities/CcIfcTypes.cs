namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class CcIfcTypes
{
    public string CcType { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<CcIfcTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CC_IFC_TYPES");

            entity.Property(e => e.CcType)
                .HasColumnName("CC_TYPE")
                .HasColumnType("CHAR(2)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
