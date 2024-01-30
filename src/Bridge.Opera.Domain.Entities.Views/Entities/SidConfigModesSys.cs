namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidConfigModesSys
{
    public string? ConfigMode { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidConfigModesSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_CONFIG_MODES_SYS");

            entity.Property(e => e.ConfigMode)
                .IsRequired()
                .HasColumnName("CONFIG_MODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
