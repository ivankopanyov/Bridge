namespace Bridge.Opera.Infrastructure;

public class OperaDbContext(string connectioString) : OperaDbContextBase()
{
    public virtual DbSet<ReservationName> ReservationNames { get; set; }

    public virtual DbSet<Name> Names { get; set; }

    public virtual DbSet<Businessdate> Businessdates { get; set; }

    public virtual DbSet<ReservationDailyElementName> ReservationDailyElementNames { get; set; }

    public virtual DbSet<ReservationDailyElements> ReservationDailyElements { get; set; }

    public virtual DbSet<ResortRoomCategory> ResortRoomCategories { get; set; }

    public virtual DbSet<ResortRoomClasses> ResortRoomClasses { get; set; }

    public virtual DbSet<NamePhone> NamePhones { get; set; }

    public virtual DbSet<ReservationProducts> ReservationProducts { get; set; }

    public virtual DbSet<ReservationProductPrices> ReservationProductPrices { get; set; }

    public virtual DbSet<ProductPostingRules> ProductPostingRules { get; set; }

    public virtual DbSet<NameDocuments> NameDocuments { get; set; }

    public virtual DbSet<NameAddress> NameAddresses { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<NameData> NameData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseOracle(connectioString, options => options
            .UseOracleSQLCompatibility("11"));
    }
}
