namespace Bridge.Opera.Domain.Entities.Tables;

public partial class HttpsCertificates
{
    public string Resort { get; set; }
    public string Provider { get; set; }
    public string Certificate { get; set; }
    public string CertificateType { get; set; }
    public decimal? ChainSequence { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? UpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<HttpsCertificates>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.Provider })
                .HasName("HTTPS_CERT_PK");

            entity.ToTable("HTTPS_CERTIFICATES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Provider)
                .HasColumnName("PROVIDER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Certificate)
                .IsRequired()
                .HasColumnName("CERTIFICATE")
                .IsUnicode(false);

            entity.Property(e => e.CertificateType)
                .HasColumnName("CERTIFICATE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainSequence)
                .HasColumnName("CHAIN_SEQUENCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
