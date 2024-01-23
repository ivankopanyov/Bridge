namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NegCatPkgCollection
{
    public NegCatPkgCollection()
    {
        NegCatPkgCollectionLink = new HashSet<NegCatPkgCollectionLink>();
    }

    public decimal PkgCollectionSeq { get; set; }
    public string Resort { get; set; }
    public string NcpcCode { get; set; }
    public string Description { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual ICollection<NegCatPkgCollectionLink> NegCatPkgCollectionLink { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NegCatPkgCollection>(entity =>
        {
            entity.HasKey(e => e.PkgCollectionSeq)
                .HasName("NEG_CAT_PKG_COLLECTION_PK");

            entity.ToTable("NEG_CAT_PKG_COLLECTION");

            entity.HasIndex(e => new { e.Resort, e.NcpcCode })
                .HasName("NEG_CAT_PKG_COLLECTION_UK")
                .IsUnique();

            entity.Property(e => e.PkgCollectionSeq)
                .HasColumnName("PKG_COLLECTION_SEQ")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.NcpcCode)
                .IsRequired()
                .HasColumnName("NCPC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(NegCatPkgCollectionLink)))
				entity.Ignore(e => e.NegCatPkgCollectionLink);
		});
	}
}
