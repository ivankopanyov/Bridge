namespace Bridge.Opera.Domain.Entities.Tables;

public partial class TlpeConfig
{
    public string? UserId { get; set; }
    public string? Password { get; set; }
    public string? Url { get; set; }
    public string? Httpaction { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<TlpeConfig>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TLPE_CONFIG");

            entity.Property(e => e.Httpaction)
                .HasColumnName("HTTPACTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Url)
                .HasColumnName("URL")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
