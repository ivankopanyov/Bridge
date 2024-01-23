namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class YesNoView
{
    public string Code { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<YesNoView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("YES_NO_VIEW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
