namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NegCatPkgCollectionLink
{
    public decimal PkgCollectionSeq { get; set; }
    public decimal NameId { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual NegCatPkgCollection PkgCollectionSeqNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NegCatPkgCollectionLink>(entity =>
        {
            entity.HasKey(e => new { e.PkgCollectionSeq, e.NameId })
                .HasName("NCPCL_PK");

            entity.ToTable("NEG_CAT_PKG_COLLECTION$LINK");

            entity.Property(e => e.PkgCollectionSeq)
                .HasColumnName("PKG_COLLECTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

			if (!types.Contains(typeof(NegCatPkgCollection)))
				entity.Ignore(e => e.PkgCollectionSeqNavigation);
			else
	            entity.HasOne(d => d.PkgCollectionSeqNavigation)
	                .WithMany(p => p.NegCatPkgCollectionLink)
	                .HasForeignKey(d => d.PkgCollectionSeq)
	                .HasConstraintName("NCPCL_NCPC_FK");
        });
	}
}
