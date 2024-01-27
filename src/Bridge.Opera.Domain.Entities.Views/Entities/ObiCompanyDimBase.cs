namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiCompanyDimBase
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string RegionCode { get; set; }
    public string RegionDesc { get; set; }
    public string CountryCode { get; set; }
    public string CountryDesc { get; set; }
    public decimal Company { get; set; }
    public string CompanyDesc { get; set; }
    public decimal CompanyId { get; set; }
    public string CompanyCharId { get; set; }
    public string ResortId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiCompanyDimBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_COMPANY_DIM_BASE");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Company)
                .HasColumnName("COMPANY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CompanyCharId)
                .HasColumnName("COMPANY_CHAR_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.CompanyDesc)
                .HasColumnName("COMPANY_DESC")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.CompanyId)
                .HasColumnName("COMPANY_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
