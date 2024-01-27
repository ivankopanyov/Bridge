namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RevenueTypes
{
    public RevenueTypes()
    {
        RevenueTypesDetails = new HashSet<RevenueTypesDetails>();
        RevenueTypesTranslation = new HashSet<RevenueTypesTranslation>();
    }

    public string RevType { get; set; }
    public string RevGroup { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }
    public string FbClass { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string ChainCode { get; set; }
    public decimal? Vat { get; set; }

    public virtual RevenueGroups RevenueGroups { get; set; }
    public virtual ICollection<RevenueTypesDetails> RevenueTypesDetails { get; set; }
    public virtual ICollection<RevenueTypesTranslation> RevenueTypesTranslation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RevenueTypes>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RevType })
                .HasName("REVT_PK");

            entity.ToTable("REVENUE$TYPES");

            entity.HasIndex(e => new { e.ChainCode, e.RevGroup })
                .HasName("REVT_REVG_IDX");

            entity.HasIndex(e => new { e.ChainCode, e.RevType, e.RevGroup })
                .HasName("REVT_UK")
                .IsUnique();

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevType)
                .HasColumnName("REV_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FbClass)
                .HasColumnName("FB_CLASS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.RevGroup)
                .IsRequired()
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Vat)
                .HasColumnName("VAT")
                .HasColumnType("NUMBER");

			if (!types.Contains(typeof(RevenueGroups)))
				entity.Ignore(e => e.RevenueGroups);
			else
	            entity.HasOne(d => d.RevenueGroups)
	                .WithMany(p => p.RevenueTypes)
	                .HasForeignKey(d => new { d.ChainCode, d.RevGroup })
	                .HasConstraintName("REVT_REVG_FK");
        
			if (!types.Contains(typeof(RevenueTypesDetails)))
				entity.Ignore(e => e.RevenueTypesDetails);

			if (!types.Contains(typeof(RevenueTypesTranslation)))
				entity.Ignore(e => e.RevenueTypesTranslation);
		});
	}
}
