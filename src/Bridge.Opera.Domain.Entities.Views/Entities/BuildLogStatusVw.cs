namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class BuildLogStatusVw
{
    public string Code { get; set; }
    public string Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<BuildLogStatusVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("BUILD_LOG_STATUS_VW");

            entity.Property(e => e.Code)
                .HasColumnName("CODE")
                .HasMaxLength(13)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(900)
                .IsUnicode(false);
        });
	}
}
