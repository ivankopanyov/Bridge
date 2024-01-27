namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsReportgroupsVw
{
    public string ModuleName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsReportgroupsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_REPORTGROUPS_VW");

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
