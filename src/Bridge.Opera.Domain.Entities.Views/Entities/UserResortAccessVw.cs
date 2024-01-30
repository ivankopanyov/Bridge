namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class UserResortAccessVw
{
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<UserResortAccessVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("USER_RESORT_ACCESS_VW");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
