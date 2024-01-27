namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IfcCertSetup
{
    public decimal Id { get; set; }
    public string Resort { get; set; }
    public string Host { get; set; }
    public string Message { get; set; }
    public string Fix { get; set; }
    public string ErrorYn { get; set; }
    public DateTime InsertDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IfcCertSetup>(entity =>
        {
            entity.ToTable("IFC_CERT_SETUP");

            entity.Property(e => e.Id)
                .HasColumnName("ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ErrorYn)
                .HasColumnName("ERROR_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Fix)
                .HasColumnName("FIX")
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Host)
                .HasColumnName("HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.Message)
                .HasColumnName("MESSAGE")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
