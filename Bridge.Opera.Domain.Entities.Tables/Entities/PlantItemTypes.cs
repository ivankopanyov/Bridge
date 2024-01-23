namespace Bridge.Opera.Domain.Entities.Tables;

public partial class PlantItemTypes
{
    public PlantItemTypes()
    {
        PlantItems = new HashSet<PlantItems>();
    }

    public string Resort { get; set; }
    public string TypeCode { get; set; }
    public string Description { get; set; }

    public virtual ICollection<PlantItems> PlantItems { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<PlantItemTypes>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.TypeCode })
                .HasName("PIT_PK");

            entity.ToTable("PLANT_ITEM_TYPES");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TypeCode)
                .HasColumnName("TYPE_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(PlantItems)))
				entity.Ignore(e => e.PlantItems);
		});
	}
}
