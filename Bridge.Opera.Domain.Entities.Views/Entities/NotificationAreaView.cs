namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NotificationAreaView
{
    public string Code { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NotificationAreaView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NOTIFICATION_AREA_VIEW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(11)
                .IsUnicode(false);
        });
	}
}
