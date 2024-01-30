namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class TravelerView
{
    public decimal? NameId { get; set; }
    public string? Sname { get; set; }
    public string? Sfirst { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
    public string? First { get; set; }
    public string? Middle { get; set; }
    public string? Title { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TravelerView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TRAVELER_VIEW");

            entity.Property(e => e.DisplayName)
                .HasColumnName("DISPLAY_NAME")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.First)
                .HasColumnName("FIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Middle)
                .HasColumnName("MIDDLE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Sfirst)
                .HasColumnName("SFIRST")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Sname)
                .HasColumnName("SNAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasColumnName("TITLE")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
