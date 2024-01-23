namespace Bridge.Opera.Domain.Entities.Views;
	
public partial class NegCatPkgCollectionsV
{
    public decimal NameId { get; set; }
    public decimal PkgCollectionSeq { get; set; }
    public string Resort { get; set; }
    public string NcpcCode { get; set; }
    public string Description { get; set; }
    public decimal PkgId { get; set; }
    public string PkgResort { get; set; }
    public string PkgCode { get; set; }
    public string PkgName { get; set; }
    public decimal PkgDuration { get; set; }
    public DateTime? PkgInactiveDate { get; set; }
    public DateTime SellBeginDate { get; set; }
    public DateTime? SellEndDate { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public decimal InsertUser { get; set; }
    public DateTime InsertDate { get; set; }
    public decimal UpdateUser { get; set; }
    public DateTime UpdateDate { get; set; }
    public decimal DetInsertUser { get; set; }
    public DateTime DetInsertDate { get; set; }
    public decimal DetUpdateUser { get; set; }
    public DateTime DetUpdateDate { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<NegCatPkgCollectionsV>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NEG_CAT_PKG_COLLECTIONS_V");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.DetInsertDate)
                .HasColumnName("DET_INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DetInsertUser)
                .HasColumnName("DET_INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.DetUpdateDate)
                .HasColumnName("DET_UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.DetUpdateUser)
                .HasColumnName("DET_UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NameId)
                .HasColumnName("NAME_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.NcpcCode)
                .IsRequired()
                .HasColumnName("NCPC_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgCode)
                .IsRequired()
                .HasColumnName("PKG_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PkgCollectionSeq)
                .HasColumnName("PKG_COLLECTION_SEQ")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgDuration)
                .HasColumnName("PKG_DURATION")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.PkgInactiveDate)
                .HasColumnName("PKG_INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.PkgName)
                .HasColumnName("PKG_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PkgResort)
                .IsRequired()
                .HasColumnName("PKG_RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SellBeginDate)
                .HasColumnName("SELL_BEGIN_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.SellEndDate)
                .HasColumnName("SELL_END_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        });
	}
}
