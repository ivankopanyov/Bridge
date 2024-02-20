namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UseractProfileTypView
{
    public string? ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UseractProfileTypView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USERACT_PROFILE_TYP_VIEW");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(28)
                .IsUnicode(false);
        });
	}
}
