namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ObiTravelAgentDimBase
{
    public string? AllCode { get; set; }
    public string? AllDesc { get; set; }
    public string? RegionCode { get; set; }
    public string? RegionDesc { get; set; }
    public string? CountryCode { get; set; }
    public string? CountryDesc { get; set; }
    public decimal? TravelAgent { get; set; }
    public string? TaDesc { get; set; }
    public decimal? TravelAgentId { get; set; }
    public string? TravelAgentCharId { get; set; }
    public string? ResortId { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ObiTravelAgentDimBase>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OBI_TRAVEL_AGENT_DIM_BASE");

            entity.Property(e => e.AllCode)
                .HasColumnName("ALL_CODE")
                .IsUnicode(false);

            entity.Property(e => e.AllDesc)
                .HasColumnName("ALL_DESC")
                .IsUnicode(false);

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

            entity.Property(e => e.TaDesc)
                .HasColumnName("TA_DESC")
                .HasMaxLength(122)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgent)
                .HasColumnName("TRAVEL_AGENT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.TravelAgentCharId)
                .HasColumnName("TRAVEL_AGENT_CHAR_ID")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentId)
                .HasColumnName("TRAVEL_AGENT_ID")
                .HasColumnType("NUMBER");
        });
	}
}
