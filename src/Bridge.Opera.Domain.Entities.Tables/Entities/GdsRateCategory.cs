namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateCategory
{
    public string? GdsHost { get; set; }
    public string? GdsRateCategory1 { get; set; }
    public string? GdsShoppingCategory { get; set; }
    public string? Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string? NegotiatedOnly { get; set; }
    public string? CredentialReqYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateCategory>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.GdsRateCategory1 })
                .HasName("GDS_RATE_CATEGORY_PK1");

            entity.ToTable("GDS_RATE_CATEGORY");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GdsRateCategory1)
                .HasColumnName("GDS_RATE_CATEGORY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CredentialReqYn)
                .HasColumnName("CREDENTIAL_REQ_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.GdsShoppingCategory)
                .IsRequired()
                .HasColumnName("GDS_SHOPPING_CATEGORY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NegotiatedOnly)
                .HasColumnName("NEGOTIATED_ONLY")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
