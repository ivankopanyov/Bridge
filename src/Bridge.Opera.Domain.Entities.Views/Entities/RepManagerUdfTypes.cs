namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class RepManagerUdfTypes
{
    public string UdfType { get; set; }
    public string UdfDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RepManagerUdfTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REP_MANAGER_UDF_TYPES");

            entity.Property(e => e.UdfDescription)
                .HasColumnName("UDF_DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.UdfType)
                .HasColumnName("UDF_TYPE")
                .HasMaxLength(25)
                .IsUnicode(false);
        });
	}
}
