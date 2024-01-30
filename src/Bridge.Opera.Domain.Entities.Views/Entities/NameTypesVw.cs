namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NameTypesVw
{
    public string? NameType { get; set; }
    public string? Description { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NameTypesVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NAME_TYPES_VW");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.Property(e => e.NameType)
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
