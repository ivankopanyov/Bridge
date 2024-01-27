namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ItalianProfileStatV
{
    public decimal ResvNameId { get; set; }
    public decimal NameId { get; set; }
    public string IsoCountry { get; set; }
    public string Country { get; set; }
    public string CountryName { get; set; }
    public string State { get; set; }
    public string StateName { get; set; }
    public decimal? NoOfSharers { get; set; }
    public decimal? Adults { get; set; }
    public string Name { get; set; }
    public string Room { get; set; }
    public decimal? AddressId { get; set; }
    public string ResvStatus { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ItalianProfileStatV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ITALIAN_PROFILE_STAT_V");

            entity.Property(e => e.AddressId)
                .HasColumnName("ADDRESS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Adults)
                .HasColumnName("ADULTS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Country)
                .HasColumnName("COUNTRY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CountryName)
                .HasColumnName("COUNTRY_NAME")
                .IsUnicode(false);

            entity.Property(e => e.IsoCountry)
                .HasColumnName("ISO_COUNTRY")
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NoOfSharers)
                .HasColumnName("NO_OF_SHARERS")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvNameId)
                .HasColumnName("RESV_NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ResvStatus)
                .IsRequired()
                .HasColumnName("RESV_STATUS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Room)
                .HasColumnName("ROOM")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasColumnName("STATE")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StateName)
                .HasColumnName("STATE_NAME")
                .IsUnicode(false);
        });
	}
}
