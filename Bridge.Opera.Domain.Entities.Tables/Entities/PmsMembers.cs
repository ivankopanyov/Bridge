namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PmsMembers
{
    public string PmsObjectName { get; set; }
    public string PmsObjectType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PmsMembers>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PMS_MEMBERS");

            entity.Property(e => e.PmsObjectName)
                .HasColumnName("PMS_OBJECT_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.PmsObjectType)
                .HasColumnName("PMS_OBJECT_TYPE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
