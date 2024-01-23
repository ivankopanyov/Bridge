namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidParameterModuleLinkSys
{
    public string ParameterName { get; set; }
    public string ModuleType { get; set; }
    public string ModuleName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidParameterModuleLinkSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_PARAMETER_MODULE_LINK_SYS");

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ModuleType)
                .IsRequired()
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ParameterName)
                .IsRequired()
                .HasColumnName("PARAMETER_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
