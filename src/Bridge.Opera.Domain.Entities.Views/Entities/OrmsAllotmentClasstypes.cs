namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OrmsAllotmentClasstypes
{
    public string? ClassType { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrmsAllotmentClasstypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ORMS_ALLOTMENT_CLASSTYPES");

            entity.Property(e => e.ClassType)
                .HasColumnName("CLASS_TYPE")
                .HasColumnType("CHAR(2)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(12)
                .IsUnicode(false);
        });
	}
}
