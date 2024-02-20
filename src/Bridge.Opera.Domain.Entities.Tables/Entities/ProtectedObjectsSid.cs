namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProtectedObjectsSid
{
    public string? NameType { get; set; }
    public string? ObjectCode { get; set; }
    public string? DisplayName { get; set; }
    public string? ActionList { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProtectedObjectsSid>(entity =>
        {
            entity.HasKey(e => new { e.NameType, e.ObjectCode })
                .HasName("PROTECTED_OBJECTS_SID_PK");

            entity.ToTable("PROTECTED_OBJECTS_SID");

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ObjectCode)
                .HasColumnName("OBJECT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ActionList)
                .HasColumnName("ACTION_LIST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .IsRequired()
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
