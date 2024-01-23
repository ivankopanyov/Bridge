namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SecurityKeyLog
{
    public string AppUser { get; set; }
    public string LoggedSecurityKey { get; set; }
    public DateTime LastLoggedTimestamp { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SecurityKeyLog>(entity =>
        {
            entity.HasKey(e => new { e.AppUser, e.LoggedSecurityKey })
                .HasName("SECURITY_KEY_LOG_PK");

            entity.ToTable("SECURITY_KEY_LOG");

            entity.HasIndex(e => e.LastLoggedTimestamp)
                .HasName("SECURITY_KEY_LOG_IND1");

            entity.Property(e => e.AppUser)
                .HasColumnName("APP_USER")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LoggedSecurityKey)
                .HasColumnName("LOGGED_SECURITY_KEY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LastLoggedTimestamp)
                .HasColumnName("LAST_LOGGED_TIMESTAMP")
                .HasColumnType("DATE");
        });
	}
}
