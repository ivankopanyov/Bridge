namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class AgentByBooking
{
    public string? Resort { get; set; }
    public decimal? BookingId { get; set; }
    public decimal? AgentId { get; set; }
    public string? AgentName { get; set; }
    public string? AgentName3 { get; set; }
    public string? AgentName2 { get; set; }
    public string? AgentAddress1 { get; set; }
    public string? AgentAddress2 { get; set; }
    public string? AgentState { get; set; }
    public string? AgentCountry { get; set; }
    public string? AgentCity { get; set; }
    public string? AgentCityExt { get; set; }
    public string? AgentZipCode { get; set; }
    public string? AgentFaxNo { get; set; }
    public string? AgentPhoneNo { get; set; }
    public string? AgentEmailId { get; set; }
    public string? IataCorpNo { get; set; }
    public string? XagentName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<AgentByBooking>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AGENT_BY_BOOKING");

            entity.Property(e => e.AgentAddress1)
                .HasColumnName("AGENT_ADDRESS1")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentAddress2)
                .HasColumnName("AGENT_ADDRESS2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentCity)
                .HasColumnName("AGENT_CITY")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentCityExt)
                .HasColumnName("AGENT_CITY_EXT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentCountry)
                .HasColumnName("AGENT_COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AgentEmailId)
                .HasColumnName("AGENT_EMAIL_ID")
                .IsUnicode(false);

            entity.Property(e => e.AgentFaxNo)
                .HasColumnName("AGENT_FAX_NO")
                .IsUnicode(false);

            entity.Property(e => e.AgentId)
                .HasColumnName("AGENT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AgentName)
                .HasColumnName("AGENT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentName2)
                .HasColumnName("AGENT_NAME2")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentName3)
                .HasColumnName("AGENT_NAME3")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.AgentPhoneNo)
                .HasColumnName("AGENT_PHONE_NO")
                .IsUnicode(false);

            entity.Property(e => e.AgentState)
                .HasColumnName("AGENT_STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.AgentZipCode)
                .HasColumnName("AGENT_ZIP_CODE")
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.Property(e => e.BookingId)
                .HasColumnName("BOOKING_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.IataCorpNo)
                .HasColumnName("IATA_CORP_NO")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.XagentName)
                .HasColumnName("XAGENT_NAME")
                .HasMaxLength(80)
                .IsUnicode(false);
        });
	}
}
