namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GdsRateLevel
{
    public GdsRateLevel()
    {
        GdsConvRateCodes = new HashSet<GdsConvRateCodes>();
    }

    public string GdsHost { get; set; }
    public string GdsRateLevel1 { get; set; }
    public string Description { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal UpdateUser { get; set; }

    public virtual ICollection<GdsConvRateCodes> GdsConvRateCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GdsRateLevel>(entity =>
        {
            entity.HasKey(e => new { e.GdsHost, e.GdsRateLevel1 })
                .HasName("GDS_RATE_LEVEL_PK");

            entity.ToTable("GDS_RATE_LEVEL");

            entity.Property(e => e.GdsHost)
                .HasColumnName("GDS_HOST")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.GdsRateLevel1)
                .HasColumnName("GDS_RATE_LEVEL")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(GdsConvRateCodes)))
				entity.Ignore(e => e.GdsConvRateCodes);
		});
	}
}
