namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class OsaActivityTypesView
{
    public string? Resort { get; set; }
    public string? ActivityType { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OsaActivityTypesView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OSA_ACTIVITY_TYPES_VIEW");

            entity.Property(e => e.ActivityType)
                .IsRequired()
                .HasColumnName("ACTIVITY_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
