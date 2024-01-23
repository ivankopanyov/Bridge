namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsSession
{
    public decimal SessionId { get; set; }
    public DateTime SessionExpiration { get; set; }
    public DateTime SessionCreated { get; set; }
    public DateTime? SessionModified { get; set; }
    public decimal? NameId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsSession>(entity =>
        {
            entity.HasKey(e => e.SessionId)
                .HasName("OWS_SESSION_PK");

            entity.ToTable("OWS_SESSION");

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SessionCreated)
                .HasColumnName("SESSION_CREATED")
                .HasColumnType("DATE");

            entity.Property(e => e.SessionExpiration)
                .HasColumnName("SESSION_EXPIRATION")
                .HasColumnType("DATE");

            entity.Property(e => e.SessionModified)
                .HasColumnName("SESSION_MODIFIED")
                .HasColumnType("DATE");
        });
	}
}
