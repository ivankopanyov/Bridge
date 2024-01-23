namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AccountRelationView
{
    public decimal? NameXrefId { get; set; }
    public string Name { get; set; }
    public decimal? DetailNameId { get; set; }
    public decimal? MasterNameId { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Ntype { get; set; }
    public string Relationship { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AccountRelationView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ACCOUNT_RELATION_VIEW");

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DetailNameId)
                .HasColumnName("DETAIL_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MasterNameId)
                .HasColumnName("MASTER_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameXrefId)
                .HasColumnName("NAME_XREF_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Ntype)
                .HasColumnName("NTYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Relationship)
                .HasColumnName("RELATIONSHIP")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
