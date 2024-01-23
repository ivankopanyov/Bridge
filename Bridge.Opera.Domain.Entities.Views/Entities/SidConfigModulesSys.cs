namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidConfigModulesSys
{
    public string DefaultModule { get; set; }
    public string ConfigMode { get; set; }
    public string ModuleType { get; set; }
    public string NewModule { get; set; }
    public string Remarks { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidConfigModulesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CONFIG_MODULES_SYS");

            entity.Property(e => e.ConfigMode)
                .IsRequired()
                .HasColumnName("CONFIG_MODE")
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.Property(e => e.DefaultModule)
                .IsRequired()
                .HasColumnName("DEFAULT_MODULE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ModuleType)
                .IsRequired()
                .HasColumnName("MODULE_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.NewModule)
                .IsRequired()
                .HasColumnName("NEW_MODULE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Remarks)
                .HasColumnName("REMARKS")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
