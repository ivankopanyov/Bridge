namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiTravelAgentDimVw
{
    public string AllCode { get; set; }
    public string AllDesc { get; set; }
    public string RegionCode { get; set; }
    public string RegionDesc { get; set; }
    public string CountryCode { get; set; }
    public string CountryDesc { get; set; }
    public decimal? TravelAgent { get; set; }
    public string TaDesc { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string TravelAgentCharId { get; set; }
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
    public string ResortId { get; set; }
    public string AllKey { get; set; }
    public string RegionKey { get; set; }
    public string CountryKey { get; set; }
    public string TravelAgentKey { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiTravelAgentDimVw>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_TRAVEL_AGENT_DIM_VW");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

            entity.Property(e => e.AllKey)
                .HasColumnName("ALL_KEY")
                .IsUnicode(false);

            entity.Property(e => e.CountryCode)
                .HasColumnName("COUNTRY_CODE")
                .IsUnicode(false);

            entity.Property(e => e.CountryDesc)
                .HasColumnName("COUNTRY_DESC")
                .IsUnicode(false);

            entity.Property(e => e.CountryKey)
                .HasColumnName("COUNTRY_KEY")
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

            entity.Property(e => e.RegionCode)
                .HasColumnName("REGION_CODE")
                .IsUnicode(false);

            entity.Property(e => e.RegionDesc)
                .HasColumnName("REGION_DESC")
                .IsUnicode(false);

            entity.Property(e => e.RegionKey)
                .HasColumnName("REGION_KEY")
                .IsUnicode(false);

            entity.Property(e => e.ResortId)
                .HasColumnName("RESORT_ID")
                .IsUnicode(false);

            entity.Property(e => e.TaDesc)
                .HasColumnName("TA_DESC")
                .IsUnicode(false);

            entity.Property(e => e.TravelAgent)
                .HasColumnName("TRAVEL_AGENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentCharId)
                .HasColumnName("TRAVEL_AGENT_CHAR_ID")
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentKey)
                .HasColumnName("TRAVEL_AGENT_KEY")
                .IsUnicode(false);
        });
	}
}
