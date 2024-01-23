namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SimpleDynScreens
{
    public string ScreenName { get; set; }
    public string Description { get; set; }
    public string NewScreenYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SimpleDynScreens>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SIMPLE_DYN_SCREENS");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(33)
                .IsUnicode(false);

            entity.Property(e => e.NewScreenYn)
                .HasColumnName("NEW_SCREEN_YN")
                .HasColumnType("CHAR(1)");

            entity.Property(e => e.ScreenName)
                .HasColumnName("SCREEN_NAME")
                .HasMaxLength(14)
                .IsUnicode(false);
        });
	}
}
