namespace Bridge.Opera.Domain.Entities.Tables;

public partial class SpareParts
{
    public SpareParts()
    {
        PartsUsed = new HashSet<PartsUsed>();
    }

    public string Resort { get; set; }
    public string PartGroup { get; set; }
    public string Type { get; set; }
    public string PartCode { get; set; }
    public string Description { get; set; }
    public decimal? UnitPrice { get; set; }

    public virtual ICollection<PartsUsed> PartsUsed { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<SpareParts>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.PartCode })
                .HasName("SP_PK");

            entity.ToTable("SPARE_PARTS");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PartCode)
                .HasColumnName("PART_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.PartGroup)
                .IsRequired()
                .HasColumnName("PART_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasColumnName("TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UnitPrice)
                .HasColumnName("UNIT_PRICE")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(PartsUsed)))
				entity.Ignore(e => e.PartsUsed);
		});
	}
}
