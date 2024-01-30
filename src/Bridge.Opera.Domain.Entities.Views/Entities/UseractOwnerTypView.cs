namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UseractOwnerTypView
{
    public string? ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UseractOwnerTypView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USERACT_OWNER_TYP_VIEW");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(22)
                .IsUnicode(false);
        });
	}
}
