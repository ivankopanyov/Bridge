namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GuestLoginDomains
{
    public string DomainCode { get; set; }
    public string DomainName { get; set; }
    public string ChainCode { get; set; }
    public string IfcYn { get; set; }
    public string DatabaseId { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string DefaultYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GuestLoginDomains>(entity =>
        {
            entity.HasKey(e => e.DomainCode)
                .HasName("GLN_PK");

            entity.ToTable("GUEST_LOGIN_DOMAINS");

            entity.Property(e => e.DomainCode)
                .HasColumnName("DOMAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DatabaseId)
                .HasColumnName("DATABASE_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DefaultYn)
                .HasColumnName("DEFAULT_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DomainName)
                .HasColumnName("DOMAIN_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.IfcYn)
                .HasColumnName("IFC_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

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
