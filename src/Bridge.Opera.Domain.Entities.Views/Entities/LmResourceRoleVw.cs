namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class LmResourceRoleVw
{
    public string Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LmResourceRoleVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LM_RESOURCE_ROLE_VW");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .IsUnicode(false);
        });
	}
}
