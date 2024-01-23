namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OwsSessionDetail
{
    public decimal SessionId { get; set; }
    public string SessionData { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OwsSessionDetail>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OWS_SESSION_DETAIL");

            entity.HasIndex(e => e.SessionId)
                .HasName("OWS_SESSION_DETAIL_IND1");

            entity.Property(e => e.SessionData)
                .HasColumnName("SESSION_DATA")
                .HasColumnType("CLOB");

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER");
        });
	}
}
