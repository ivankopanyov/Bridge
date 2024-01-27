namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProfileOwnershipView
{
    public decimal NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProfileOwnershipView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROFILE_OWNERSHIP_VIEW");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");
        });
	}
}
