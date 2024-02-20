namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UseractRvTypView
{
    public string? ActionType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UseractRvTypView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USERACT_RV_TYP_VIEW");

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(34)
                .IsUnicode(false);
        });
	}
}
