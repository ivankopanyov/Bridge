namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class IfcSpecView
{
    public string? Resort { get; set; }
    public string? DbfLogo { get; set; }
    public int? RowNum { get; set; }
    public string? Selector { get; set; }
    public string? Spec { get; set; }
    public string? Priority { get; set; }
    public string? Position { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcSpecView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("IFC_SPEC_VIEW");

            entity.Property(e => e.DbfLogo)
                .HasColumnName("DBF_LOGO")
                .HasMaxLength(6)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Position)
                .HasColumnName("POSITION")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Priority)
                .HasColumnName("PRIORITY")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RowNum)
                .HasColumnName("ROW_NUM")
                .HasColumnType("NUMBER(6)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Selector)
                .HasColumnName("SELECTOR")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Spec)
                .HasColumnName("SPEC")
                .HasMaxLength(300)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        });
	}
}
