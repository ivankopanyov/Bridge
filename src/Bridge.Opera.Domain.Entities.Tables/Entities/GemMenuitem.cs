namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemMenuitem
{
    public GemMenuitem()
    {
        GemMenuDetails = new HashSet<GemMenuDetails>();
        GemMenuitemDepartment = new HashSet<GemMenuitemDepartment>();
        GemMenuitemTranslation = new HashSet<GemMenuitemTranslation>();
        GemMenuitemVendor = new HashSet<GemMenuitemVendor>();
    }

    public string? Resort { get; set; }
    public decimal? MitId { get; set; }
    public decimal? MenuClassId { get; set; }
    public string? Name1 { get; set; }
    public string? Name2 { get; set; }
    public string? Name3 { get; set; }
    public string? Description { get; set; }
    public string? Restrictions { get; set; }
    public string? Origin1 { get; set; }
    public string? Origin2 { get; set; }
    public string? Origin3 { get; set; }
    public string? Beverage { get; set; }
    public byte? Year { get; set; }
    public decimal? SalesPrice { get; set; }
    public decimal? Cost { get; set; }
    public string? Portion { get; set; }
    public decimal? ContainerId { get; set; }
    public string? ContainerCode { get; set; }
    public string? Container { get; set; }
    public decimal? Serving { get; set; }
    public string? IncludedYn { get; set; }
    public string? ArticleNumber { get; set; }
    public string? RevenueType { get; set; }
    public string? ShowbeoYn { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? ConsumptionYn { get; set; }
    public string? WebBookingYn { get; set; }

    public virtual GemTranslation ContainerNavigation { get; set; }
    public virtual GemMenuitemClass MenuClass { get; set; }
    public virtual ICollection<GemMenuDetails> GemMenuDetails { get; set; }
    public virtual ICollection<GemMenuitemDepartment> GemMenuitemDepartment { get; set; }
    public virtual ICollection<GemMenuitemTranslation> GemMenuitemTranslation { get; set; }
    public virtual ICollection<GemMenuitemVendor> GemMenuitemVendor { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuitem>(entity =>
        {
            entity.HasKey(e => new { e.Resort, e.MitId })
                .HasName("MIT_PK");

            entity.ToTable("GEM$MENUITEM");

            entity.HasIndex(e => e.ContainerId)
                .HasName("MIT_GT_FK_IDX");

            entity.HasIndex(e => e.MenuClassId)
                .HasName("MIT_MENC_IDX");

            entity.HasIndex(e => e.RevenueType)
                .HasName("MIT_REVTYPE_IDX");

            entity.HasIndex(e => new { e.Resort, e.ArticleNumber })
                .HasName("MIT_ARTICLENO_UK")
                .IsUnique();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MitId)
                .HasColumnName("MIT_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ArticleNumber)
                .HasColumnName("ARTICLE_NUMBER")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Beverage)
                .HasColumnName("BEVERAGE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConsumptionYn)
                .HasColumnName("CONSUMPTION_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Container)
                .HasColumnName("CONTAINER")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContainerCode)
                .HasColumnName("CONTAINER_CODE")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContainerId)
                .HasColumnName("CONTAINER_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Cost)
                .HasColumnName("COST")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.IncludedYn)
                .HasColumnName("INCLUDED_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.InsertDate)
                .HasColumnName("INSERT_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.InsertUser)
                .HasColumnName("INSERT_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.MenuClassId)
                .HasColumnName("MENU_CLASS_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Name1)
                .HasColumnName("NAME1")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name2)
                .HasColumnName("NAME2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Name3)
                .HasColumnName("NAME3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Origin1)
                .HasColumnName("ORIGIN_1")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Origin2)
                .HasColumnName("ORIGIN_2")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Origin3)
                .HasColumnName("ORIGIN_3")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Portion)
                .HasColumnName("PORTION")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Restrictions)
                .HasColumnName("RESTRICTIONS")
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.RevenueType)
                .IsRequired()
                .HasColumnName("REVENUE_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.SalesPrice)
                .HasColumnName("SALES_PRICE")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Serving)
                .HasColumnName("SERVING")
                .HasColumnType("NUMBER");

            entity.Property(e => e.ShowbeoYn)
                .HasColumnName("SHOWBEO_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql(@"'Y'");

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Year)
                .HasColumnName("YEAR")
                .HasColumnType("NUMBER(4)");

			if (!types.Contains(typeof(GemTranslation)))
				entity.Ignore(e => e.ContainerNavigation);
			else
	            entity.HasOne(d => d.ContainerNavigation)
	                .WithMany(p => p.GemMenuitem)
	                .HasForeignKey(d => d.ContainerId)
	                .HasConstraintName("MIT_GT_FK");

			if (!types.Contains(typeof(GemMenuitemClass)))
				entity.Ignore(e => e.MenuClass);
			else
	            entity.HasOne(d => d.MenuClass)
	                .WithMany(p => p.GemMenuitem)
	                .HasForeignKey(d => d.MenuClassId)
	                .HasConstraintName("MIT_MIC_FK");
        
			if (!types.Contains(typeof(GemMenuDetails)))
				entity.Ignore(e => e.GemMenuDetails);

			if (!types.Contains(typeof(GemMenuitemDepartment)))
				entity.Ignore(e => e.GemMenuitemDepartment);

			if (!types.Contains(typeof(GemMenuitemTranslation)))
				entity.Ignore(e => e.GemMenuitemTranslation);

			if (!types.Contains(typeof(GemMenuitemVendor)))
				entity.Ignore(e => e.GemMenuitemVendor);
		});
	}
}
