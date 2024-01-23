namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class Nationalities
{
    public string Nationality { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<Nationalities>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NATIONALITIES");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Nationality)
                .IsRequired()
                .HasColumnName("NATIONALITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");
        });
	}
}
