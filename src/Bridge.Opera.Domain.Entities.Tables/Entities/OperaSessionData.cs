namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaSessionData
{
    public decimal? SessionId { get; set; }
    public string? XmlData { get; set; }
    public string? ExternalId { get; set; }
    public DateTime? CreatedOn { get; set; }
    public DateTime? ExpiresOn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaSessionData>(entity =>
        {
            entity.HasKey(e => e.SessionId)
                .HasName("OPERA_SESSION_DATA_PK");

            entity.ToTable("OPERA_SESSION_DATA");

            entity.Property(e => e.SessionId)
                .HasColumnName("SESSION_ID")
                .HasColumnType("NUMBER(38)")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CreatedOn)
                .HasColumnName("CREATED_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.ExpiresOn)
                .HasColumnName("EXPIRES_ON")
                .HasColumnType("DATE");

            entity.Property(e => e.ExternalId)
                .IsRequired()
                .HasColumnName("EXTERNAL_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.XmlData)
                .IsRequired()
                .HasColumnName("XML_DATA")
                .HasColumnType("CLOB");
        });
	}
}
