namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiAccountDim
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public decimal? NameId { get; set; }
    public string? Name { get; set; }
    public string? Country { get; set; }
    public string? CountryDesc { get; set; }
    public string? RegionCode { get; set; }
    public string? RegionDesc { get; set; }
    public string? AccountType { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiAccountDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_ACCOUNT_DIM");

            entity.Property(e => e.AccountType)
                .HasColumnName("ACCOUNT_TYPE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(125)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
