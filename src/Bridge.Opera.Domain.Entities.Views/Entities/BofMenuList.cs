namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BofMenuList
{
    public string AttributeCode { get; set; }
    public string MenuItem { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BofMenuList>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BOF_MENU_LIST");

            entity.Property(e => e.AttributeCode)
                .IsRequired()
                .HasColumnName("ATTRIBUTE_CODE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MenuItem)
                .HasColumnName("MENU_ITEM")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
