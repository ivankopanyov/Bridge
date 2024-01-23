namespace Bridge.Opera.Domain.Entities.Tables;

public partial class RevenueGroups
{
    public RevenueGroups()
    {
        RevenueGroupsTranslation = new HashSet<RevenueGroupsTranslation>();
        RevenueTypes = new HashSet<RevenueTypes>();
    }

    public string RevGroup { get; set; }
    public string Label { get; set; }
    public string Description { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string ChainCode { get; set; }
    public decimal? BiBucket { get; set; }
    public string BiLabel { get; set; }

    public virtual ICollection<RevenueGroupsTranslation> RevenueGroupsTranslation { get; set; }
    public virtual ICollection<RevenueTypes> RevenueTypes { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<RevenueGroups>(entity =>
        {
            entity.HasKey(e => new { e.ChainCode, e.RevGroup })
                .HasName("RTG_PK");

            entity.ToTable("REVENUE$GROUPS");

            entity.Property(e => e.ChainCode)
                .HasColumnName("CHAIN_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RevGroup)
                .HasColumnName("REV_GROUP")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BiBucket)
                .HasColumnName("BI_BUCKET")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BiLabel)
                .HasColumnName("BI_LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
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

            entity.Property(e => e.Label)
                .HasColumnName("LABEL")
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");
        
			if (!types.Contains(typeof(RevenueGroupsTranslation)))
				entity.Ignore(e => e.RevenueGroupsTranslation);

			if (!types.Contains(typeof(RevenueTypes)))
				entity.Ignore(e => e.RevenueTypes);
		});
	}
}
