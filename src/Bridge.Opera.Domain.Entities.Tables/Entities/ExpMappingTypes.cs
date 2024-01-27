namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ExpMappingTypes
{
    public ExpMappingTypes()
    {
        ExpMappingCodes = new HashSet<ExpMappingCodes>();
    }

    public decimal ExpMappingId { get; set; }
    public string Resort { get; set; }
    public string ConfigType { get; set; }
    public string MappingType { get; set; }
    public string TypeDesc { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }

    public virtual ICollection<ExpMappingCodes> ExpMappingCodes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ExpMappingTypes>(entity =>
        {
            entity.HasKey(e => e.ExpMappingId)
                .HasName("EXP_MAPT_PK");

            entity.ToTable("EXP_MAPPING_TYPES");

            entity.HasIndex(e => new { e.ConfigType, e.Resort, e.MappingType })
                .HasName("EXP_MAPPING_TYPES_UK")
                .IsUnique();

            entity.Property(e => e.ExpMappingId)
                .HasColumnName("EXP_MAPPING_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ConfigType)
                .IsRequired()
                .HasColumnName("CONFIG_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MappingType)
                .IsRequired()
                .HasColumnName("MAPPING_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeDesc)
                .HasColumnName("TYPE_DESC")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(ExpMappingCodes)))
				entity.Ignore(e => e.ExpMappingCodes);
		});
	}
}
