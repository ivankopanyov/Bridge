namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PropertyPriceRange
{
    public string? Resort { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? MinRate { get; set; }
    public decimal? MaxRate { get; set; }
    public string? CurrencyCode { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PropertyPriceRange>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.EndDate, e.BeginDate })
                .HasName("PPR_PK");

            entity.ToTable("PROPERTY_PRICE_RANGE");

            entity.HasIndex(e => e.CurrencyCode)
                .HasName("PPR_CURRENCY_IDX");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EndDate)
                .HasColumnName("END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.BeginDate)
                .HasColumnName("BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.CurrencyCode)
                .HasColumnName("CURRENCY_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MaxRate)
                .HasColumnName("MAX_RATE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MinRate)
                .HasColumnName("MIN_RATE")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.PropertyPriceRange)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("PPR_RESORT_FK");
        });
	}
}
