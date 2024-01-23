namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OperaEcertsAction
{
    public decimal ActionInstanceId { get; set; }
    public string Resort { get; set; }
    public decimal CertId { get; set; }
    public string ActionType { get; set; }
    public string Machine { get; set; }
    public string Terminal { get; set; }
    public string ActionDescription { get; set; }
    public string Module { get; set; }
    public DateTime? BusinessDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public string ForChainCode { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OperaEcertsAction>(entity =>
        {
            entity.HasKey(e => e.ActionInstanceId)
                .HasName("OEA_PK");

            entity.ToTable("OPERA_ECERTS_ACTION");

            entity.HasIndex(e => e.InsertDate)
                .HasName("ECA_IDX3");

            entity.HasIndex(e => new { e.CertId, e.ActionType })
                .HasName("ECA_IDX2");

            entity.HasIndex(e => new { e.Resort, e.CertId, e.ActionType })
                .HasName("ECA_IDX1");

            entity.Property(e => e.ActionInstanceId)
                .HasColumnName("ACTION_INSTANCE_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActionDescription)
                .HasColumnName("ACTION_DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasColumnName("ACTION_TYPE")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BusinessDate)
                .HasColumnName("BUSINESS_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CertId)
                .HasColumnName("CERT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ForChainCode)
                .HasColumnName("FOR_CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Machine)
                .HasColumnName("MACHINE")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Module)
                .HasColumnName("MODULE")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Terminal)
                .HasColumnName("TERMINAL")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
