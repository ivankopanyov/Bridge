namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ProtectedItemsVw
{
    public string TemplateCode { get; set; }
    public string TemplateGroupCode { get; set; }
    public string NameType { get; set; }
    public string ProtectedFor { get; set; }
    public string ObjectCode { get; set; }
    public string UserActionList { get; set; }
    public string DisplayName { get; set; }
    public string SupportedActionList { get; set; }
    public string ModuleName { get; set; }
    public string ItemName { get; set; }
    public string ItemType { get; set; }
    public string ItemActionList { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ProtectedItemsVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PROTECTED_ITEMS_VW");

            entity.Property(e => e.DisplayName)
                .IsRequired()
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ItemActionList)
                .HasColumnName("ITEM_ACTION_LIST")
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

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ObjectCode)
                .IsRequired()
                .HasColumnName("OBJECT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProtectedFor)
                .HasColumnName("PROTECTED_FOR")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SupportedActionList)
                .HasColumnName("SUPPORTED_ACTION_LIST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TemplateCode)
                .IsRequired()
                .HasColumnName("TEMPLATE_CODE")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.TemplateGroupCode)
                .HasColumnName("TEMPLATE_GROUP_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UserActionList)
                .HasColumnName("USER_ACTION_LIST")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
