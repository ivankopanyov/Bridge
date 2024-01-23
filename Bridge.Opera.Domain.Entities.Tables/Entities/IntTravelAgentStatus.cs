namespace Bridge.Opera.Domain.Entities.Tables;

public partial class IntTravelAgentStatus
{
    public decimal? NameId { get; set; }
    public string IataNumber { get; set; }
    public string TravelAgentName { get; set; }
    public string Status { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<IntTravelAgentStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("INT_TRAVEL_AGENT_STATUS");

            entity.Property(e => e.IataNumber)
                .HasColumnName("IATA_NUMBER")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.TravelAgentName)
                .HasColumnName("TRAVEL_AGENT_NAME")
                .HasMaxLength(100)
                .IsUnicode(false);
        });
	}
}
