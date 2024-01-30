namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsAirptUpdate
{
    public string? Resort { get; set; }
    public string? AirportCode { get; set; }
    public string? Distance { get; set; }
    public string? Direction { get; set; }
    public string? DistanceUnits { get; set; }
    public string? PrimaryTransport { get; set; }
    public decimal? PropupId { get; set; }

    public virtual GdsPropupUpdate Propup { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsAirptUpdate>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.AirportCode })
                .HasName("GDS_AIRPT_UPDATE_PK");

            entity.ToTable("GDS_AIRPT_UPDATE");

            entity.HasIndex(e => e.PropupId)
                .HasName("GDS_AIRPT_UPDATE_IND1");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.AirportCode)
                .HasColumnName("AIRPORT_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Direction)
                .IsRequired()
                .HasColumnName("DIRECTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Distance)
                .IsRequired()
                .HasColumnName("DISTANCE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DistanceUnits)
                .IsRequired()
                .HasColumnName("DISTANCE_UNITS")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryTransport)
                .IsRequired()
                .HasColumnName("PRIMARY_TRANSPORT")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.PropupId)
                .HasColumnName("PROPUP_ID")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(GdsPropupUpdate)))
				entity.Ignore(e => e.Propup);
			else
	            entity.HasOne(d => d.Propup)
	                .WithMany(p => p.GdsAirptUpdate)
	                .HasForeignKey(d => d.PropupId)
	                .HasConstraintName("GDS_AIRPT_UPDATE_FK1");
        });
	}
}
