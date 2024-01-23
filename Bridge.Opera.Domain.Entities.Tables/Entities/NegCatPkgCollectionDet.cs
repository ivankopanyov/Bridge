namespace Bridge.Opera.Domain.Entities.Tables;

public partial class NegCatPkgCollectionDet
{
    public decimal PkgCollectionSeq { get; set; }
    public decimal PkgId { get; set; }
    public DateTime SellBeginDate { get; set; }
    public DateTime? SellEndDate { get; set; }
    public decimal? OrderBy { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }

    public virtual ScPackage Pkg { get; set; }
    public virtual NegCatPkgCollection PkgCollectionSeqNavigation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NegCatPkgCollectionDet>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NEG_CAT_PKG_COLLECTION_DET");

            entity.HasIndex(e => e.PkgId)
                .HasName("NCPCD_SCPKG_FKI");

            entity.HasIndex(e => new { e.PkgCollectionSeq, e.PkgId, e.SellBeginDate, e.SellEndDate })
                .HasName("NCPCD_UK")
                .IsUnique();

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgCollectionSeq)
                .HasColumnName("PKG_COLLECTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.SellBeginDate)
                .HasColumnName("SELL_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SellEndDate)
                .HasColumnName("SELL_END_DATE")
                .HasColumnType("DATE");

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
	                .WithMany()
	                .HasForeignKey(d => d.PkgCollectionSeq)
	                .HasConstraintName("NCPCD_NCPC_FK");

			if (!types.Contains(typeof(ScPackage)))
				entity.Ignore(e => e.Pkg);
			else
	            entity.HasOne(d => d.Pkg)
	                .WithMany()
	                .HasForeignKey(d => d.PkgId)
	                .HasConstraintName("NCPCD_SCPKG_FK");
        });
	}
}
