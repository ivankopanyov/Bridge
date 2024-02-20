namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ApplicationInventory
{
    public string? ApplicationName { get; set; }
    public string? MemberName { get; set; }
    public string? MemberType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ApplicationInventory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("APPLICATION_INVENTORY");

            entity.Property(e => e.ApplicationName)
                .HasColumnName("APPLICATION_NAME")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.MemberName)
                .HasColumnName("MEMBER_NAME")
                .HasMaxLength(240)
                .IsUnicode(false);

            entity.Property(e => e.MemberType)
                .HasColumnName("MEMBER_TYPE")
                .HasMaxLength(15)
                .IsUnicode(false);
        });
	}
}
