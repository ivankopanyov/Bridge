namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ProtectedItemsSid
{
    public string? ObjectCode { get; set; }
    public string? ModuleName { get; set; }
    public string? ItemName { get; set; }
    public string? ItemType { get; set; }
    public string? ActionList { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProtectedItemsSid>(entity =>
        {
            entity.HasKey(e => new { e.ObjectCode, e.ModuleName, e.ItemName })
                .HasName("PROTECTED_ITEMS_SID_PK");

            entity.ToTable("PROTECTED_ITEMS_SID");

            entity.Property(e => e.ObjectCode)
                .HasColumnName("OBJECT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ItemName)
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ActionList)
                .HasColumnName("ACTION_LIST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ItemType)
                .HasColumnName("ITEM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
