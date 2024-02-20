namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class GemItemDepartment1
{
    public string? Resort { get; set; }
    public decimal? ItemId { get; set; }
    public string? DeptId { get; set; }
    public string? TraceText { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemDepartment1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GEM_ITEM_DEPARTMENT");

            entity.Property(e => e.DeptId)
                .IsRequired()
                .HasColumnName("DEPT_ID")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ItemId)
                .HasColumnName("ITEM_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TraceText)
                .HasColumnName("TRACE_TEXT")
                .HasMaxLength(2000)
                .IsUnicode(false);
        });
	}
}
