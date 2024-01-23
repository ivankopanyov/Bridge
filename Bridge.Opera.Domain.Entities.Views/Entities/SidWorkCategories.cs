namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidWorkCategories
{
    public string Resort { get; set; }
    public string CategoryCode { get; set; }
    public string Description { get; set; }
    public string Printer { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidWorkCategories>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_WORK_CATEGORIES");

            entity.Property(e => e.CategoryCode)
                .IsRequired()
                .HasColumnName("CATEGORY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Printer)
                .HasColumnName("PRINTER")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
