namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class InactiveBeActionTypeView
{
    public string? ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<InactiveBeActionTypeView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("INACTIVE_BE_ACTION_TYPE_VIEW");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(240)
                .IsUnicode(false);
        });
	}
}
