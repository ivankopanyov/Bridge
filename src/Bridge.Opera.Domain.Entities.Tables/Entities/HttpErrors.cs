namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HttpErrors
{
    public decimal? Id { get; set; }
    public string? XmlResponse { get; set; }
    public string? ErrMsg { get; set; }
    public DateTime? ErrorDate { get; set; }
    public string? Resort { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HttpErrors>(entity =>
        {
            entity.ToTable("HTTP_ERRORS");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ErrMsg)
                .HasColumnName("ERR_MSG")
                .IsUnicode(false);

            entity.Property(e => e.ErrorDate)
                .HasColumnName("ERROR_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XmlResponse)
                .HasColumnName("XML_RESPONSE")
                .HasColumnType("CLOB");
        });
	}
}
