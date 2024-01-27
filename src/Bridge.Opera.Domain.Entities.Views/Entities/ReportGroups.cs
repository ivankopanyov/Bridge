namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ReportGroups
{
    public string ModuleName { get; set; }
    public string ModuleDesc { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ReportGroups>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("REPORT_GROUPS");

            entity.Property(e => e.ModuleDesc)
                .HasColumnName("MODULE_DESC")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
