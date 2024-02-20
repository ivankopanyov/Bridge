namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortOutlet
{
    public string? OutletCode { get; set; }
    public string? Description { get; set; }
    public string? OutletType { get; set; }
    public decimal? BookingDuration { get; set; }
    public string? Resort { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortOutlet>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.OutletCode })
                .HasName("OUTLET_PK");

            entity.ToTable("RESORT_OUTLET");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BookingDuration)
                .HasColumnName("BOOKING_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OutletType)
                .IsRequired()
                .HasColumnName("OUTLET_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ResortOutlet)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("RESORT_OUTLET_FK");
        });
	}
}
