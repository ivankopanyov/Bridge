namespace Bridge.Opera.Domain.Entities.Tables;

public partial class ScPackage
{
    public ScPackage()
    {
        ScPkgEvent = new HashSet<ScPkgEvent>();
        ScPkgPrice = new HashSet<ScPkgPrice>();
        ScPkgTranslation = new HashSet<ScPkgTranslation>();
    }

    public decimal? PkgId { get; set; }
    public string? Resort { get; set; }
    public string? PkgCode { get; set; }
    public string? PkgName { get; set; }
    public decimal? Duration { get; set; }
    public DateTime? InsertDate { get; set; }
    public decimal? InsertUser { get; set; }
    public DateTime? UpdateDate { get; set; }
    public decimal? UpdateUser { get; set; }
    public DateTime? InactiveDate { get; set; }
    public string? TemplateYn { get; set; }
    public string? WebBookingYn { get; set; }

    public virtual ICollection<ScPkgEvent> ScPkgEvent { get; set; }
    public virtual ICollection<ScPkgPrice> ScPkgPrice { get; set; }
    public virtual ICollection<ScPkgTranslation> ScPkgTranslation { get; set; }

	public static void OnModelCreating(ModelBuilder modelBuilder, ISet<Type> types)
	{
		modelBuilder.Entity<ScPackage>(entity =>
        {
            entity.HasKey(e => e.PkgId)
                .HasName("PKG_PK");

            entity.ToTable("SC$PACKAGE");

            entity.HasIndex(e => new { e.Resort, e.PkgCode })
                .HasName("PKG_UK")
                .IsUnique();

            entity.Property(e => e.PkgId)
                .HasColumnName("PKG_ID")
                .HasColumnType("NUMBER")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Duration)
                .HasColumnName("DURATION")
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

            entity.Property(e => e.PkgCode)
                .IsRequired()
                .HasColumnName("PKG_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PkgName)
                .HasColumnName("PKG_NAME")
                .HasMaxLength(200)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Resort)
                .IsRequired()
                .HasColumnName("RESORT")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.TemplateYn)
                .HasColumnName("TEMPLATE_YN")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.UpdateDate)
                .HasColumnName("UPDATE_DATE")
                .HasColumnType("DATE");

            entity.Property(e => e.UpdateUser)
                .HasColumnName("UPDATE_USER")
                .HasColumnType("NUMBER");

            entity.Property(e => e.WebBookingYn)
                .HasColumnName("WEB_BOOKING_YN")
                .HasMaxLength(1)
                .IsUnicode(false)
                .ValueGeneratedOnAdd();
        
			if (!types.Contains(typeof(ScPkgEvent)))
				entity.Ignore(e => e.ScPkgEvent);

			if (!types.Contains(typeof(ScPkgPrice)))
				entity.Ignore(e => e.ScPkgPrice);

			if (!types.Contains(typeof(ScPkgTranslation)))
				entity.Ignore(e => e.ScPkgTranslation);
		});
	}
}
