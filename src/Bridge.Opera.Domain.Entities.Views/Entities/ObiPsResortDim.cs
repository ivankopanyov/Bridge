namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiPsResortDim
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string ChainCode { get; set; }
    public string ChainDesc { get; set; }
    public string RegionCode { get; set; }
    public string Region { get; set; }
    public string RegionDesc { get; set; }
    public string CountryCode { get; set; }
    public string Country { get; set; }
    public string CountryDesc { get; set; }
    public string State { get; set; }
    public string StateDesc { get; set; }
    public string City { get; set; }
    public string CityDesc { get; set; }
    public string Resort { get; set; }
    public string ResortDesc { get; set; }
    public string ResortLongDesc { get; set; }
    public string PostCode { get; set; }
    public string ResortType { get; set; }
    public string Ownership { get; set; }
    public string CurrencyCode { get; set; }
    public string CustomCol1 { get; set; }
    public string CustomDesc1 { get; set; }
    public string CustomLabel1 { get; set; }
    public string CustomCol2 { get; set; }
    public string CustomDesc2 { get; set; }
    public string CustomLabel2 { get; set; }
    public string CustomCol3 { get; set; }
    public string CustomDesc3 { get; set; }
    public string CustomLabel3 { get; set; }
    public string CustomCol4 { get; set; }
    public string CustomDesc4 { get; set; }
    public string CustomLabel4 { get; set; }
    public string CustomCol5 { get; set; }
    public string CustomDesc5 { get; set; }
    public string CustomLabel5 { get; set; }
    public string CustomCol6 { get; set; }
    public string CustomDesc6 { get; set; }
    public string CustomLabel6 { get; set; }
    public string CustomCol7 { get; set; }
    public string CustomDesc7 { get; set; }
    public string CustomLabel7 { get; set; }
    public string CustomCol8 { get; set; }
    public string CustomDesc8 { get; set; }
    public string CustomLabel8 { get; set; }
    public string CustomCol9 { get; set; }
    public string CustomDesc9 { get; set; }
    public string CustomLabel9 { get; set; }
    public string CustomCol10 { get; set; }
    public string CustomDesc10 { get; set; }
    public string CustomLabel10 { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiPsResortDim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_PS_RESORT_DIM");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .IsUnicode(false);

            entity.Property(e => e.ChainDesc)
                .HasColumnName("CHAIN_DESC")
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .IsUnicode(false);

            entity.Property(e => e.CityDesc)
                .HasColumnName("CITY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CustomCol1)
                .HasColumnName("CUSTOM_COL_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol10)
                .HasColumnName("CUSTOM_COL_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol2)
                .HasColumnName("CUSTOM_COL_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol3)
                .HasColumnName("CUSTOM_COL_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol4)
                .HasColumnName("CUSTOM_COL_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol5)
                .HasColumnName("CUSTOM_COL_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol6)
                .HasColumnName("CUSTOM_COL_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol7)
                .HasColumnName("CUSTOM_COL_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol8)
                .HasColumnName("CUSTOM_COL_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomCol9)
                .HasColumnName("CUSTOM_COL_9")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc1)
                .HasColumnName("CUSTOM_DESC_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc10)
                .HasColumnName("CUSTOM_DESC_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc2)
                .HasColumnName("CUSTOM_DESC_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc3)
                .HasColumnName("CUSTOM_DESC_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc4)
                .HasColumnName("CUSTOM_DESC_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc5)
                .HasColumnName("CUSTOM_DESC_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc6)
                .HasColumnName("CUSTOM_DESC_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc7)
                .HasColumnName("CUSTOM_DESC_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc8)
                .HasColumnName("CUSTOM_DESC_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomDesc9)
                .HasColumnName("CUSTOM_DESC_9")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel1)
                .HasColumnName("CUSTOM_LABEL_1")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel10)
                .HasColumnName("CUSTOM_LABEL_10")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel2)
                .HasColumnName("CUSTOM_LABEL_2")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel3)
                .HasColumnName("CUSTOM_LABEL_3")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel4)
                .HasColumnName("CUSTOM_LABEL_4")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel5)
                .HasColumnName("CUSTOM_LABEL_5")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel6)
                .HasColumnName("CUSTOM_LABEL_6")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel7)
                .HasColumnName("CUSTOM_LABEL_7")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel8)
                .HasColumnName("CUSTOM_LABEL_8")
                .IsUnicode(false);

            entity.Property(e => e.CustomLabel9)
                .HasColumnName("CUSTOM_LABEL_9")
                .IsUnicode(false);

            entity.Property(e => e.Ownership)
                .HasColumnName("OWNERSHIP")
                .IsUnicode(false);

            entity.Property(e => e.PostCode)
                .HasColumnName("POST_CODE")
                .IsUnicode(false);

            entity.Property(e => e.Region)
                .HasColumnName("REGION")
                .IsUnicode(false);

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ResortDesc)
                .HasColumnName("RESORT_DESC")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.ResortLongDesc)
                .HasColumnName("RESORT_LONG_DESC")
                .HasMaxLength(123)
                .IsUnicode(false);

            entity.Property(e => e.ResortType)
                .HasColumnName("RESORT_TYPE")
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .IsUnicode(false);

            entity.Property(e => e.StateDesc)
                .HasColumnName("STATE_DESC")
                .IsUnicode(false);
        });
	}
}
