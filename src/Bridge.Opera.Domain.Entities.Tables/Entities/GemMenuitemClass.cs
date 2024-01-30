namespace Bridge.Opera.Domain.Entities.Tables;

public partial class GemMenuitemClass
{
    public GemMenuitemClass()
    {
        GemMenuitem = new HashSet<GemMenuitem>();
        GemMenuitemcDepartment = new HashSet<GemMenuitemcDepartment>();
    }

    public decimal? MicId { get; set; }
    public string? Resort { get; set; }
    public string? MicName { get; set; }
    public string? BeverageClass { get; set; }
    public string? IconName { get; set; }
    public decimal? OrderBy { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? WebBookingYn { get; set; }

    public virtual ICollection<GemMenuitem> GemMenuitem { get; set; }
    public virtual ICollection<GemMenuitemcDepartment> GemMenuitemcDepartment { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<GemMenuitemClass>(entity =>
        {
            entity.HasKey(e => e.MicId)
                .HasName("MIC_PK");

            entity.ToTable("GEM$MENUITEM_CLASS");

            entity.Property(e => e.MicId)
                .HasColumnName("MIC_ID")
                .HasColumnType("NUMBER");

            entity.Property(e => e.BeverageClass)
                .HasColumnName("BEVERAGE_CLASS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IconName)
                .HasColumnName("ICON_NAME")
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.InactiveDate)
                .HasColumnName("INACTIVE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.MicName)
                .HasColumnName("MIC_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.OrderBy)
                .HasColumnName("ORDER_BY")
                .HasColumnType("NUMBER");

            entity.Property(e => e.Resort)
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false);
        
			if (!types.Contains(typeof(GemMenuitem)))
				entity.Ignore(e => e.GemMenuitem);

			if (!types.Contains(typeof(GemMenuitemcDepartment)))
				entity.Ignore(e => e.GemMenuitemcDepartment);
		});
	}
}
