namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class ScBusblockByActivity
{
    public string? Type { get; set; }
    public decimal? ActId { get; set; }
    public string? ActResort { get; set; }
    public string? PrimaryYn { get; set; }
    public string? BusblockProperty { get; set; }
    public decimal? BusblockId { get; set; }
    public DateTime? BusblockArrival { get; set; }
    public DateTime? BusblockDeparture { get; set; }
    public string? BusblockName { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScBusblockByActivity>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SC_BUSBLOCK_BY_ACTIVITY");

            entity.Property(e => e.ActId)
                .HasColumnName("ACT_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ActResort)
                .HasColumnName("ACT_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BusblockArrival)
                .HasColumnName("BUSBLOCK_ARRIVAL")
                .HasColumnType("DATE");

            entity.Property(e => e.BusblockDeparture)
                .HasColumnName("BUSBLOCK_DEPARTURE")
                .HasColumnType("DATE");

            entity.Property(e => e.BusblockId)
                .HasColumnName("BUSBLOCK_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BusblockName)
                .IsRequired()
                .HasColumnName("BUSBLOCK_NAME")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.BusblockProperty)
                .IsRequired()
                .HasColumnName("BUSBLOCK_PROPERTY")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryYn)
                .HasColumnName("PRIMARY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);
        });
	}
}
