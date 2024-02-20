namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class SidAddresscleanseConfigSys
{
    public string? Customerid { get; set; }
    public string? Password { get; set; }
    public string? Campaignid { get; set; }
    public string? Jobtoken { get; set; }
    public string? Countryoforigin { get; set; }
    public string? Streetwithhno { get; set; }
    public string? Countrytype { get; set; }
    public string? Lineseparator { get; set; }
    public string? Preferredlanguage { get; set; }
    public string? Capitalization { get; set; }
    public string? Httpserver { get; set; }
    public string? ServiceType { get; set; }
    public string? HttpserverBatch { get; set; }
    public string? HttpserverFast { get; set; }
    public string? Httpaction { get; set; }
    public string? HttpactionBatch { get; set; }
    public string? HttpactionFast { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SidAddresscleanseConfigSys>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SID_ADDRESSCLEANSE_CONFIG_SYS");

            entity.Property(e => e.Campaignid)
                .HasColumnName("CAMPAIGNID")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Capitalization)
                .HasColumnName("CAPITALIZATION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Countryoforigin)
                .HasColumnName("COUNTRYOFORIGIN")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Countrytype)
                .HasColumnName("COUNTRYTYPE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Customerid)
                .HasColumnName("CUSTOMERID")
                .IsUnicode(false);

            entity.Property(e => e.Httpaction)
                .HasColumnName("HTTPACTION")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.HttpactionBatch)
                .HasColumnName("HTTPACTION_BATCH")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.HttpactionFast)
                .HasColumnName("HTTPACTION_FAST")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Httpserver)
                .HasColumnName("HTTPSERVER")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.HttpserverBatch)
                .HasColumnName("HTTPSERVER_BATCH")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.HttpserverFast)
                .HasColumnName("HTTPSERVER_FAST")
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Jobtoken)
                .HasColumnName("JOBTOKEN")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Lineseparator)
                .HasColumnName("LINESEPARATOR")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .IsUnicode(false);

            entity.Property(e => e.Preferredlanguage)
                .HasColumnName("PREFERREDLANGUAGE")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ServiceType)
                .HasColumnName("SERVICE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Streetwithhno)
                .HasColumnName("STREETWITHHNO")
                .HasMaxLength(10)
                .IsUnicode(false);
        });
	}
}
