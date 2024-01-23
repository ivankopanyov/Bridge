namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UserMessageEventVw
{
    public string EventName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserMessageEventVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USER_MESSAGE_EVENT_VW");

            entity.Property(e => e.EventName)
                .HasColumnName("EVENT_NAME")
                .HasMaxLength(23)
                .IsUnicode(false);
        });
	}
}
