namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveActionTypeView
{
    public string? Module { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveActionTypeView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_ACTION_TYPE_VIEW");

            entity.Property(e => e.Module)
                .IsRequired()
                .HasColumnName("MODULE")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
