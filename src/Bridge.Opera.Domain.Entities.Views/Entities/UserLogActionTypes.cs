namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UserLogActionTypes
{
    public string? ActionTypeDescription { get; set; }
    public string? ActionType { get; set; }
    public string? ActionGroup { get; set; }
    public string? ActionGroupDescription { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserLogActionTypes>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USER_LOG_ACTION_TYPES");

            entity.Property(e => e.ActionGroup)
                .HasColumnName("ACTION_GROUP")
                .HasMaxLength(17)
                .IsUnicode(false);

            entity.Property(e => e.ActionGroupDescription)
                .HasColumnName("ACTION_GROUP_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(34)
                .IsUnicode(false);

            entity.Property(e => e.ActionTypeDescription)
                .HasColumnName("ACTION_TYPE_DESCRIPTION")
                .IsUnicode(false);
        });
	}
}
