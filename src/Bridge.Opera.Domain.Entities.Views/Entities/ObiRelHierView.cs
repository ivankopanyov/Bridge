namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiRelHierView
{
    public string? NameType { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiRelHierView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_REL_HIER_VIEW");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameType)
                .IsRequired()
                .HasColumnName("NAME_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
