namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class EventMenuitemDepartment1
{
    public decimal EmdId { get; set; }
    public string Resort { get; set; }
    public string DeptId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EventMenuitemDepartment1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EVENT_MENUITEM_DEPARTMENT");

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EmdId)
                .HasColumnName("EMD_ID")
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
