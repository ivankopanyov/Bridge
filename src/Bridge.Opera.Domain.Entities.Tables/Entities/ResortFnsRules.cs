namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ResortFnsRules
{
    public string Resort { get; set; }
    public decimal MinOccupancy { get; set; }
    public decimal MaxOccupancy { get; set; }
    public string CalculationType { get; set; }
    public decimal? FnsAmount { get; set; }
    public decimal? AdrPercentage { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual Resort ResortNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ResortFnsRules>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.MinOccupancy })
                .HasName("RESORT_FNS_RULES_PK");

            entity.ToTable("RESORT_FNS_RULES");

            entity.HasIndex(e => new { e.Resort, e.MaxOccupancy, e.MinOccupancy })
                .HasName("FNS_RULE_MAX_MIN_UK")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MinOccupancy)
                .HasColumnName("MIN_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.AdrPercentage)
                .HasColumnName("ADR_PERCENTAGE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.CalculationType)
                .IsRequired()
                .HasColumnName("CALCULATION_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.FnsAmount)
                .HasColumnName("FNS_AMOUNT")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MaxOccupancy)
                .HasColumnName("MAX_OCCUPANCY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(Resort)))
				entity.Ignore(e => e.ResortNavigation);
			else
	            entity.HasOne(d => d.ResortNavigation)
	                .WithMany(p => p.ResortFnsRules)
	                .HasForeignKey(d => d.Resort)
	                .OnDelete(DeleteBehavior.ClientSetNull)
	                .HasConstraintName("FNS_RULE_RESORT_FK");
        });
	}
}
