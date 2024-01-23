namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemgroup
{
    public GemItemgroup()
    {
        GemItemgTranslation = new HashSet<GemItemgTranslation>();
        GemItemgroupRates = new HashSet<GemItemgroupRates>();
    }

    public decimal ItemgroupId { get; set; }
    public string Name { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public string Resort { get; set; }
    public string TemplateYn { get; set; }
    public string HourlyYn { get; set; }

    public virtual ICollection<GemItemgTranslation> GemItemgTranslation { get; set; }
    public virtual ICollection<GemItemgroupRates> GemItemgroupRates { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemgroup>(entity =>
        {
            entity.HasKey(e => e.ItemgroupId)
                .HasName("ITG_PK");

            entity.ToTable("GEM$ITEMGROUP");

            entity.Property(e => e.ItemgroupId)
                .HasColumnName("ITEMGROUP_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.HourlyYn)
                .HasColumnName("HOURLY_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateYn)
                .HasColumnName("TEMPLATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(GemItemgTranslation)))
				entity.Ignore(e => e.GemItemgTranslation);

			if (!types.Contains(typeof(GemItemgroupRates)))
				entity.Ignore(e => e.GemItemgroupRates);
		});
	}
}
