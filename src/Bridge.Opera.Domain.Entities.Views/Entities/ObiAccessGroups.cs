namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiAccessGroups
{
    public string? GroupName { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAccessGroups>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ACCESS_GROUPS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.GroupName)
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
