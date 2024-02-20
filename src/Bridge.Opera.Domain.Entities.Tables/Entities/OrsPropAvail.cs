namespace Bridge.Opera.Domain.Entities.Tables;

public partial class OrsPropAvail
{
    public decimal? RequestId { get; set; }
    public string? Resort { get; set; }
    public string? Name { get; set; }
    public string? ResortType { get; set; }
    public string? ChainCode { get; set; }
    public string? Location { get; set; }
    public string? Feature1 { get; set; }
    public string? Feature2 { get; set; }
    public string? Feature3 { get; set; }
    public string? Feature4 { get; set; }
    public string? Feature5 { get; set; }
    public string? Feature6 { get; set; }
    public string? Feature7 { get; set; }
    public string? Feature8 { get; set; }
    public string? Feature9 { get; set; }
    public string? Feature10 { get; set; }
    public decimal? Availability { get; set; }
    public decimal? ToSell { get; set; }
    public string? PropertyAvailabilityYn { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal? LowRate { get; set; }
    public decimal? HighRate { get; set; }
    public string? CurrencyCode { get; set; }
    public decimal? Distance { get; set; }
    public string? DistanceType { get; set; }
    public string? NegotiatedYn { get; set; }
    public string? AlternateYn { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<OrsPropAvail>(entity =>
        {
            entity.HasKey(e => new { e.RequestId, e.Resort })
                .HasName("ORS_PROP_AVAIL_PK");

            entity.ToTable("ORS_PROP_AVAIL");

            entity.Property(e => e.RequestId)
                .HasColumnName("REQUEST_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AlternateYn)
                .HasColumnName("ALTERNATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.Availability)
                .HasColumnName("AVAILABILITY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Distance)
                .HasColumnName("DISTANCE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DistanceType)
                .HasColumnName("DISTANCE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Feature1)
                .HasColumnName("FEATURE1")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Feature10)
                .HasColumnName("FEATURE10")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Feature2)
                .HasColumnName("FEATURE2")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Feature3)
                .HasColumnName("FEATURE3")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Feature4)
                .HasColumnName("FEATURE4")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Feature5)
                .HasColumnName("FEATURE5")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Feature6)
                .HasColumnName("FEATURE6")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Feature7)
                .HasColumnName("FEATURE7")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Feature8)
                .HasColumnName("FEATURE8")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Feature9)
                .HasColumnName("FEATURE9")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.HighRate)
                .HasColumnName("HIGH_RATE")
                .HasColumnType("NUMBER(30,3)");

            entity.Property(e => e.Location)
                .HasColumnName("LOCATION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.LowRate)
                .HasColumnName("LOW_RATE")
                .HasColumnType("NUMBER(30,3)");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NegotiatedYn)
                .HasColumnName("NEGOTIATED_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'N'");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PropertyAvailabilityYn)
                .HasColumnName("PROPERTY_AVAILABILITY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ResortType)
                .HasColumnName("RESORT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ToSell)
                .HasColumnName("TO_SELL")
                .HasColumnType("NUMBER");
        });
	}
}
