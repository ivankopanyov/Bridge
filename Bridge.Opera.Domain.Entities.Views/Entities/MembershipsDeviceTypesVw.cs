namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class MembershipsDeviceTypesVw
{
    public string MembershipDevices { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<MembershipsDeviceTypesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MEMBERSHIPS_DEVICE_TYPES_VW");

            entity.Property(e => e.MembershipDevices)
                .HasColumnName("MEMBERSHIP_DEVICES")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
