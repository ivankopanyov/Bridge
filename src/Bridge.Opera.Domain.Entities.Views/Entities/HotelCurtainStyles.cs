namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class HotelCurtainStyles
{
    public string Code { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HotelCurtainStyles>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HOTEL_CURTAIN_STYLES");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(24)
                .IsUnicode(false);
        });
	}
}
