namespace Bridge.Opera.Domain.Entities.Tables;

public partial class InventoryGroups
{
    public string Resort { get; set; }
    public string GroupId { get; set; }
    public string GroupName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InventoryGroups>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.GroupId })
                .HasName("IG_PK");

            entity.ToTable("INVENTORY_GROUPS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GroupName)
                .IsRequired()
                .HasColumnName("GROUP_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
