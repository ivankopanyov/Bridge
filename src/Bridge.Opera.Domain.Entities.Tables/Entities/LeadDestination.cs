namespace Bridge.Opera.Domain.Entities.Tables;

public partial class LeadDestination
{
    public decimal? LeadId { get; set; }
    public string? LeadResort { get; set; }
    public string? LeadDestination1 { get; set; }
    public string? DestinationDesc { get; set; }
    public string? DestinationLocation { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? InsertDate { get; set; }

    public virtual AllotmentHeader Lead { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<LeadDestination>(entity =>
        {
            entity.HasKey(e => new { e.LeadId, e.LeadResort, e.LeadDestination1 })
                .HasName("LEADDEST_PK");

            entity.ToTable("LEAD_DESTINATION");

            entity.Property(e => e.LeadId)
                .HasColumnName("LEAD_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.LeadResort)
                .HasColumnName("LEAD_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.LeadDestination1)
                .HasColumnName("LEAD_DESTINATION")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.DestinationDesc)
                .HasColumnName("DESTINATION_DESC")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DestinationLocation)
                .HasColumnName("DESTINATION_LOCATION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(AllotmentHeader)))
				entity.Ignore(e => e.Lead);
			else
	            entity.HasOne(d => d.Lead)
	                .WithMany(p => p.LeadDestination)
	                .HasForeignKey(d => new { d.LeadId, d.LeadResort })
	                .HasConstraintName("LEADDEST_AH_FK");
        });
	}
}
