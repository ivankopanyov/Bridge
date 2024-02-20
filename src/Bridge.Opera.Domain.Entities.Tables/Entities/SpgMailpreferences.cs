namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SpgMailpreferences
{
    public string? EmCode { get; set; }
    public string? Description { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpgMailpreferences>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SPG_MAILPREFERENCES");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.EmCode)
                .IsRequired()
                .HasColumnName("EM_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
