namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventItemDepartment1
{
    public string Resort { get; set; }
    public decimal EventItemId { get; set; }
    public string DeptId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventItemDepartment1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_ITEM_DEPARTMENT");

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EventItemId)
                .HasColumnName("EVENT_ITEM_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
