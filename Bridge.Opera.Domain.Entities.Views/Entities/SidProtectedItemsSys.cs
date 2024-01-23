namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidProtectedItemsSys
{
    public string ObjectCode { get; set; }
    public string ModuleName { get; set; }
    public string ItemName { get; set; }
    public string ItemType { get; set; }
    public string ActionList { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidProtectedItemsSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_PROTECTED_ITEMS_SYS");

            entity.Property(e => e.ActionList)
                .HasColumnName("ACTION_LIST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ItemName)
                .IsRequired()
                .HasColumnName("ITEM_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ItemType)
                .HasColumnName("ITEM_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ModuleName)
                .IsRequired()
                .HasColumnName("MODULE_NAME")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ObjectCode)
                .IsRequired()
                .HasColumnName("OBJECT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
