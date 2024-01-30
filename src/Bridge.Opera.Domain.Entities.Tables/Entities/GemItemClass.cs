namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemItemClass
{
    public GemItemClass()
    {
        GemItem = new HashSet<GemItem>();
        GemItemcDepartment = new HashSet<GemItemcDepartment>();
        GemItemcTranslation = new HashSet<GemItemcTranslation>();
        ItemcEvtype = new HashSet<ItemcEvtype>();
    }

    public decimal? ItemclassId { get; set; }
    public string? Resort { get; set; }
    public string? Description { get; set; }
    public string? IconName { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? UsedInApp { get; set; }
    public string? DiscountableYn { get; set; }
    public string? ItemclassCode { get; set; }
    public string? WebBookingYn { get; set; }

    public virtual ICollection<GemItem> GemItem { get; set; }
    public virtual ICollection<GemItemcDepartment> GemItemcDepartment { get; set; }
    public virtual ICollection<GemItemcTranslation> GemItemcTranslation { get; set; }
    public virtual ICollection<ItemcEvtype> ItemcEvtype { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemItemClass>(entity =>
        {
            entity.HasKey(e => e.ItemclassId)
                .HasName("ITMC_PK");

            entity.ToTable("GEM$ITEM_CLASS");

            entity.HasIndex(e => new { e.Resort, e.ItemclassCode, e.OrderBy })
                .HasName("ITMC_UK")
                .IsUnique();

            entity.Property(e => e.ItemclassId)
                .HasColumnName("ITEMCLASS_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.DiscountableYn)
                .HasColumnName("DISCOUNTABLE_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IconName)
                .HasColumnName("ICON_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.ItemclassCode)
                .HasColumnName("ITEMCLASS_CODE")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UsedInApp)
                .HasColumnName("USED_IN_APP")
                .HasMaxLength(20)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(GemItem)))
				entity.Ignore(e => e.GemItem);

			if (!types.Contains(typeof(GemItemcDepartment)))
				entity.Ignore(e => e.GemItemcDepartment);

			if (!types.Contains(typeof(GemItemcTranslation)))
				entity.Ignore(e => e.GemItemcTranslation);

			if (!types.Contains(typeof(ItemcEvtype)))
				entity.Ignore(e => e.ItemcEvtype);
		});
	}
}
