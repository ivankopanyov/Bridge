namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class DefaultDelvMarkups
{
    public string? DeliveryType { get; set; }
    public string? MarkupType { get; set; }
    public string? MarkupScript { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<DefaultDelvMarkups>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DEFAULT_DELV_MARKUPS");

            entity.Property(e => e.DeliveryType)
                .HasColumnName("DELIVERY_TYPE")
                .HasColumnType("CHAR(12)");

            entity.Property(e => e.MarkupScript)
                .HasColumnName("MARKUP_SCRIPT")
                .HasColumnType("CHAR(1061)");

            entity.Property(e => e.MarkupType)
                .HasColumnName("MARKUP_TYPE")
                .HasColumnType("CHAR(9)");
        });
	}
}
