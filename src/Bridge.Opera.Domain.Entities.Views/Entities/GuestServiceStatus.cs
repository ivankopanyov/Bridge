namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GuestServiceStatus
{
    public string Status { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestServiceStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GUEST_SERVICE_STATUS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasColumnType("CHAR(3)");
        });
	}
}
