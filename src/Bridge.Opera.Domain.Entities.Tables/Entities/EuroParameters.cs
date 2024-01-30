namespace Bridge.Opera.Domain.Entities.Tables;

public partial class EuroParameters
{
    public string? Resort { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<EuroParameters>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EURO_PARAMETERS");

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Username)
                .HasColumnName("USERNAME")
                .HasMaxLength(40)
                .IsUnicode(false);
        });
	}
}
